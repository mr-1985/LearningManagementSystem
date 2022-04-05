using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Lms.Core.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using AuthorizeAttribute = Microsoft.AspNetCore.Authorization.AuthorizeAttribute;
using IAuthorizationFilter = System.Web.Mvc.IAuthorizationFilter;
using RedirectResult = Microsoft.AspNetCore.Mvc.RedirectResult;

namespace Lms.Core.Security
{
    public class PermissionCheckerAttribute : FilterAttribute, IAuthorizationFilter
    {
        private IPermissionService _permissionService;
        private  IHttpContextAccessor _httpContextAccessor;
        private int _permissionId = 0;
        //public PermissionCheckerAttribute(int permissionId)
        //{
        //    _permissionId = permissionId;
        //}

        //public PermissionCheckerAttribute( int permissionId)
        //{
        //    _permissionId = permissionId;
        //}

        //public void OnAuthorization(AuthorizationContext filterContext)
        //{
        //    _permissionService =
        //        (IPermissionService)filterContext.HttpContext.RequestServices.GetService(typeof(IPermissionService));
        //    if (filterContext.HttpContext.User.Identity.IsAuthenticated)
        //    {
        //        string userName = filterContext.HttpContext.User.Identity.Name;

        //        if (!_permissionService.CheckPermission(_permissionId, userName))
        //        {
        //            filterContext.Result = new RedirectResult("/Login");
        //        }
        //    }
        //    else
        //    {
        //        filterContext.Result = new RedirectResult("/Login");
        //    }
        //}
        public void OnAuthorization(AuthorizationContext httpContextAccessor)
        {
            //_permissionService =
            //    (IPermissionService)_httpContextAccessor.HttpContext.RequestServices.GetService(typeof(IPermissionService));
            //if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            //{
            //    string userName = _httpContextAccessor.HttpContext.User.Identity.Name;

            //    if (!_permissionService.CheckPermission(_permissionId, userName))
            //    {
            //        _httpContextAccessor.HttpContext.r = new RedirectResult("/Login");
            //    }
            //}
            //else
            //{
            //    _httpContextAccessor.HttpContext.RequestServices.GetRequiredService(RedirectResult) = new RedirectResult("/Login");
            //}
        }
    }
}
