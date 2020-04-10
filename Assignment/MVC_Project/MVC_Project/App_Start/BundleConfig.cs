﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVC_Project.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundelCollection)
        {
            bundelCollection.Add(new ScriptBundle("~/bundle/script")
                 .Include("~/Scripts/jquery-3.0.0.js",
                   //"~/Scripts/popper.js",
                   "~/Scripts/bootstrap.js"
                   ));
            bundelCollection.Add(new StyleBundle("~/bundle/css")
                    .Include("~/Content/bootstrap.css",
                        "~/Content/style.css"
                  ));


        }
    }
}