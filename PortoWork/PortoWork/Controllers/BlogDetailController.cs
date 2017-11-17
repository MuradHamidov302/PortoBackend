using PortoWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortoWork.Controllers
{
    public class BlogDetailController : Controller
    {
        PortoDB db = new PortoDB();
        // GET: BlogDetail
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Blog", "Index");
            }
            var det = db.Blogs.Where(b => b.blog_id == id).SingleOrDefault();
            if (det == null)
            {
                return RedirectToAction("Blog", "Index");
            }
            return View(det);
        }

        public JsonResult Comms(string com,int blog)
        {
            var userid1 = Session["userid"];
            if (com == null)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
               
            }
            db.Comments.Add(new Comment { user_id = Convert.ToInt32(userid1), text = com, blog_id = blog });
                db.SaveChanges();
            return Json(false, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Remove(int id)
        {
            var userid1 = Session["userid"];
            var commen = db.Comments.Where(c => c.com_id == id).SingleOrDefault();
            var blog = db.Blogs.Where(b => b.blog_id == commen.blog_id).SingleOrDefault();
            if (commen.user_id == Convert.ToInt32(userid1))
            {
                db.Comments.Remove(commen);
                db.SaveChanges();
                return RedirectToAction("Index", "BlogDetail", new { id = blog.blog_id });
            }

            return View();
        }
    }
}