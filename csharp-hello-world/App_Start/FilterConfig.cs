﻿using System.Web;
using System.Web.Mvc;

namespace csharp_hello_world
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
