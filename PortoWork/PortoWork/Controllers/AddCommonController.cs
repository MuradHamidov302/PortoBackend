using PortoWork.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortoWork.Controllers
{
    public class AddCommonController : Controller
    {

        PortoDB db = new PortoDB();
        // GET: AddCommon
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Blogadd()
        {
        
            return View();
        }
        [HttpPost]
        public ActionResult Blogadd(Blog blog, HttpPostedFileBase foto)
        {
            if (foto != null)
            {
                var filename = foto.FileName;
                string ext = Path.GetExtension(foto.FileName);
          
                string FileYolu = Guid.NewGuid().ToString() + filename + ext;
                var yuklemeYeri = Server.MapPath("/Content/img/") + FileYolu;
                foto.SaveAs(yuklemeYeri);
                blog.img_name = FileYolu;

            }
            var userid = Convert.ToInt32(Session["userid"]);
            blog.user_id = userid;
            db.Blogs.Add(blog);
            db.SaveChanges();
            return RedirectToAction("Index","MainPg");
        }
    }
}