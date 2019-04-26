using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sd210A1FilterHelper.Models.Filter
{
    public class BotActionFilter : ActionFilterAttribute
    {
        

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            bool isBot =filterContext.HttpContext
                   .Request.UserAgent
                   == "Googlebot/2.1 (+http://www.google.com/bot.html)";
            if (isBot)
            {
                filterContext.Result=
                    new ViewResult()
                    {
                        ViewName = "ByeBot"
                    };
            }
        }
    }
}