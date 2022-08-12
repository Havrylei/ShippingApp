using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ShippingApi.Infrastructure.Attributes
{
    public class ExceptionFilterAttribute : Microsoft.AspNetCore.Mvc.Filters.ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var errorList = new List<string>();

            if (context.Exception is AggregateException exceptions)
            {
                foreach (var ex in exceptions.InnerExceptions)
                {
                    errorList.Add(ex.Message);
                }
            }
            else
            {
                errorList.Add(context.Exception.Message);
            }

            context.Result = new BadRequestObjectResult(new { ErrorMessages = errorList });
        }
    }
}
