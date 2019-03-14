using Gnoe.Tasks.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UvA.Web;

namespace Gnoe.Tasks.Website.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            new Handler<CorePage>().ProcessRequest(System.Web.HttpContext.Current);
            return null;
        }
    }
}