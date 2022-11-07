using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace ExceptionHandeling.Filters
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            ViewResult result = new ViewResult();
            result.ViewName = "/Views/Shared/ErrorMessage.cshtml";
            result.ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary());
            result.ViewData.Model = filterContext.Exception;
            filterContext.Result = result;
            filterContext.ExceptionHandled = true;
        }
    }
}
