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
            return View(CurrentUser);
        }

        public ActionResult Login()
        {
            //  var users = GetUsers();
            return View();
        }



        public ActionResult CreateUserPage()
        {

            return View();
        }

        public void CreateUser(string firstName, string lastName)
        {
            UserLogin newUser = new UserLogin();
            newUser.FirstName = firstName;
            newUser.LastName = lastName;

            CurrentUser = newUser;
            CurrentContext.UserLogins.Add(newUser);
            CurrentContext.SaveChanges();

           

        }

        public string LoginUser(string firstName, string lastName)
        {
            if (CurrentContext.UserLogins.Any(u => u.FirstName == firstName && u.LastName == lastName))
            {
                CurrentUser = CurrentContext.UserLogins.Where(u => u.FirstName == firstName && u.LastName == lastName).FirstOrDefault();
                return JsonConvert.SerializeObject(CurrentUser, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
            }
            else
                return null;
        }

        public string GetUsers()
        {

            return JsonConvert.SerializeObject(CurrentContext.UserLogins.ToList(),new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

        }


    }
}