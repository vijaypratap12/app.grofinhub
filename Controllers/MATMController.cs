using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using Newtonsoft.Json;
using RestSharp;
using SportsBattle.Models;
using System;
using System.Data;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using Nancy;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Grofinhub.Controllers
{
    public class MATMController : Controller
    {
        DBHelper DB = new DBHelper();
        CommonClasses sm = new CommonClasses();
        clsAdminLogic db;
        public MATMController()
        {
            db = new clsAdminLogic();
            sm = new CommonClasses();
          //  DB = new DBHelper(); 
        }

        [HttpGet]
        [Route("Admin/MATM")]
        public IActionResult Index()
        {
            return View("~/Views/Admin/MATM.cshtml");
        }


        public JsonResult BalanceEnquiry(AEPSEnqueriModel p)
        {
            try
            {
                if (Convert.ToString(HttpContext.Session.GetString("Role")) != "2")
                {
                    return Json("YOU ARE NOT PARMITED USER !!");
                }
                //AEPSEnqueriModel obj = new AEPSEnqueriModel() { accessmodetype = "SITE", adhaarnumber = "963214500201", data = "", ipaddress = "122.44.443.00", is_iris = "No", latitude = "22.44543", longitude = "77.434", mobilenumber = "9900000099", nationalbankidentification = 445, pipe = "bank1", referenceno = "43542343434", requestremarks = "", submerchantid = "1", timestamp = "2020-01-12 13:00:12", transactiontype = "BE" };

                string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));

                p.referenceno = sm.GetReferencenceId("", userid, "MATMBALANCEENQUIRY");
                var client = new RestClient("https://sit.paysprint.in");
                var request = new RestRequest("/service-api/api/v1/service/matm/matmquery/query", Method.Post);
                request.AddHeader("accept", "application/json");
                string body = JsonConvert.SerializeObject(p);
                body = CommonClasses.CryptAESIn(body, CommonClasses.crypt_key, CommonClasses.IV);
                RootAEPSinpt data = new RootAEPSinpt() { body = body };
                body = JsonConvert.SerializeObject(data);
                request.AddHeader("Token", sm.GetToken());
                request.AddHeader("Authorisedkey", DB.AuthorizationKey);
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                RestResponse response = client.Execute(request);
                return Json(response.Content);
            }
            catch
            {
                return Json("Something Went Wrong !!");
            }
        }
        public JsonResult CashWithdraw(AEPSWithdraw p)
        {
            try
            {
                if (Convert.ToString(HttpContext.Session.GetString("Role")) != "2")
                {
                    return Json("YOU ARE NOT PARMITED USER !!");
                }
                //AEPSWithdraw obj = new AEPSWithdraw() { accessmodetype = "SITE", adhaarnumber = "963214500201", data = "", ipaddress = "122.44.443.00", is_iris = "No", latitude = "22.44543", longitude = "77.434", mobilenumber = "9900000099", nationalbankidentification = 22, pipe = "bank1", referenceno = "43542343434", requestremarks = "", submerchantid = "1", timestamp = "2020-01-12 13:00:12", transactiontype = "BE", amount = 100 };

                string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
                p.transactiontype = "BE";
                p.submerchantid = userid;
                p.timestamp = DateTime.Now.ToString("yyyy-MM-dd");
                p.pipe = "bank1";
                p.accessmodetype = "SITE";
                p.ipaddress = sm.GetIPAddress();
                p.referenceno = sm.GetReferencenceId(p.amount.ToString(), userid, "MATMCASHWITHDRAWL");
                var client = new RestClient("https://sit.paysprint.in");
                var request = new RestRequest("/service-api/api/v1/service/aeps/cashwithdraw/index", Method.Post);
                request.AddHeader("accept", "application/json");
                string body = JsonConvert.SerializeObject(p);
                body = CommonClasses.CryptAESIn(body, CommonClasses.crypt_key, CommonClasses.IV);
                RootAEPSinpt data = new RootAEPSinpt() { body = body };
                body = JsonConvert.SerializeObject(data);
                request.AddHeader("Token", sm.GetToken());
                request.AddHeader("Authorisedkey", DB.AuthorizationKey);
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                RestResponse response = client.Execute(request);
                AEPSWithdrowlRes resdata = new JavaScriptSerializer().Deserialize<AEPSWithdrowlRes>(response.Content);
                DataTable dt = db.AEPSWithdrow(resdata,p);
                AEPSTreeWay treeWay = new AEPSTreeWay() { reference = p.referenceno };
                if (resdata.status == true && resdata.response_code == 1)
                {
                    treeWay.status = "success";
                }
                else
                {
                    treeWay.status = "failed";
                }
                sm.WithdrawThreeway(treeWay);
                return Json(response.Content);
            }
            catch
            {
                return Json("Something Went Wrong !!");
            }
        }
        public JsonResult AEPSAdharPayTansactionStatus(MATMWithdrawStatusPara P)
        {
            try
            {
                P.reference = "fdtg435445r23fedvs";
                if (Convert.ToString(HttpContext.Session.GetString("Role")) != "2")
                {
                    return Json("YOU ARE NOT PARMITED USER !!");
                }
                string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
                var client = new RestClient("https://paysprint.in");
                var request = new RestRequest("/service-api/api/v1/service/aadharpay/aadharpayquery/query", Method.Post);
                request.AddHeader("accept", "application/json");
                string body = JsonConvert.SerializeObject(P);
                body = CommonClasses.CryptAESIn(body, CommonClasses.crypt_key, CommonClasses.IV);
                RootAEPSinpt data = new RootAEPSinpt() { body = body };
                body = JsonConvert.SerializeObject(data);
                request.AddHeader("Token", sm.GetToken());
                request.AddHeader("Authorisedkey", DB.AuthorizationKey);
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                RestResponse response = client.Execute(request);
                return Json(response.Content);
            }
            catch
            {
                return Json("Something Went Wrong !!");
            }

        }

    }
}
