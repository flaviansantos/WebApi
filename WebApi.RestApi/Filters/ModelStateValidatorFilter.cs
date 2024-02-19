using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using WebApi.RestApi.ViewModel;
using WebApi.RestApi.Extensions;

namespace WebApi.RestApi.Filters
{
    public class ModelStateValidatorFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = new ErrosViewModel(context.ModelState.GetErrorsMessages());

                context.Result = new BadRequestObjectResult(errors);
            }
        }
    }
}
