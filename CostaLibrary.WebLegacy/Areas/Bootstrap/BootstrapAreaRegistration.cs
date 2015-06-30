﻿using System.Web.Mvc;

namespace CostaLibrary.WebLegacy.Areas.Bootstrap
{
    public class BootstrapAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Bootstrap";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Bootstrap_default",
                "Bootstrap/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}