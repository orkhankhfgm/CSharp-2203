using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    public class Order : BaseClass
    {
        public string OrderDetails { get; set; }

        //Inner Type
        public Address ShippingDetails { get; set; }
    }
}
