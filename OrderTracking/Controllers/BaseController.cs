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
        private const string ShipBobContext = "OrderTrackng.BusinessObjects.ShipBobEntities1";
        protected static ShipBobEntities1 _current;
        public static ShipBobEntities1 Current
        {
            get
            {
                if (System.Web.HttpContext.Current != null)
                {
                    if (!System.Web.HttpContext.Current.Items.Contains(ShipBobContext))
                    {
                        var context = new OrderTrackng.BusinessObjects.ShipBobEntities1();
                        System.Web.HttpContext.Current.Items.Add(ShipBobContext, context);
                        return context;
                    }
                    return System.Web.HttpContext.Current.Items[ShipBobContext] as ShipBobEntities1;
                }

                if (_current == null)
                {
                    _current = new OrderTrackng.BusinessObjects.ShipBobEntities1();
                }
                return _current ?? (_current = new OrderTrackng.BusinessObjects.ShipBobEntities1());
            }
        }


        public List<UserLogin> GetUsers()
        {
          //  ShipBobEntities1 sp = new OrderTrackng.BusinessObjects.ShipBobEntities1();
            return Current.UserLogins.ToList();
          //  return   ShipBobEntities1.Current.UserLogins.ToList();
        }
    }
}