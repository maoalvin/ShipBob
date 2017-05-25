using OrderTrackng.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderTracking.Controllers
{
    public class UserController : BaseController
    {
        // GET: User
        public ActionResult Index()
        {
            var users = GetUsers();
            return View(users);
        }

        public ActionResult CreateUserPage()
        {

            return View();
        }

        public ActionResult CreateUser(string firstName, string lastName)
        {
            UserLogin newUser = new UserLogin();
            newUser.FirstName = firstName;
            newUser.LastName = lastName;


            Current.UserLogins.Add(newUser);
            Current.SaveChanges();

            return RedirectToAction("Index", "User");

        }


    }
}