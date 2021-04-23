using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FilterApiImplement.Filter
{
    public class ActionFilterExample : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("ActionFilterExample");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}