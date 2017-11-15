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
                return Content("Id not found");
            }
            var serviceid = db.Services.Where(b => b.serv_id == id).SingleOrDefault();
            if (serviceid == null)
            {
                return Content("Id not found");
            }
            return View(serviceid);
        }
    }
}