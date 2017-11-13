using PortoWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PortoWork.Controllers
{
    public class ServiceDetailController : Controller
    {
        PortoDB db = new PortoDB();

        // GET: ServiceDetail
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Service ser = db.Services.Find(id);
            if (ser == null)
            {
                return HttpNotFound();
            }
            return View(ser);
        }
    }
}