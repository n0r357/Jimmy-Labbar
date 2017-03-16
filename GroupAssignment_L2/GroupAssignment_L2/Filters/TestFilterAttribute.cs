using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_L2.Filters
{
    public class TestFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Debug.WriteLine("START");
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("END");
        }
    }
}
