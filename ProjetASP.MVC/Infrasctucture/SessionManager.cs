using ProjetASP.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetASP.MVC.Infrasctucture
{
    public class SessionManager
    {
        public static UtilisateurDetails UtilisateurDetails

        {
            get { return (UtilisateurDetails)HttpContext.Current.Session[nameof(UtilisateurDetails)]; }
            set { HttpContext.Current.Session[nameof(UtilisateurDetails)] = value; }
        }

        public static bool IsAdmin
        {
            get { return UtilisateurDetails.Roles.Contains(RoleUser.Admin.ToString());  }
        }
       
        public static void Abandon()
        {
            HttpContext.Current.Session.Abandon();
        }
    }
}