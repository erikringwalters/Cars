using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Supercar : Car
    {
       public Supercar()
        {
            base.cruisingSpeed = 30;
            base.maximumSpeed = 200;
        }
    }
}
