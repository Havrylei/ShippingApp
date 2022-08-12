using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ShippingApi.Infrastructure.Attributes
{
    public class ValidationFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errorMessage = context.ModelState.Values.First().Errors.First().ErrorMessage;

                context.Result = new BadRequestObjectResult(new { errorMessage });
            }
        }
    }
}
