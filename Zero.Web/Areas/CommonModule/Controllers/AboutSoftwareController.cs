﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zero.Web.Areas.CommonModule.Controllers
{
    /// <summary>
    /// 关于软件
    /// </summary>
    public class AboutSoftwareController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
