using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PortoWork.Models;

namespace PortoWork.Areas.Admin.Controllers
{
    public class User1Controller : Controller
    {
        private PortoDB db = new PortoDB();

        // GET: Admin/User1
        public ActionResult Index()
        {
            var user1 = db.User1.Include(u => u.User_type);
            return View(user1.ToList());
        }

        // GET: Admin/User1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User1 user1 = db.User1.Find(id);
            if (user1 == null)
            {
                return HttpNotFound();
            }
            return View(user1);
        }

        // GET: Admin/User1/Create
        public ActionResult Create()
        {
            ViewBag.usertypr_id = new SelectList(db.User_type, "type_id", "type_name");
            return View();
        }

        // POST: Admin/User1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "user_id,user_name,age,usertypr_id,password,email,user_about")] User1 user1)
        {
            if (ModelState.IsValid)
            {
                db.User1.Add(user1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.usertypr_id = new SelectList(db.User_type, "type_id", "type_name", user1.usertypr_id);
            return View(user1);
        }

        // GET: Admin/User1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User1 user1 = db.User1.Find(id);
            if (user1 == null)
            {
                return HttpNotFound();
            }
            ViewBag.usertypr_id = new SelectList(db.User_type, "type_id", "type_name", user1.usertypr_id);
            return View(user1);
        }

        // POST: Admin/User1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "user_id,user_name,age,usertypr_id,password,email,user_about")] User1 user1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.usertypr_id = new SelectList(db.User_type, "type_id", "type_name", user1.usertypr_id);
            return View(user1);
        }

        // GET: Admin/User1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User1 user1 = db.User1.Find(id);
            if (user1 == null)
            {
                return HttpNotFound();
            }
            return View(user1);
        }

        // POST: Admin/User1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User1 user1 = db.User1.Find(id);
            db.User1.Remove(user1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
