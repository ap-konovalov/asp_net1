using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebStore
{
    class ResulFilter: IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            throw new NotImplementedException();
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            throw new NotImplementedException();
        }
    }
}