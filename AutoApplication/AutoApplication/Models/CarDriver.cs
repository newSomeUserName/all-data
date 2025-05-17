using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoApplication.Models
{
    internal class CarDriver
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public List<int> CarIds { get; set; }

        public CarDriver()
        {
            
        }

    }
}
