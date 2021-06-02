using authentication_and_authorization.filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace authentication_and_authorization.Controllers
{       [HandleError]
    public class FilterController : Controller
    {
        // GET: Filter

            [filterax]
        public ActionResult Index()
        {
            int[] a = new int[5];
            a[70] = 45;
            return View();
        }
        public ActionResult about()
        {
            return View();
        }
    }
}