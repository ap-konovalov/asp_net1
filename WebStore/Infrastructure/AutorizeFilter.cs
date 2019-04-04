using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebStore
{
    class AutorizeFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            throw new NotImplementedException();
        }
    }
}