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

namespace Grofinhub.Controllers
{
    public class AEPSController : Controller
    {
        DBHelper DB = new DBHelper();
        CommonClasses sm = new CommonClasses();
        clsAdminLogic db;
        public AEPSController()
        {
            db = new clsAdminLogic();
            sm = new CommonClasses();
          //  DB = new DBHelper(); 
        }

        [HttpGet]
        [Route("Admin/AEPS")]
        public async Task<IActionResult> GetBankList()
        {
            try
            {
                string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
                string url = $"https://sit.paysprint.in/service-api/api/v1/service/aeps/banklist/index";

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Token", sm.GetToken());
                client.DefaultRequestHeaders.Add("Authorisedkey", DB.AuthorizationKey);
                var response = await client.PostAsync(url, null);
                string responseBody = await response.Content.ReadAsStringAsync();
                RootAEPS data = Newtonsoft.Json.JsonConvert.DeserializeObject<RootAEPS>(responseBody);
                if (data.banklist != null)
                {
                    return View("~/Views/Admin/AEPS.cshtml", data);
                }
                else
                {
                    return View("~/Views/Admin/AEPS.cshtml");
                }             
            }
            catch(Exception ex)
            {
                return View("~/Views/Admin/AEPS.cshtml");
            }
        }

        [HttpGet]
        public IActionResult Get2FAStatus()
        {
            string userId = HttpContext.Session.GetString("UserId");
            DataTable dt = db.GetAePS2FADetails(userId);

            if (dt != null && dt.Rows.Count > 0)
            {
                // Mask Aadhar number (e.g., XXXX-XXXX-1234)
                string aadharNumber = dt.Rows[0]["AadharNumber"].ToString(); // Replace with actual column name
                string maskedAadharNumber = "XXXX-XXXX-" + aadharNumber.Substring(aadharNumber.Length - 4);

                var result = new
                {
                    MerchantStatus = dt.Rows[0]["MerchantStatus"].ToString(),  // Replace with actual column name
                    AuthStatus = dt.Rows[0]["AuthStatus"].ToString(),          // Replace with actual column name
                    MobileNumber = dt.Rows[0]["MobileNumber"].ToString(),      // Replace with actual column name
                    AadharNumber = maskedAadharNumber                         // Return the masked Aadhar number
                };

                return Json(result);
            }
            else
            {
                return Json(new { error = "No data found" });
            }
        }

        public JsonResult Enquiry(AEPSEnqueriModel p)
        {
            try
            {
                if (Convert.ToString(HttpContext.Session.GetString("Role")) != "2")
                {
                    return Json("YOU ARE NOT PARMITED USER !!");
                }
                //AEPSEnqueriModel obj = new AEPSEnqueriModel() { accessmodetype = "SITE", adhaarnumber = "963214500201", data = "", ipaddress = "122.44.443.00", is_iris = "No", latitude = "22.44543", longitude = "77.434", mobilenumber = "9900000099", nationalbankidentification = 445, pipe = "bank1", referenceno = "43542343434", requestremarks = "", submerchantid = "1", timestamp = "2020-01-12 13:00:12", transactiontype = "BE" };

                string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
                p.transactiontype = "BE";
                p.submerchantid = userid;
                p.timestamp = DateTime.Now.ToString("yyyy-MM-dd");
                p.pipe = "bank1";
                p.accessmodetype = "SITE";
                p.ipaddress = sm.GetIPAddress();
                p.referenceno = sm.GetReferencenceId("", userid, "AEPSENQUIRY");
                var client = new RestClient("https://sit.paysprint.in");
                var request = new RestRequest("/service-api/api/v1/service/aeps/balanceenquiry/index", Method.Post);
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
        public JsonResult Withdraw(AEPSWithdraw p)
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
                p.referenceno = sm.GetReferencenceId(p.amount.ToString(), userid, "AEPSWITHDRAWL");
                var client = new RestClient("https://paysprint.in");
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
        public JsonResult MiniStatement(AEPSEnqueriModel p)
        {
            try
            {
                if (Convert.ToString(HttpContext.Session.GetString("Role")) != "2")
                {
                    return Json("YOU ARE NOT PARMITED USER !!");
                }
                AEPSEnqueriModel obj = new AEPSEnqueriModel() { accessmodetype = "SITE", adhaarnumber = "963214500201", data = "", ipaddress = "122.44.443.00", is_iris = "No", latitude = "22.44543", longitude = "77.434", mobilenumber = "9900000099", nationalbankidentification = 22, pipe = "bank1", referenceno = "43542343434", requestremarks = "", submerchantid = "1", timestamp = "2020-01-12 13:00:12", transactiontype = "BE" };

                string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
                p.transactiontype = "BE";
                p.submerchantid = userid;
                p.timestamp = DateTime.Now.ToString("yyyy-MM-dd");
                p.pipe = "bank1";
                p.accessmodetype = "SITE";
                obj.ipaddress = sm.GetIPAddress();
                p.referenceno = sm.GetReferencenceId("", userid, "AEPSMINISTATMENT");
                var client = new RestClient("https://paysprint.in");
                var request = new RestRequest("/service-api/api/v1/service/aeps/ministatement/index", Method.Post);
                request.AddHeader("accept", "application/json");
                string body = JsonConvert.SerializeObject(obj);
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

        public JsonResult AEPSTransactionStatus(MATMWithdrawStatusPara P)
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
                var request = new RestRequest("/service-api/api/v1/service/aeps/aepsquery/query", Method.Post);
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

        public JsonResult AdharPay(AEPSWithdraw p)
        {
            try
            {
                if (Convert.ToString(HttpContext.Session.GetString("Role")) != "2")
                {
                    return Json("YOU ARE NOT PARMITED USER !!");
                }
                //AEPSWithdraw obj = new AEPSWithdraw() {      data = "",           };

                string userid = Convert.ToString(HttpContext.Session.GetString("UserId"));
                p.transactiontype = "FM";
                p.submerchantid = userid;
                p.timestamp = DateTime.Now.ToString("yyyy-MM-dd");
                p.pipe = "bank1";
                p.accessmodetype = "SITE";
                p.ipaddress = sm.GetIPAddress();
                p.referenceno = sm.GetReferencenceId(p.amount.ToString(), userid, "AEPSWITHDRAWL");
                var client = new RestClient("https://paysprint.in");
                var request = new RestRequest("/service-api/api/v1/service/aadharpay/aadharpay/index", Method.Post);
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
