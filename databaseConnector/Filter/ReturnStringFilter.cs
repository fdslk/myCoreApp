using System;
using databaseConnector.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace databaseConnector.filter{
    public class processableResultFilter : Attribute, IAlwaysRunResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
            //throw new NotImplementedException();
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            //TODO: check object result or not 
            var result = context.Result as ObjectResult;
            var returnString = new returnString{
                Success = true,
                Data = result.Value.ToString(),
                Code = 10000
            };
            result.Value = returnString;
            // context.Result; = new ObjectResult("Can't process this!")
            // {
            //     StatusCode = 422,
            // };
            //throw new NotImplementedException();
        }
    }
}