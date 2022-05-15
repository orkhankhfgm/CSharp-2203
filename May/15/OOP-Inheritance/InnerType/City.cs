using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerType
{
    public class City : BaseClass
    {
        public string Name { get; set; }
        
        //Inner Type field
        public Country Country;
    }
}
