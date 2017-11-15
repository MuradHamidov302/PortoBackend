using PortoWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortoWork.Controllers
{
    public class ProjectDetailController : Controller
    {
        PortoDB db = new PortoDB();

        // GET: ProjectDetail
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return Content("Id not found");
            }
            var ProjectId = db.Projects.Where(b => b.pro_id == id).SingleOrDefault();
            if (ProjectId == null)
            {
                return Content("Id not found");
               
            } return View(ProjectId);
        }
    }
}