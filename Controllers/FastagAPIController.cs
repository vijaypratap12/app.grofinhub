using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using SportsBattle.Models;
using System.Data;
using System;
using Grofinhub.Models;
using Nancy.Json;
using System.Text.Json.Serialization;

namespace Grofinhub.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class FastagAPIController : Controller
    {
        CommonClasses sm;
        public FastagAPIController()
        {
            sm = new CommonClasses();
        }
        [HttpPost]
        [Route("api/fastag/operatorsList")]
        public IActionResult FASTAG()
        {
            try
            {
                var options = new RestClientOptions("https://api.paysprint.in")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/v1/service/fastag/Fastag/operatorsList", Method.Post);
                request.AddHeader("accept", "application/json"); 
                string GetToken = sm.GetLiveToken();
                request.AddHeader("Token", GetToken);
                request.AddHeader("Content-Type", "application/json");
                RestResponse response = client.Execute(request);
                return Ok(response.Content);
            }
            catch
            {
                return Ok(new { status = false, msg = "Something Went Wrong !!" });
            }

        }

        [HttpPost]
        [Route("api/fastag/recharge")]
        public IActionResult FastTagRecharge(FastTagRechargeRequest p)
        { 
            try
            {
                string body = JsonConvert.SerializeObject(p);
                var options = new RestClientOptions("https://api.paysprint.in")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/v1/service/fastag/Fastag/recharge", Method.Post);
                request.AddHeader("accept", "application/json");
                request.AddHeader("Token", sm.GetLiveToken()); 
                request.AddHeader("Content-Type", "application/json"); 
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                  return Ok(response.Content);
            }
            catch
            { 
                return Ok(new { status=false,msg="Something Went Wrong !!" });
            }

        }
        [HttpPost]
        [Route("api/fastag/status")]
        public IActionResult FastagStatus(StatusBBPSEnquiryRequest p)
        {
            try
            {
                var options = new RestClientOptions("https://api.paysprint.in")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/v1/service/fastag/Fastag/status", Method.Post); 
                request.AddHeader("accept", "application/json"); 
                string GetToken = sm.GetLiveToken();
                request.AddHeader("Token", GetToken); 
                request.AddHeader("Content-Type", "application/json");
                //string body = JsonConvert.SerializeObject(req);
                string body = JsonConvert.SerializeObject(p);
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request); 
                return Ok(response.Content);
            }
            catch
            {
                return Ok(new { status = false, msg = "Something Went Wrong !!" });
            }

        }

        [HttpPost]
        [Route("api/fastag/fetchConsumerDetails")]
        public IActionResult FetchConsumerDetails(FetchConsumerRequestApi p)
        {
            string body = JsonConvert.SerializeObject(p);
            var options = new RestClientOptions("https://api.paysprint.in")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/api/v1/service/fastag/Fastag/fetchConsumerDetails", Method.Post);
            request.AddHeader("accept", "application/json");
            request.AddHeader("Token", sm.GetLiveToken()); 
            request.AddHeader("Content-Type", "application/json");

           // string body = JsonConvert.SerializeObject(obj);
            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            return Ok(response.Content.ToString());
        }
        [HttpPost]
        [Route("api/fastag/savefastagrechargedetails")]
        public IActionResult FastTagRecharge(fastagapi1 obj)
        {
            try
            { 
                DataTable dt = new clsAdminLogic().FastTagRecharge(obj);
                if (dt != null && dt.Rows.Count>0) {
                    string msg = dt.Rows[0]["msg"].ToString();
                    return Ok(new { status = true, message = msg });
                }
                else
                {
                    return Ok(new { status = true, message = "Data Not Save !!" });
                } 
            }
            catch
            {
                return Ok(new { status = false, message = "Fail" });
            }
        }

    }
}
