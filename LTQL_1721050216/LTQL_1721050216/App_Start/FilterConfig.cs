﻿using System.Web;
using System.Web.Mvc;

namespace LTQL_1721050216
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
