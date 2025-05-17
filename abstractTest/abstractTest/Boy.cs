using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractTest
{
    internal class Boy : MAN
    {
        public override string Name { get; set; }
        public override string GetPers()
        {
            return "Boy";
        }
        public override bool Equals(object obj)
        {
            return Name == ((Boy)obj).Name;
        }
    }
}
