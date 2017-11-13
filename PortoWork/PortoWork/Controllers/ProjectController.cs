using PortoWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortoWork.Controllers
{
    public class ProjectController : Controller
    {
        PortoDB db = new PortoDB();
        ViewModel take = new ViewModel();
        // GET: Project
        public ActionResult Index()
        {
            take.service = db.Services.ToList();
            take.project = db.Projects.ToList();
            return View(take);
        }
    }
}