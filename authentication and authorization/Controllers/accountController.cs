using authentication_and_authorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace authentication_and_authorization.Controllers
{
    public class accountController : Controller
    {
        dbcontext db = new dbcontext();
        // GET: account
        public ActionResult signup()
        {
            ViewBag.ROLEID = new SelectList(db.Roles, "ROLEID", "name");
            return View();
        }
        [HttpPost]
        public ActionResult signup(user user)
        {
            if(ModelState.IsValid)
            {
                db.users.Add(user);
                db.SaveChanges();
                return RedirectToAction("login");
            }
            
            ViewBag.ROLEID = new SelectList(db.Roles, "ROLEID", "name", user.ROLEID);
            return View(user);
        }
        public ActionResult login(user u)
        {
          var a= db.users.Where(x => x.name == u.name).FirstOrDefault();
            if(a!=null)
            {
                FormsAuthentication.SetAuthCookie(u.name, false);
                return RedirectToAction("Index", "home");
            }
            else
            {
               
                return View();
            }
           
        }
        public ActionResult logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("login");
        }
    }
}