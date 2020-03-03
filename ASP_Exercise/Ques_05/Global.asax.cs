﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Ques_05
{
    public class Global : HttpApplication
    {
   
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup  
            Application["TotalOnlineUsers"] = 0;
        }
        void Session_Start(object sender, EventArgs e)
        {
           
            Application.Lock();
            Application["TotalOnlineUsers"] = (int)Application["TotalOnlineUsers"] + 1;
            Application.UnLock();
        }

        void Session_End(object sender, EventArgs e)
        {
            
            Application.Lock();
            Application["TotalOnlineUsers"] = (int)Application["TotalOnlineUsers"] - 1;
            Application.UnLock();
        }
    }
}