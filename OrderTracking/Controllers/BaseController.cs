using OrderTrackng.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderTracking.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base


        public List<UserLogin> GetUsers()
        {
            ShipBobEntities1 sp = new OrderTrackng.BusinessObjects.ShipBobEntities1();
            return sp.UserLogins.ToList();
          //  return   ShipBobEntities1.Current.UserLogins.ToList();
        }
    }
}