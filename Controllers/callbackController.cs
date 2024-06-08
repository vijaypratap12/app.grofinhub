using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Nancy.Json;
using SportsBattle.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Grofinhub.Controllers
{
   // [ApiExplorerSettings(GroupName ="34")]
    [Route("api/Services/api/callback")]
    [ApiController]
    public class callbackController : ControllerBase
    {
        // GET: api/<callbackController>
        [HttpGet]
        public IActionResult Get([FromForm]OnboardRequesBody objP)
        {
            return Ok(new { status = 200, message = "Transaction completed successfully" });
        }

        // GET api/<callbackController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<callbackController>
        [HttpPost]
        public IActionResult Post([FromForm]OnboardRequesBody objP)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            string json = js.Serialize(Ok(new { status = 200, message = "Transaction completed successfully" }));
            return Ok(new { status = 200, message = "Transaction completed successfully" });
        }

        // PUT api/<callbackController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<callbackController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
