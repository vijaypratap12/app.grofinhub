using Microsoft.AspNetCore.Mvc;
using SportsBattle.Models;
using Newtonsoft.Json;
using RestSharp;
namespace Grofinhub.Controllers
{
    // [Route("api/[controller]")]
    [ApiController]
    //[ApiExplorerSettings(GroupName = "DMT")]
    public class DMTAPIController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        CommonClasses sm;
        public DMTAPIController( )
        {
            sm = new CommonClasses();
        }
        #region DMT
        [HttpPost]
        [Route("api/FetchRemitter")]
        // [ApiExplorerSettings(GroupName ="DMT")]
        public IActionResult FetchRemitter(QueryParametercls p)
        {
            try
            {
                string body = JsonConvert.SerializeObject(p);
                var options = new RestClientOptions("https://api.paysprint.in")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/v1/service/dmt/remitter/queryremitter", Method.Post);
                request.AddHeader("accept", "application/json");
                request.AddHeader("Token", sm.GetLiveToken());
                request.AddHeader("Content-Type", "application/json");
                // string body = JsonConvert.SerializeObject(accreq);
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
        [Route("api/FetchBenefeciary")] 
        public IActionResult FetchBenefeciary(BeneficiaryParaMld p)
        {
            try { 
            var options = new RestClientOptions("https://api.paysprint.in")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/api/v1/service/dmt/beneficiary/registerbeneficiary/fetchbeneficiary", Method.Post);
            request.AddHeader("accept", "application/json");
            request.AddHeader("Token", sm.GetLiveToken());
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
        [Route("api/RegisterBeneficiary")] 
        public IActionResult RegisterBeneficiary(RootBeneficiaryRegister p)
        {
            try
            {
                var options = new RestClientOptions("https://api.paysprint.in")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/v1/service/dmt/beneficiary/registerbeneficiary", Method.Post);

                request.AddHeader("accept", "application/json");
                request.AddHeader("Token", sm.GetLiveToken());
                request.AddHeader("Content-Type", "application/json");
                // p.dob = Convert.ToDateTime(p.dob).ToString("yyyy-MM-dd");
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
        [Route("api/RegisterRemitter")] 
        public IActionResult RegisterRemitter(RegisterRemiterApicls p)
        {
            try { 
            var options = new RestClientOptions("https://api.paysprint.in")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/api/v1/service/dmt/remitter/registerremitter", Method.Post);
            request.AddHeader("accept", "application/json");
            request.AddHeader("Token", sm.GetLiveToken());
            request.AddHeader("Content-Type", "application/json");
            // p.dob = Convert.ToDateTime(p.dob).ToString("yyyy-MM-dd"); 
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
        [Route("api/PennyDrop")] 
        public IActionResult PennyDropVerificationy(PennyDropRequest p)
        {
            try { 
            var options = new RestClientOptions("https://api.paysprint.in")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/api/v1/service/dmt/beneficiary/registerbeneficiary/benenameverify", Method.Post);
            request.AddHeader("accept", "application/json");
            request.AddHeader("Token", sm.GetLiveToken());
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
        [Route("api/DMTTransaction")] 
        public IActionResult DMTTransaction(TansactionBody p)
        {
            try
            {
            var options = new RestClientOptions("https://api.paysprint.in")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/api/v1/service/dmt/transact/transact", Method.Post);
            request.AddHeader("accept", "application/json");
            request.AddHeader("Token", sm.GetLiveToken());
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
        [Route("api/DMTTransactionStatus")] 
        public IActionResult DMTTransactionStatus(Transactionstatus p)
        {
            try { 
            var options = new RestClientOptions("https://api.paysprint.in")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/api/v1/service/dmt/transact/transact/querytransact", Method.Post);
            request.AddHeader("accept", "application/json");
            request.AddHeader("Token", sm.GetLiveToken());
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
        [Route("api/DMTResendotp")] 
        public IActionResult Resendotp(RefundOpt p)
        {
            try
            {
                var options = new RestClientOptions("https://api.paysprint.in")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/v1/service/dmt/refund/refund/resendotp", Method.Post);
                request.AddHeader("accept", "application/json");
                request.AddHeader("Token", sm.GetLiveToken());
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
        [Route("api/DMTRefund")] 
        public IActionResult Refund(Claim_refund p)
        {
            try { 
            var options = new RestClientOptions("https://api.paysprint.in")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/api/v1/service/dmt/refund/refund/", Method.Post);
            request.AddHeader("accept", "application/json");
            request.AddHeader("Token", sm.GetLiveToken());
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
        [Route("api/fetchbenefeciarybyid")]
        public IActionResult GetBeneficiaryDetailById(RootBeneficiaryMdlById p)
        {
            try
            {
                var options = new RestClientOptions("https://api.paysprint.in")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/v1/service/dmt/beneficiary/registerbeneficiary/fetchbeneficiarybybeneid", Method.Post);
                request.AddHeader("accept", "application/json");
                request.AddHeader("Token", sm.GetLiveToken());
                request.AddHeader("Content-Type", "application/json");
                string body = JsonConvert.SerializeObject(p);
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                string data = response.Content;
                return Ok(data);  
                }
            catch
            {
                return Ok(new { status = false, message = "Something Went Wrong !!" });
            }
             
        }
        [HttpPost]
        [Route("api/deletebenefeciary")]
        public IActionResult BenefiDel(BeneficiaryDelete p)
        {
            try
            {
                var options = new RestClientOptions("https://api.paysprint.in")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/api/v1/service/dmt/beneficiary/registerbeneficiary/deletebeneficiary", Method.Post);
                request.AddHeader("accept", "application/json");
                request.AddHeader("Token", sm.GetLiveToken());
                request.AddHeader("Content-Type", "application/json");
                string body = JsonConvert.SerializeObject(p);
                request.AddStringBody(body, DataFormat.Json);
                RestResponse response = client.Execute(request);
                string data = response.Content;
                return Ok(data);
            }
            catch
            {
                return Ok(new { status = false, message = "Something Went Wrong !!" });
            }
        }


        #endregion


    }
}
