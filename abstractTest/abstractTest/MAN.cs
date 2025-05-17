using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractTest
{
    internal class MAN : Person
    {
        public override string Name { get; set; }
        public override string GetPers()
        {
            return "MAN";
        }

        public override bool Equals(object obj)
        {
            return Name == ((MAN)obj).Name;
        }
    }
}
