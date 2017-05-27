using OrderTrackng.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderTracking.Controllers
{
    public class OrderController : BaseController
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateOrder(string streetAddress, string city, string state, string zip)
        {
            OrderDetail newOrder = new OrderDetail();

            newOrder.StreetAddress = streetAddress;
            newOrder.City = city;
            newOrder.State = state;
            newOrder.ZipCode = zip;
            //Current..Add(newUser);
            Current.SaveChanges();

            return RedirectToAction("Index", "User");

        }

        public List<OrderDetail> GetOrdersForUser(int userID)
        {
            return Current.OrderDetails.Where(o => o.UserID == userID).ToList();
        }
    }
}