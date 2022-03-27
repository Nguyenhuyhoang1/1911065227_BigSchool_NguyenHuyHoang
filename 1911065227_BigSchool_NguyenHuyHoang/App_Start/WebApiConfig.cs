﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace _1911065227_BigSchool_NguyenHuyHoang
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
