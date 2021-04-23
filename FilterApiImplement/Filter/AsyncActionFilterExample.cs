using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FilterApiImplement.Filter
{
    public class AsyncActionFilterExample : IAsyncActionFilter, IActionFilter
    {
        public Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine("async" + context.Controller.ToString());
            return next.Invoke();
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("sync" + context.Controller.ToString());
        }
    }
}