﻿using System.Web;
using System.Web.Mvc;

namespace mvc_dropdownlist_sql
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
