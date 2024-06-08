using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportsBattle.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SportsBattle.Controllers
{
    public class WithdrawController : Controller
    {
        clsAdminLogic db;
        private readonly IHostingEnvironment _hostingEnvironment;

        static string base64String = null;
        public WithdrawController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            db = new clsAdminLogic();
        }

        public IActionResult PendingWithdraw()
        {
            clsWithdraw objP = new clsWithdraw();
            objP.Action = "PendingWithdraw";
            objP.dtDetails = db.WithdrawDetails(objP);
            return View(objP);
        }
        [HttpPost]
        public IActionResult PendingWithdraw(clsWithdraw objP)
        {
            objP.Action = "PendingWithdraw";
            objP.dtDetails = db.WithdrawDetails(objP);
            return View(objP);
        } 

        public JsonResult UpdateStatus(string sUserId, string UserID, string Status, string TransferId, string TransferRemark, IFormFile ProofId)
        {
            string msg = "0";
            clsWithdraw objP = new clsWithdraw();
            objP.Action = "UpdateUserStatus";
            objP.Status = Status;
            objP.UserId = UserID;
            objP.TransferId = TransferId;
            objP.TransferRemark = TransferRemark;
            if (ProofId != null)
            {
                var allowedExtensions = new[] {
            ".Jpg", ".png",".pdf", ".doc",".jpg", ".jpeg" };
                var ext = Path.GetExtension(ProofId.FileName);
                if (allowedExtensions.Contains(ext))
                {
                    string wwwPath = this._hostingEnvironment.WebRootPath;
                    string contentPath = this._hostingEnvironment.ContentRootPath;
                    string path = Path.Combine(this._hostingEnvironment.WebRootPath, "Upload/Proof");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    List<string> uploadedFiles = new List<string>();
                    string fileName = Path.GetFileName(ProofId.FileName);
                    using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                    {
                        ProofId.CopyTo(stream);
                        uploadedFiles.Add(fileName);
                        ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", fileName);
                    }
                    objP.ProofId = "/Upload/Proof/" + fileName; 
                }
            }
            DataTable dt = db.WithdrawDetails(objP);
            if (dt != null && dt.Rows.Count > 0)
            {
                 
                msg = Convert.ToString(dt.Rows[0]["msg"]);
                CommonClasses sm = new CommonClasses();
                clsNotification obj = new clsNotification();
                obj.Action = "GetFCMId";
                obj.UserId = sUserId;
                DataTable dt1 = db.Notification(obj);
                obj.UserId = dt1.Rows[0]["FCM"].ToString();
                // sm.GetNotification2(obj.UserId, "Withdraw " + Status + "", "Your Withdraw Request is " + Status + "", "");  
                if (Status == "Approve")
                {
                    sm.GetNotification(obj.UserId, "Withdraw " + Status + "", "Your withdrawal request  is approved."); 
                }
                else
                {
                    sm.GetNotification(obj.UserId, "Withdraw " + Status + "", "Your withdrawal request  is cancelled."); 
                } 
            }
            return Json(msg);
        }

        public IActionResult ApproveWithdraw()
        {
            clsWithdraw objP = new clsWithdraw();
            objP.Action = "ApproveWithdraw";
            objP.dtDetails = db.WithdrawDetails(objP);
            return View(objP);
        }
        [HttpPost]
        public IActionResult ApproveWithdraw(clsWithdraw objP)
        {
            objP.Action = "ApproveWithdraw";
            objP.dtDetails = db.WithdrawDetails(objP);
            return View(objP);
        }


        public IActionResult RejectWithdraw()
        {
            clsWithdraw objP = new clsWithdraw();
            objP.Action = "RejectWithdraw";
            objP.dtDetails = db.WithdrawDetails(objP);
            return View(objP);
        }
        [HttpPost]
        public IActionResult RejectWithdraw(clsWithdraw objP)
        {
            objP.Action = "RejectWithdraw";
            objP.dtDetails = db.WithdrawDetails(objP);
            return View(objP);
        } 
        public IActionResult AllTransaction(string Type)
        {
            clsWithdraw objP = new clsWithdraw();
            objP.Action = "Transaction";
            objP.dtDetails = db.WithdrawDetails(objP);
            return View(objP);
        }
        [HttpPost]
        public IActionResult AllTransaction(clsWithdraw objP)
        {
            objP.Action = "Transaction";
            objP.dtDetails = db.WithdrawDetails(objP);
            return View(objP);
        }
    }
}
