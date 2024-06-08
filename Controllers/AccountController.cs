using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using SportsBattle.Models;
using System.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using System.Net;
using Microsoft.AspNetCore.Http;
using Grofinhub.Models;
using Nancy.Session;

namespace SportsBattle.Controllers
{

    public class AccountController : Controller
    {
        clsAdminLogic db;
        private readonly IHostingEnvironment _hostingEnvironment;
        static string base64String = null;
        public AccountController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            db = new clsAdminLogic();
        }
        public IActionResult Login()
        {
             
            //return Redirect("http://b2b.grofinhub.com/login");
            return View();
        }
        

        [HttpPost]
        public IActionResult Login(string userName, string password)
        {
            bool isAuthenticated = false;
            if (!string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password))
            {
                //return RedirectToAction("Login");
                return Redirect("http://b2b.grofinhub.com/login");
            }
            string IpAddress = "", BrowserName = "", OSName = "";
            string hostName = Dns.GetHostName();
            Console.WriteLine(hostName);

            IpAddress = Dns.GetHostByName(hostName).AddressList[0].ToString();
            BrowserName = HttpContext.Request.Headers["User-Agent"];

            DataTable dt = db.GetAdminDetails(userName, password, IpAddress, BrowserName, OSName);
            ClaimsIdentity identity = null;
            if (dt.Rows[0]["status"].ToString() == "1")
            {
                HttpContext.Session.SetString("UserName", Convert.ToString(userName));
                HttpContext.Session.SetString("UserId", Convert.ToString(dt.Rows[0]["UserId"]));
                HttpContext.Session.SetString("Name", Convert.ToString(dt.Rows[0]["Name"]));
                HttpContext.Session.SetString("Role", Convert.ToString(dt.Rows[0]["Role"]));
				
				if (Convert.ToString(dt.Rows[0]["Role"]) == "1")
                {
                    HttpContext.Session.SetString("CREDIT", Convert.ToString(WalletModal.PaystprintMAINWalletBalance()));
                    HttpContext.Session.SetString("DEBIT", Convert.ToString(WalletModal.PaystprintCASHWalletBalance()));
                }
                else
                {
                    string userid = Convert.ToString(dt.Rows[0]["UserId"]);
                    HttpContext.Session.SetString("CREDIT", Convert.ToString(WalletModal.GetPartenCreditBalanceByUser(userid)));
                    HttpContext.Session.SetString("DEBIT", Convert.ToString(WalletModal.GetPartenDebitBalanceByUser(userid)));

                }
                //Create the identity for the user  
                identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, userName),
                    new Claim(ClaimTypes.Role, "Admin")
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                isAuthenticated = true;
            }
            else
            {
                TempData["flag"] = dt.Rows[0]["status"].ToString();
                TempData["msg"] = dt.Rows[0]["msg"].ToString();
            }
            if (isAuthenticated)
            {
                var principal = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                if (Convert.ToString(dt.Rows[0]["Role"]) == "1")
                    return RedirectToAction("MainDashboard", "Admin");
                else if (Convert.ToString(dt.Rows[0]["Role"]) == "2")
                    return RedirectToAction("Dashboard", "Admin");
                else if (Convert.ToString(dt.Rows[0]["Role"]) == "3")
                    return RedirectToAction("Dashboard", "Manager");
                else if (Convert.ToString(dt.Rows[0]["Role"]) == "4")
                    return RedirectToAction("OtherServic", "Admin");
            }
            return Redirect("http://b2b.grofinhub.com/login");
            //return View();
        }
		public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Clear();
            return Redirect("http://b2b.grofinhub.com/login");

           // return RedirectToAction("Login");
        }
    }
}
