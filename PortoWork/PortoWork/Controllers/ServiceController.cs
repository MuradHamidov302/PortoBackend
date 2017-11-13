using PortoWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortoWork.Controllers
{
    public class ServiceController : Controller
    {

        PortoDB db = new PortoDB();
        // GET: Service
        public ActionResult Index()
        {
            return View(db.Services.ToList());
        }
    }
}