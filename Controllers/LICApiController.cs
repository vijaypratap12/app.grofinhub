using Grofinhub.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using SportsBattle.Models;
using System.Data;
using System;

namespace Grofinhub.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class LICApiController : Controller
    {
        CommonClasses sm;
        public LICApiController()
        {
            sm = new CommonClasses();
        }
        [HttpPost]
        [Route("api/lic/fetchlicbill")]
        public IActionResult FetchLicBillDetails(BillReq p)
        {
            string body = JsonConvert.SerializeObject(p);
            var options = new RestClientOptions("https://api.paysprint.in")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/api/v1/service/bill-payment/bill/fetchlicbill", Method.Post); 
            request.AddHeader("accept", "application/json"); 
            request.AddHeader("Token", sm.GetLiveToken());
            request.AddHeader("Content-Type", "application/json");
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            return Ok(response.Content);
        }

        [HttpPost]
        [Route("api/lic/paylicbill")]
        public IActionResult SaveLicBillPayDetails(RootBodyLic p)
        {  
            try
            {   
                string body = JsonConvert.SerializeObject(p);
                    var options = new RestClientOptions("https://api.paysprint.in")
                    {
                        MaxTimeout = -1,
                    };
                    var client = new RestClient(options);
                    var request = new RestRequest("/api/v1/service/bill-payment/bill/paylicbill", Method.Post);
                    request.AddHeader("accept", "application/json");
                    request.AddHeader("Token", sm.GetLiveToken()); 
                    request.AddHeader("Content-Type", "application/json"); 
                    request.AddStringBody(body, DataFormat.Json);
                    RestResponse response = client.Execute(request); 
                    return Ok(response.Content);
            }
            catch (Exception)
            { 
                return Json("Something Went Wrong !!");
            }
        }
        [HttpPost]
        [Route("api/lic/licstatus")]
        public IActionResult LICStatesEnquiry(Transactionstatus p)
        { 
            try
            { 
                string body = JsonConvert.SerializeObject(p);
                    var options = new RestClientOptions("https://api.paysprint.in")
                    {
                        MaxTimeout = -1,
                    };
                    var client = new RestClient(options);
                    var request = new RestRequest("/api/v1/service/bill-payment/bill/licstatus", Method.Post);
                    request.AddHeader("accept", "application/json"); 
                    string GetToken = sm.GetLiveToken();
                    request.AddHeader("Token", GetToken); 
                    request.AddHeader("Content-Type", "application/json"); 
                    request.AddStringBody(body, DataFormat.Json);
                    var response = client.Execute(request);
                    string retu = response.Content.ToString(); 
                    return Ok(retu); 
            }
            catch  
            {
                return Ok("Something Went Wrong!!");
            }
        }


    }
}
