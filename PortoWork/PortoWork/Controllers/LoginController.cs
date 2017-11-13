using PortoWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace PortoWork.Controllers
{
    public class LoginController : Controller
    {
         PortoDB db = new PortoDB();


        // GET: Login
        public ActionResult Index(int id)
        {
            var det = db.User1.Where(u => u.user_id == id).SingleOrDefault();
            if (Convert.ToInt32(Session["userid"]) != det.user_id)
            {
                return RedirectToAction("index", "MainPg");
            }
            return View();
        }
        
        public ActionResult Login1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login1(User1 use,string password)
        {
            var md5pas = Crypto.Hash(password,"MD5");
            var Login = db.User1.Where(x => x.user_name == use.user_name).SingleOrDefault();

            if (Login.user_name==use.user_name && Login.password==md5pas)
            {
                Session["userid"] = Login.user_id;
                Session["username"] = Login.user_name;
                Session["usertype"] = Login.User_type.type_id;

                return RedirectToAction("index", "MainPg");
            }

            ViewBag.error = "password or username false";
            return View();
        }

        public ActionResult Logout()
        {
            Session["userid"] = null;
            Session.Abandon();
            return RedirectToAction("index", "MainPg");
        }



        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User1 user, string password)
        {
           var pas2 = password;
            user.usertypr_id = 1;
            user.password = Crypto.Hash(pas2,"MD5");
            db.User1.Add(user);
            db.SaveChanges();
            Session["userid"] = user.user_id;
            Session["username"] = user.user_name;

            return RedirectToAction("index","MainPg");
        }
    }
}