
using ProjetASP.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjetASP.MVC.Infrasctucture.Attributes
{
    public class AuthorizeManagerAttribute : AuthorizeAttribute
    {
        private RoleUser? RoleAccess { get; }

        public AuthorizeManagerAttribute()
        {
            RoleAccess = null;
        }
        public AuthorizeManagerAttribute(RoleUser roleAccess)
        {
            RoleAccess = roleAccess;
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (SessionManager.UtilisateurDetails == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary()
                    {
                        { "action", "Login" },
                        { "controller", "Auth"}
                    }
                );
            }
            //else if (RoleAccess != null ? (bool)RoleAccess?.HasFlag(SessionManager.User.Role) : false)
            else if (!(RoleAccess?.HasFlag(SessionManager.UtilisateurDetails.Role) ?? true))
            {
                filterContext.Result = new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }
        }
    }
}