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
    public class EPFOApiController : Controller
    {
        CommonClasses sm;
        public EPFOApiController()
        {
            sm = new CommonClasses();
        }
        [HttpPost]
        [Route("api/epfo/sendOtp")]
        public IActionResult EPFOKYC_OTPSENDAPI(EPFOAPIMODEL p)
        {
            try
            {
                string body = JsonConvert.SerializeObject(p);
                var options = new RestClientOptions("https://api.verifya2z.com")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/v1/verification/sendOtp", Method.Post);
                request.AddHeader("accept", "application/json");
                request.AddHeader("Token", sm.GetLiveVerifyToken());
                request.AddHeader("User-Agent", CommonClasses.agentid);
                request.AddHeader("Content-Type", "application/json");
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                return Ok(response.Content);
            }
            catch
            {
                return Ok("Something Went Wrong !!");
            }

        }
        [HttpPost]
        [Route("api/epfo/verifyotp")]
        public IActionResult KycDetailsGet(EPFOAPIMODELkyc p)
        {
            try
            {
                string body = JsonConvert.SerializeObject(p);
                var options = new RestClientOptions("https://api.verifya2z.com")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/v1/verification/VerifyOtp", Method.Post);
                request.AddHeader("accept", "application/json");
                request.AddHeader("Token", sm.GetLiveVerifyToken());
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("User-Agent", CommonClasses.agentid);
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                return Ok(response.Content);
            }
            catch
            {
                return Ok("Something Went Wrong !!");
            }
        }
        [HttpPost]
        [Route("api/epfo/epfokycfetch")]
        public IActionResult GetKYCDetailsByReferenceID(EPFOAPIMODELGetkycDetails p)
        {
            try
            {
                string body = JsonConvert.SerializeObject(p);
                var options = new RestClientOptions("https://api.verifya2z.com")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/v1/verification/epfo_kyc_fetch", Method.Post);
                request.AddHeader("accept", "application/json");
                request.AddHeader("Token", sm.GetLiveVerifyToken()); 
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("User-Agent", CommonClasses.agentid);
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                return Ok(response.Content);
            }
            catch
            {
                return Ok("Something Went Wrong !!");
            }
        }

        [HttpPost]
        [Route("api/epfo/passbookdownload")]
        public IActionResult EpfoKYCDownloadPassword(EPFOAPIMODELGetkycDetails p)
        {
            try
            {
                var body = JsonConvert.SerializeObject(p);
                var options = new RestClientOptions("https://api.verifya2z.com")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/v1/verification/epfo_passbook_download", Method.Post);
                request.AddHeader("accept", "application/json");
                request.AddHeader("Token", sm.GetLiveVerifyToken()); 
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("User-Agent", CommonClasses.agentid);
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                return Ok(response.Content);
            }
            catch
            {
                return Ok("Something Went Wrong !!");
            }
        }

    }
}
