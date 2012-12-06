using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTest.Core.Attributes;
using WebTest.Models;

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

            var initialState = new[]
                {
                    new GiftModel {Name = "Bogdan Erlang", Price = 49.95},
                    new GiftModel {Name = "Kjell Eriksson", Price = 78.25}
                };
            return View(initialState);
        }

        [HttpPost]
        public ActionResult Index([FromJson] IEnumerable<GiftModel> gifts)
        {
            // Can process the data any way we want here,
            // e.g., further server-side validation, save to database, etc
            //return View("Saved", gifts);
            return View(gifts.ToArray());
        }
    }
}
