using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Lms.Core.Security
{
    public class TestAttribute : AuthorizeAttribute
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TestAttribute(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        //protected override bool AuthorizeCore(HttpContextAccessor httpContext)
        //{
        //    var context = _accessor.HttpContext;

        //    HttpContextAccessor. HttpCookie cookie = httpContext.Request.Cookies.Get("cookieName");
        //    if (Int32.TryParse(cookie.Value) == 5)
        //    {
        //        httpContext.Response.StatusCode = 401;
        //        httpContext.Response.End();
        //        return false;
        //    }
        //    else
        //        return true;
        //}

        //protected override bool AuthorizeCore()
        //{
        //    _httpContextAccessor.HttpContext cookie = _httpContextAccessor.HttpContext.RequestServices.c.Get("cookieName");
        //    if (Int32.TryParse(cookie.Value) == 5)
        //    {
        //        _httpContextAccessor.HttpContext.Response.StatusCode = 401;
        //        _httpContextAccessor.HttpContext.RequestServices.GetServices();
        //        return false;
        //    }
        //    else
        //        return true;
        //}
    }
}
