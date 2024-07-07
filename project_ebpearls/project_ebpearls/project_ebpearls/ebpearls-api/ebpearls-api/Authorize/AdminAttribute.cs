
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Ctara.Infrastructure.Common.Handlers
{
    public class AdminAccessAttribute : TypeFilterAttribute
    {
        public AdminAccessAttribute() : base(typeof(AdminAccessFilter)) { }
    }

    public class AdminAccessFilter : IAsyncAuthorizationFilter
    {
        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            //check the authenticaation
        }
    }
}
