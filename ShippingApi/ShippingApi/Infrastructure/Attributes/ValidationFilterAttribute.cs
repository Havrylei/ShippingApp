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
                var errorMessages = context.ModelState.Values.SelectMany(x => x.Errors.Select(y => y.ErrorMessage));

                context.Result = new BadRequestObjectResult(new { errorMessages });
            }
        }
    }
}
