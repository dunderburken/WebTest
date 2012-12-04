using System;
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

        public ActionResult Index(DateTime? date)
        {
            if (!date.HasValue)
            {
                var today = DateTime.Now;
                return RedirectToAction("Index", new {date = today.ToString("yyyy-MM-dd")});
            }
            return View();
        }

    }
}
