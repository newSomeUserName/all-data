using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractTest
{
    internal class Person
    {
        public virtual string Name { get; set; }
        public virtual string GetPers() 
        {
            return "PERS";
        }
        public override bool Equals(object obj)
        {
            return Name == ((Person)obj).Name;
        }
    }
}
