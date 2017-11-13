using PortoWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortoWork.Controllers
{
    public class MainPgController : Controller
    {
        PortoDB db = new PortoDB();
        ViewModel take = new ViewModel();
        // GET: MainPg
        public ActionResult Index()
        {
            take.blog = db.Blogs.ToList();
            take.service = db.Services.ToList();
            return View(take);
        }
    }
}