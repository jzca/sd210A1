using sd210A1FilterHelper.Models.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sd210A1FilterHelper.Models.Filter
{
    public class LogActionFilter : ActionFilterAttribute
    {
        Stopwatch StopWatch = new Stopwatch();

        //After action executes
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            StopWatch.Stop();

            var context = new ApplicationDbContext();


            var log = new ActionLog()
            {
                ActionName = filterContext
                    .ActionDescriptor
                    .ActionName,
                ControllerName = filterContext
                    .ActionDescriptor
                    .ControllerDescriptor
                    .ControllerName,
                ExecutionTime = StopWatch.ElapsedMilliseconds

            };

            context.ActionLogs.Add(log);
            context.SaveChanges();
        }

        //Before action executes
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            StopWatch.Start();
        }

    }
}