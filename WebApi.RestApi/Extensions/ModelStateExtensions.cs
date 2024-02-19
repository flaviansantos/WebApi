using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebApi.RestApi.Extensions
{
    public static class ModelStateExtensions
    {
        public static List<string> GetErrorsMessages(this ModelStateDictionary modelState)
        {
            return modelState
                    .SelectMany(ms => ms.Value.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();
        }
    }
}
