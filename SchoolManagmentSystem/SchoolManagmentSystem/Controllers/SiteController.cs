﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolManagmentSystem.CustomAuth;
namespace SchoolManagmentSystem.Controllers
{
    public class SiteController : Controller
    {
        [ValidateAntiForgeryToken]
        [CustomAuthentication()]
        public ActionResult Contents()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
    }
}