using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Diagnostics;

namespace HW_cookie_autentification.Filters
{
    public class ClientActionFilter : Attribute, IActionFilter
    {
        
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                //тут нужно выйти 
            }
            
            
        }

    }

}
