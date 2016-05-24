using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car
    {
        private string color;
        public void set_color(string a)
        {
            color = a;
        }
        public string get_color()
        {
            return color;
        }
    }
}
