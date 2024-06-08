using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SportsBattle.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SportsBattle.Controllers
{
    public class PlayerController : Controller
    {
        clsAdminLogic db;
        private readonly IHostingEnvironment _hostingEnvironment;

        static string base64String = null;
        public PlayerController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            db = new clsAdminLogic();
        } 
        public IActionResult AllPlayer( string Type)
        {
            clsPlayer objP = new clsPlayer();
            objP.Action = Type;
            objP.dtDetails = db.PlayerDetails(objP);
            return View(objP);
        }
        [HttpPost]
        public IActionResult AllPlayer(clsPlayer objP)
        {
            objP.Action = "GetAlluser";
            objP.dtDetails = db.PlayerAllDetails(objP);
            return View(objP);
        }

        public JsonResult UpdateStatus(string UserID, string Status)
        {
            string msg = "0";
            clsPlayer objP = new clsPlayer();
            objP.Action = "UpdateUserStatus";
            objP.Status = Status;
            objP.UserID = UserID; 
            DataTable dt = db.PlayerDetails(objP);
            if (dt != null && dt.Rows.Count > 0)
            {
                msg = Convert.ToString(dt.Rows[0]["msg"]);














            }
            return Json(msg);
        }


        public IActionResult WaitingTable()
        {
            clsPlayer objP = new clsPlayer();
            objP.Action = "WaitingTable";
            objP.dtDetails = db.PlayerDetails(objP);
            return View(objP);
        }  
        [HttpPost]
        public IActionResult WaitingTable(clsPlayer objP)
        {
            objP.Action = "WaitingTable";
            objP.dtDetails = db.PlayerDetails(objP);
            return View(objP);
        }
        public IActionResult TableFullView(string type)
        {
            clsPlayer objP = new clsPlayer();
            objP.ChallengeId = type;
            objP.Action = "TableFullView";
            objP.dtDetails = db.PlayerDetails(objP);
            objP.Action = "TransactionHistory";
            objP.dtDetails1 = db.PlayerDetails(objP);
            return View(objP);
        } 
        
        public IActionResult RunningMatch()
        {
            clsPlayer objP = new clsPlayer();
            objP.Action = "RunningMatch";
            objP.dtDetails = db.PlayerDetails(objP);
            return View(objP);
        }  
        [HttpPost]
        public IActionResult RunningMatch(clsPlayer objP)
        {
            objP.Action = "RunningMatch";
            objP.dtDetails = db.PlayerDetails(objP);
            return View(objP);
        }
        public IActionResult PendingMatch()
        {
            clsPlayer objP = new clsPlayer();
            objP.Action = "PendingMatch";
            objP.dtDetails = db.PlayerDetails(objP);
            return View(objP);
        }  
        [HttpPost]
        public IActionResult PendingMatch(clsPlayer objP)
        {
            objP.Action = "PendingMatch";
            objP.dtDetails = db.PlayerDetails(objP);
            return View(objP);
        } 
        public IActionResult CompletedMatch()
        {
            clsPlayer objP = new clsPlayer();
            objP.Action = "CompletedMatch";
            objP.dtDetails = db.PlayerDetails(objP);
            return View(objP);
        } 
        [HttpPost]
        public IActionResult CompletedMatch(clsPlayer objP)
        {
            objP.Action = "CompletedMatch";
            objP.dtDetails = db.PlayerDetails(objP);
            return View(objP);
        }

        public IActionResult CancelMatch()
        {
            clsPlayer objP = new clsPlayer();
            objP.Action = "CancelMatch";
            objP.dtDetails = db.PlayerDetails(objP);
            return View(objP);
        }
        [HttpPost]
        public IActionResult CancelMatch(clsPlayer objP)
        {
            objP.Action = "CancelMatch";
            objP.dtDetails = db.PlayerDetails(objP);
            return View(objP);
        }
        public IActionResult VerifiedMatch()
        {
            clsPlayer objP = new clsPlayer();
            objP.Action = "VerifiedMatch";
            objP.dtDetails = db.PlayerDetails(objP);
            return View(objP);
        }
        [HttpPost]
        public IActionResult VerifiedMatch(clsPlayer objP)
        {
            objP.Action = "VerifiedMatch";
            objP.dtDetails = db.PlayerDetails(objP);
            return View(objP);
        }
        public IActionResult UserFullDetails(string UserID)
        {
            clsPlayer objP = new clsPlayer();
            DataSet dsDetails = new DataSet();
            objP.UserID = UserID;
            objP.Action = "UserFullDetails";
            objP.dtDetails = db.PlayerDetails(objP); 
            objP.Action = "UserHistory";
            dsDetails = db.UserHistory(objP);
            if (dsDetails.Tables.Count > 0)
            {
                if(dsDetails.Tables.Count>=1)
                {
                    objP.dtTransactionHistory = dsDetails.Tables[0];
                }
                if (dsDetails.Tables.Count >= 2)
                {
                    objP.dtPendingTable = dsDetails.Tables[1];
                }
                if (dsDetails.Tables.Count >= 3)
                {
                    objP.dtRunningTable = dsDetails.Tables[2];
                }
                if (dsDetails.Tables.Count >= 4)
                {
                    objP.dtComplatedTable = dsDetails.Tables[3];
                }
                if (dsDetails.Tables.Count >= 5)
                {
                    objP.dtCancelledTable = dsDetails.Tables[4];
                }
                //if (dsDetails.Tables.Count >= 6)
                //{
                //    objP.dtPayment = dsDetails.Tables[5];
                //}
                if (dsDetails.Tables.Count >= 6)
                {
                    objP.dtReferrals = dsDetails.Tables[5];
                }
            } 
            return View(objP);
        }

        public JsonResult AddPayment(string UserID,string amount_type ,string Amount ,string type ,string msg)
        {
            string msg1 = "0"; 
            clsPlayer objP = new clsPlayer();
            objP.Action = "AddPayment";
            objP.amount_type = amount_type;
            objP.Amount = Amount;
            objP.type = type;
            objP.msg = msg;
            objP.UserID = UserID;
            DataTable dt = db.PlayerDetails(objP);
            if (dt != null && dt.Rows.Count > 0)
            {
                msg1 = Convert.ToString(dt.Rows[0]["msg"]);
            }
            return Json(msg1);
        }

        public JsonResult GetRefferalDetails(string FromUserId,string ToUserId)
        {
            string msg1 = "0";
            clsPlayer objP = new clsPlayer();
            objP.Action = "getRefferalDetails";
            objP.FromUserId = FromUserId;
            objP.ToUserId = ToUserId; 
            DataTable dt = db.PlayerDetails(objP);  
            List<clsRefferalDetails> studentList = new List<clsRefferalDetails>();
            if (dt != null && dt.Rows.Count > 0)
            {
                clsRefferalDetails cc= new clsRefferalDetails(); 
                cc.FromUserId= Convert.ToString(dt.Rows[0]["FromUserId"]);
                cc.FromUserName= Convert.ToString(dt.Rows[0]["FromUserName"]);
                cc.FromProfilePic= Convert.ToString(dt.Rows[0]["FromProfilePic"]);
                cc.ToUserId= Convert.ToString(dt.Rows[0]["ToUserId"]);
                cc.ToProfilePic= Convert.ToString(dt.Rows[0]["ToProfilePic"]);
                cc.ToProfilePic= Convert.ToString(dt.Rows[0]["ToProfilePic"]);
                cc.RefferalCommissionAmount= Convert.ToString(dt.Rows[0]["RefferalCommissionAmount"]);
                cc.Date= Convert.ToString(dt.Rows[0]["EntryDate"]);
                studentList.Add(cc);  
            }
            return Json(studentList);
        }


        public JsonResult UpdateResult(string challengeId,string FirstPlayerStatus, string SecPlayerStatus )
        {
            string msg1 = "0";
            clsPlayer objP = new clsPlayer();
            objP.Action = "UpdateResult";
            objP.FirstPlayerStatus = FirstPlayerStatus;
            objP.SecPlayerStatus = SecPlayerStatus; 
            objP.ChallengeId = challengeId; 
            DataTable dt = db.PlayerDetails(objP);
            if (dt != null && dt.Rows.Count > 0)
            {
                msg1 = Convert.ToString(dt.Rows[0]["msg"]);
            }
            return Json(msg1);
        }
    }
}
