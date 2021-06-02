using authentication_and_authorization.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace authentication_and_authorization.Controllers
{    [Authorize]
     [HandleError]

    public class HomeController : Controller
    {
        dbcontext db = new dbcontext();
        [Authorize]
        public ActionResult Index()
        {
            //var a = db.users.ToList();
            //return View(a);
            var users = db.users.Include(u => u.Roles);
            return View(users.ToList());
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult  create()
        {
            ViewBag.ROLEID = new SelectList(db.Roles, "ROLEID", "name");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "id,name,address,ROLEID")] user user)
        {
            if (ModelState.IsValid)
            {
                db.users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ROLEID = new SelectList(db.Roles, "ROLEID", "name", user.ROLEID);
            return View(user);
        }

        [Authorize(Roles="Admin")]
        public ActionResult Edit(int? id)
        {
            user user = db.users.Find(id);
            ViewBag.ROLEID = new SelectList(db.Roles, "ROLEID", "name", user.ROLEID);
            return View(user);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "id,name,address,ROLEID")] user user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ROLEID = new SelectList(db.Roles, "ROLEID", "name", user.ROLEID);
            return View(user);
        }
        public ActionResult Delete(int? id)
        {
            var c = db.users.Find(id);
            return View(c);
        }
        [HttpPost]
        public ActionResult Delete(user u)
        {
            db.Entry(u).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult about()
        {
            return View();
        }

    }
}