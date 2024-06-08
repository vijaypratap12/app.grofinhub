using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using SportsBattle.Models;
using System.Data;
using System;
using Grofinhub.Models;

namespace Grofinhub.Controllers
{
    [ApiController]
    public class RechargeApiController : Controller
    {
        CommonClasses sm;
        public RechargeApiController()
        {
            sm = new CommonClasses();
        }
        [HttpPost]
        [Route("api/recharge/getoperator")]
        public IActionResult GetOperator()
        {
            try
            {
                var options = new RestClientOptions("https://api.paysprint.in")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/v1/service/recharge/recharge/getoperator", Method.Post);
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
        [Route("api/recharge/browsplan")]
        public IActionResult BrowsPlan(RootDTHBrowsPlanPara p)
        {
            try
            {
                var options = new RestClientOptions("https://api.paysprint.in")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/v1/service/recharge/hlrapi/browseplan", Method.Post);
                request.AddHeader("accept", "application/json");
                string GetToken = sm.GetLiveToken();
                request.AddHeader("Token", GetToken);
                request.AddHeader("Content-Type", "application/json");
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
        [Route("api/recharge/dthinfo")]
        public IActionResult DTHInFo(Rootdthinfobodyapi p)
        { 
            try
            {

                string body = JsonConvert.SerializeObject(p);
                Responsemsgcls res = new Responsemsgcls();
                var options = new RestClientOptions("https://api.paysprint.in")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/v1/service/recharge/hlrapi/dthinfo", Method.Post);
                request.AddHeader("accept", "application/json");
                string GetToken = sm.GetLiveToken();
                request.AddHeader("Token", GetToken);
                request.AddHeader("Content-Type", "application/json"); 
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                string resdata = response.Content;
                return Ok(resdata);

            }
            catch (Exception)
            {
                return Ok( new{status=false,msg = "Something Went Wrong !!" });

               
            }
           
        }

        [HttpPost]
        [Route("api/recharge/hlrcheck")]
        public IActionResult CheckHLR(CheckHLRRequestBody p)
        { 
            try
            { 
                string body = JsonConvert.SerializeObject(p);
                var option = new RestClientOptions("https://api.paysprint.in")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(option);
                var request = new RestRequest("/api/v1/service/recharge/hlrapi/hlrcheck", Method.Post);
                request.AddHeader("accept", "application/json");
                string token = sm.GetLiveToken();
                request.AddHeader("Token", token);
                request.AddHeader("Content-Type", "application/json");
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                string resbody = response.Content;
                return Ok(resbody);
            }
            catch
            {
                return Ok(new { status=false,msg= "Something Went Wrong !!" }); 
            }
            
        }

        [HttpPost]
        [Route("api/recharge/dorecharge")]
        public IActionResult DoMobileRecharge(RootDoRecharge p)
        {
            try
            {
                string body = JsonConvert.SerializeObject(p);
                var options = new RestClientOptions("https://api.paysprint.in")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/v1/service/recharge/recharge/dorecharge", Method.Post);
                request.AddHeader("accept", "application/json");
                string GetToken = sm.GetLiveToken();
                request.AddHeader("Token", GetToken);
                request.AddHeader("Content-Type", "application/json");
                //string body = JsonConvert.SerializeObject(accreq);
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                return Ok(response.Content);
            }
            catch (Exception)
            {
                return Ok(new { status = false, msg = "Something Went Wrong !!" });
            }
        }


        [HttpPost]
        [Route("api/recharge/recharge/status")]
        public IActionResult RechargeStatusEnquery(Transactionstatus p)
        { 
            try
            { 
                    var options = new RestClientOptions("https://api.paysprint.in")
                    {
                        MaxTimeout = -1,
                    };
                    var client = new RestClient(options);
                    var request = new RestRequest("/api/v1/service/recharge/recharge/status", Method.Post);
                    request.AddHeader("accept", "application/json");
                    string GetToken = sm.GetLiveToken();
                    request.AddHeader("Token", GetToken);
                    request.AddHeader("Content-Type", "application/json");
                    string body = JsonConvert.SerializeObject(p);
                    request.AddStringBody(body, DataFormat.Json);
                    var response = client.Execute(request);
                    string retu = response.Content.ToString();
                    return Ok(retu);
            }
            catch (Exception)
            {
                return Ok(new { status = false, msg = "Something Went Wrong !!" });
            }
        }


    }
}
