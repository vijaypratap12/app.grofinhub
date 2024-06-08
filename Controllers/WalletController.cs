using Grofinhub.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;
using SportsBattle.Models;
using System;
using System.Data;
using System.Linq.Expressions;

namespace Grofinhub.Controllers
{
    public class WalletController : Controller
    {

        WalletLogic DL=new WalletLogic();
        DataTable dt=new DataTable();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RequestedWallet()
        {
            dt=DL.GetRequestedWallet();
            return View(dt);
        }
        public IActionResult ApprovedWallet(string PId,double Amount,string Type,string UserId)
        {
            bool checkbal;
            string msg;
            double Tcashbalence = WalletModal.ToatalPartenCashBalance()+ Amount;
            double Tmainbalence = WalletModal.ToatalPartenMainBalance()+ Amount;
            double PaysprintCashWallet = WalletModal.PaystprintCASHWalletBalance();
            double PaysprintMainWallet = WalletModal.PaystprintMAINWalletBalance();
            switch (Type.ToLower())
            {
                case "credit":
                   checkbal= Tcashbalence <= PaysprintMainWallet ? true : false;
                    break;
                case "debit":
                    //checkbal=Tmainbalence <= PaysprintMainWallet ? true : false;
                    checkbal=Tmainbalence <= PaysprintCashWallet ? true : false;
                    break;
                default:
                    msg = "This Type is Not Permitted !!";
                    return Json(msg);
                   
            }
            if (checkbal)
            {
                dt = DL.ApprovedWallet(PId,Amount, Type, UserId);
                if (dt != null && dt.Rows.Count > 0)
                {
                    msg = dt.Rows[0]["msg"].ToString();
                }
                else
                {
                    msg = "Fail Try Again !!";
                }
            }
            else
            {
                msg = "Insufficient Funds !!";
            }
            return Json(msg);
        }
        public IActionResult RejectedWallet(string PId)
        {
            string msg;
           
                dt = DL.RejectedWallet(PId);
                if (dt != null && dt.Rows.Count > 0)
                {
                    msg = dt.Rows[0]["msg"].ToString();
                }
                else
                {
                    msg = "Fail Try Again !!";
                }
           
            return Json(msg);
        }



        public IActionResult BlanceRequest()
        {
            return View();
        }
        [HttpPost]
        public JsonResult InsertBalanceRequest(BalanceReq P)
        {
           
            P.UserID = Convert.ToString(HttpContext.Session.GetString("UserId"));
            string Message = "";
            if (P.FileName != null)
            {
                string imagesPath = "/Upload/ScreenShot/" + P.UserID + "WalletRequest" + DateTime.Now.Ticks + ".jpg";
                string DefaultImagePath1 = "wwwroot" + imagesPath;

                P.images = "http://grofinapi.sigmasoftwares.org/" + imagesPath;
            }

            dt = DL.InsertBalanceRequest(P);
            if (dt != null && dt.Rows.Count > 0)
            {
                Message = dt.Rows[0]["Msg"].ToString();
            }
            return Json(Message);
        }

        public IActionResult UserWalletHistory(string type)
        {
            string UserId = Convert.ToString(HttpContext.Session.GetString("UserId"));
            dt = DL.UserWalletHistory(UserId ,type);
            return View(dt);

        }

		[HttpPost]
		public JsonResult Transferamount(BalanceReq obj)
		{
            decimal transferamount = 0;
            decimal CreaditBlance = 0;
			//HttpContext.Session.SetString("CREDIT", Convert.ToString(WalletModal.GetPartenCreditBalanceByUser(userid)));
			string Msg = "";
			 CreaditBlance = Convert.ToDecimal(HttpContext.Session.GetString("CREDIT"));
            decimal  Bl = Convert.ToDecimal(HttpContext.Session.GetString("DEBIT"));

			obj.UserID = Convert.ToString(HttpContext.Session.GetString("UserId"));
            transferamount = obj.transferamt;
			if (Convert.ToString(HttpContext.Session.GetString("Role")) != "1")
			{
				if (transferamount >= CreaditBlance)
				{			
					Msg= "Insufficient balance !!";
					return Json(Msg);
				}
			}
			DataTable dt = DL.TransferBlance(obj);
			
			if (dt != null && dt.Rows.Count > 0)
			{
				Msg = dt.Rows[0]["Msg"].ToString();
			}
			return Json(Msg);
		}
	}
}
