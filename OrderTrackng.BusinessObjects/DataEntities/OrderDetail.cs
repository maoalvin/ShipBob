using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTrackng.BusinessObjects
{
    public partial class OrderDetail
    {


        const string _characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        public string GenerateTrackingID(int lenght)
        {
            Random random = new Random();
            StringBuilder buffer = new StringBuilder(lenght);
            for (int i = 0; i < lenght; i++)
            {
                int randomNumber = random.Next(0, _characters.Length);
                buffer.Append(_characters, randomNumber, 1);
            }
            return buffer.ToString();
        }

    }
}
