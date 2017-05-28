using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTrackng.BusinessObjects
{
    public partial class UserLogin
    {
        public int TotalOrders
        {
            get
            {
                ShipBobEntities1 sp = new ShipBobEntities1();
                return sp.OrderDetails.Where(o => o.UserID == this.UserID).Count();
            }
        }
    }
}
