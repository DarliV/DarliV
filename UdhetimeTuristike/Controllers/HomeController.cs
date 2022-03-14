using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UdhetimeTuristike.Models;

namespace UdhetimeTuristike.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact([Bind(Include = "contactName, contactEmail, contactPhone, contactMessage")] ContactUsPage contactUs) 
        {
            if (User.Identity.IsAuthenticated)
            {
               
                ModelState["contactEmail"].Errors.Clear();
                var user = User.Identity.GetUserName();
                contactUs.contactEmail = user;
                ModelState["contactName"].Errors.Clear();
                string contactName = (from k in db.Users
                                      where (k.Email == user)
                                      select k.FullName).Single();
                contactUs.contactName = contactName;
                
            }
            if (ModelState.IsValid)
            {
                    db.ContactUs.Add(contactUs);
                    db.SaveChanges();
                    return RedirectToAction("Contact");
            }
            return View(contactUs);
        }

        public ActionResult Italy()
        {
            return View();
        }
        public ActionResult France()
        {
            return View();
        }
        public ActionResult Germany()
        {
            return View();
        }
    }
}