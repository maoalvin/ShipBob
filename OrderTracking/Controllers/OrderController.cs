using Newtonsoft.Json;
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

        public ActionResult ViewAll()
        {
            return View();
        }

        public ActionResult CreateOrder()
        {
            return View();
        }

        public void CreateNewOrder(string streetAddress, string city, string state, string zip)
        {
            OrderDetail newOrder = new OrderDetail();

            newOrder.StreetAddress = streetAddress;
            newOrder.City = city;
            newOrder.State = state;
            newOrder.ZipCode = zip;
            newOrder.UserID = CurrentUser.UserID;


            var trackingID= newOrder.GenerateTrackingID(10);
            while(CurrentContext.OrderDetails.Any(o=>o.TrackingID==trackingID && o.UserID==CurrentUser.UserID))
                trackingID = newOrder.GenerateTrackingID(10);

            newOrder.TrackingID = trackingID;
            CurrentContext.OrderDetails.Add(newOrder);
            //Current..Add(newUser);
            CurrentContext.SaveChanges();

           

        }



        public string GetOrdersForUser()
        {
            var ordersForUser= CurrentContext.OrderDetails.Where(o => o.UserID == CurrentUser.UserID).ToList();
            return JsonConvert.SerializeObject(ordersForUser, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
          
        }
    }
}