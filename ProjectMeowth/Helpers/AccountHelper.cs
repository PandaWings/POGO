﻿using ProjectMeowth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace ProjectMeowth.Helpers
{
    public static class AccountHelper
    {
        public static bool IsLoggedIn()
        {
            bool val1 = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            return val1;
        }

        public static String GetUsername()
        {
            string userName = string.Empty;

            if (System.Web.HttpContext.Current != null &&
                System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                var usr = HttpContext.Current.User.Identity;
                if (usr != null)
                {
                    userName = usr.Name;
                }
            }

            return userName;
        }

    }
}