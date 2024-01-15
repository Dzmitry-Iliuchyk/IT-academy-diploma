using Microsoft.AspNetCore.Mvc.Filters;

namespace HW_cookie_autentification.Filters
{
    public class UserActionFilter : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                
            }
        }
    }
}
