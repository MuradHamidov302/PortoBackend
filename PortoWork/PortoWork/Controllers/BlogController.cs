using PortoWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortoWork.Controllers
{
   
    public class BlogController : Controller
    {
        PortoDB db = new PortoDB();
        // GET: Blog
        public ActionResult Index()
        {
            return View(db.Blogs.ToList());
        }

        public ActionResult Remove( int id)
        {
            var blog = db.Blogs.Where(b => b.blog_id ==id).SingleOrDefault();
           
                db.Blogs.Remove(blog);
                db.SaveChanges();
                return RedirectToAction("Index", "Blog");
          

        }
    }
}