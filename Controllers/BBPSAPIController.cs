using Grofinhub.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using SportsBattle.Models;
using System.Data;
using System;
using System.Reflection;

namespace Grofinhub.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class BBPSAPIController : Controller
    {
        CommonClasses sm;
        public BBPSAPIController()
        {
            sm = new CommonClasses();
        }
        [HttpPost]
        [Route("api/GetOperatorList")]
        public IActionResult GetOperator(BBPSReqModel model)
        {
            var options = new RestClientOptions("https://api.paysprint.in")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/api/v1/service/bill-payment/bill/getoperator", Method.Post);
            request.AddHeader("accept", "application/json");
            request.AddHeader("Token", sm.GetLiveToken());
            request.AddHeader("Content-Type", "application/json");

            string body = JsonConvert.SerializeObject(model);
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            return Ok(response.Content);
        }
        [HttpPost]
        [Route("api/FetchBill")]
        public IActionResult FetchBill(fillfecthRequest accreq)
        {
            string body = JsonConvert.SerializeObject(accreq);
            RootresponseBilldetails racc = new RootresponseBilldetails();
            var options = new RestClientOptions("https://api.paysprint.in")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/api/v1/service/bill-payment/bill/fetchbill", Method.Post);
            request.AddHeader("accept", "application/json");
            request.AddHeader("Token", sm.GetLiveToken()); 
            request.AddHeader("Content-Type", "application/json");
            //string body = JsonConvert.SerializeObject(model);
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);  
            return Ok(response.Content);

        }
        [HttpPost]
        [Route("api/PayBill")]
        public IActionResult PayBill(BBPS_Body p)
        {
            string body = JsonConvert.SerializeObject(p);
            var options = new RestClientOptions("https://api.paysprint.in")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/v1/service/bill-payment/bill/paybill", Method.Post);
                request.AddHeader("accept", "application/json"); 
                request.AddHeader("Token", sm.GetLiveToken()); 
                request.AddHeader("Content-Type", "application/json");
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request); 
                return Ok(response.Content);
             
        }

    }
}
