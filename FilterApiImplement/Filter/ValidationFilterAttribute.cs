using Microsoft.AspNetCore.Mvc.Filters;

namespace FilterApiImplement.Filter
{
    public class ValidationFilterAttribute:IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new System.NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}