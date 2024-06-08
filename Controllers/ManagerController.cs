using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System;
using SportsBattle.Models;
using Microsoft.CodeAnalysis.Scripting;

namespace Grofinhub.Controllers
{
    public class ManagerController : Controller
    {
    public IActionResult DashBoard()
        {
            if (Convert.ToString(HttpContext.Session.GetString("Role")) == "3" || Convert.ToString(HttpContext.Session.GetString("Role")) == "4")
            {
                return View();
            }
            return RedirectToAction("Login", "Account");
        }
        public IActionResult GetMemberDocuments(string type)
        {
            if(Convert.ToString(HttpContext.Session.GetString("Role")) != "3")
                {
                return RedirectToAction("Login", "Account");
                }
            //string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
            DataTable dt = new clsAdminLogic().SaveDocDetails("", "6", type);
            return View(dt);
        }
        public IActionResult Finance_DashBoard()
        {
            if (Convert.ToString(HttpContext.Session.GetString("Role")) == "3")
            {
                return View();
            }
            return RedirectToAction("Login", "Account");
        }
        public IActionResult Investment_DashBoard()
        {
            if (Convert.ToString(HttpContext.Session.GetString("Role")) == "3")
            {
                return View();
            }
            return RedirectToAction("Login", "Account");
        }
        public IActionResult Insurance_DashBoard()
        {
            if (Convert.ToString(HttpContext.Session.GetString("Role")) == "3")
            {
                return View();
            }
            return RedirectToAction("Login", "Account");
        }
        #region new 2023/05/16
        public JsonResult UpdateDocDetailsApproveReject(string PId,string Status)
        {
            string msg;
            try
            {
                string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
                DataTable dt = new clsAdminLogic().UpdateDocDetailsApproveReject("1", Status,PId,userid);
                if(dt!=null && dt.Rows.Count>0)
                {
                    msg = dt.Rows[0]["msg"].ToString();
                }
                else
                {
                    msg = "Record Not Updated !!";
                }
            }
            catch (Exception ex)
            {
                msg = "Something Went Wrong !!";
            }
            return Json(msg);
        }
        #endregion
    }
}
