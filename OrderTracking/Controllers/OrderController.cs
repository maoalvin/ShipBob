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

        public List<OrderDetail> GetOrdersForUser(int userID)
        {
            return Current.OrderDetails.Where(o => o.UserID == userID).ToList();
        }
    }
}