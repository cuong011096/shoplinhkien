﻿using System.Web.Mvc;

namespace WebLinhkien.Areas.admin
{
    public class adminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "admin_default",
                "admin/{controller}/{action}/{id}",
                new { action = "Index", controller="Home" , id = UrlParameter.Optional },
                new[] { "WebLinhkien.Areas.admin.Controllers" }
            );
        }
    }
}