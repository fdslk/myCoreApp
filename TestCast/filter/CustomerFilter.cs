using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TestCast
{
    public class CustomResourceFilter : Attribute, IResourceFilter
    {
        private readonly string _toggle;
        private readonly string[] _featureToggle;
        public CustomResourceFilter(string toggle, params string[] featureToggle)
        {
            _toggle = toggle;
            _featureToggle = featureToggle;
        }
        public void OnResourceExecuted(ResourceExecutedContext context)
        {

        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            if (_toggle.Equals(_featureToggle[0].ToString()))
            {
                if (context.HttpContext.Request.ContentLength == 0)
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}