﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTest.Controllers
{
    public class DynamicController : Controller
    {
        //
        // GET: /Dynamic/

        public ActionResult Index(int? id)
        {
            return View();
        }

    }
}