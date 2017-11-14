using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortoWork.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Errors( string aspxerrorpath)
        {
            if (!string.IsNullOrWhiteSpace(aspxerrorpath))
            {
                return Redirect("Errors");
            }

            return View();
        }
    }
}