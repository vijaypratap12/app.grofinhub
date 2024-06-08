using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace SportsBattle.Models
{
    public class Sessioncheck : ActionFilterAttribute    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
            if (filterContext.HttpContext.Session.GetString("UserName") == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary {
                                { "Controller", "Account" },
                                { "Action", "Login" }
                                });
            }
        }
    }


}
