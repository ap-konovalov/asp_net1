using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebStore
{
    class ActionFilter: IActionFilter 
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }
    }
}