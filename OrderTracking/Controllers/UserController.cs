using Newtonsoft.Json;
using OrderTrackng.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace OrderTracking.Controllers
{
    public class UserController : BaseController
    {
        // GET: User
        public ActionResult Index()
        {
          //  var users = GetUsers();
            return View();
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

        public string GetUsers()
        {

            return JsonConvert.SerializeObject(Current.UserLogins.ToList());

        }


    }
}