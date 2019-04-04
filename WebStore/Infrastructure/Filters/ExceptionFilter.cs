using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebStore
{
    class ExceptionFilter: IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            throw new NotImplementedException();
        }
    }
}