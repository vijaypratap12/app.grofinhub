using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using SportsBattle.Models;
using System.Data;
using System;

namespace Grofinhub.Controllers
{
    [ApiController]
    public class PanNSDLApiController : Controller
    {
        CommonClasses sm;
        public PanNSDLApiController()
        {
            sm = new CommonClasses();
        }
        [HttpPost]
        [Route("api/pan/generateurl")]
        public IActionResult SavePamCardDetails(PanBody p)
        { 
            try
            {
                string body = JsonConvert.SerializeObject(p);
                var options = new RestClientOptions("https://api.paysprint.in")
                    {
                        MaxTimeout = -1,
                    };
                    var client = new RestClient(options);
                    var request = new RestRequest("/api/v1/service/pan/V2/generateurl", Method.Post); 
                    request.AddHeader("accept", "application/json");
                    string GetToken = sm.GetLiveToken();
                    request.AddHeader("Token", GetToken);
                    request.AddHeader("Content-Type", "application/json"); 
                    request.AddStringBody(body, DataFormat.Json);
                    RestResponse response = client.Execute(request); 
                return Ok(response.Content);
            }
            catch (Exception)
            { 
                return Ok("Something Went Wrong !!");
            }
        }
        [HttpPost]
        [Route("api/pan/panstatus")]
        public IActionResult GetCheckPanStatus(CheckPanStatusBody p)
        {
            try
            {
                string body = JsonConvert.SerializeObject(p);
                var options = new RestClientOptions("https://api.paysprint.in")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/v1/service/pan/V2/pan_status", Method.Post);
                request.AddHeader("accept", "application/json");
                string GetToken = sm.GetLiveToken();
                request.AddHeader("Token", GetToken); 
                request.AddHeader("Content-Type", "application/json"); 
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                var racc = JsonConvert.DeserializeObject(response.Content);
                string resdata = response.Content;
                return Ok(resdata);
            }
            catch
            {
                string msg = "Something went Wrong!!";
                return Ok(msg);
            }

        }
        [HttpPost]
        [Route("api/pan/txnstatus")]
        public IActionResult PanStatesEnquiry(CheckPanStatusBody p)
        { 
            try
            { 
                    var options = new RestClientOptions("https://api.paysprint.in")
                    {
                        MaxTimeout = -1,
                    };
                    var client = new RestClient(options);
                    var request = new RestRequest("/api/v1/service/pan/V2/txn_status", Method.Post);
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
                return Ok("Something Went Wrong!!");
            }
        }


    }
}
