using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebStore
{
    class ActionFilter : IActionFilter
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

    class ActionFilterAsync : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
//            обработка context  перед началом дальнейших действий

            await context.HttpContext.Response.WriteAsync("Действие отменено");

//            var next_task = next();

//             Набор действий выполняемых параллельно обработке запроса

//            await next_task;

//            Обработка результата

//            throw new OperationCanceledException();
        }
    }
}