using Microsoft.AspNetCore.Mvc.Filters;

namespace FilterApiImplement.Filter
{
    public class MyActionFilterAttribute2 : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("atest", "fzq-test");
            base.OnResultExecuting(context);
        }
    }
}