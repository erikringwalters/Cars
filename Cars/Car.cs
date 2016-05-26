using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car
    {
        public string Color { get;set;}
        private bool engineState;
        public bool engineStatus()
        {
            return engineState;
        }
        public void TurnCarOn()
        {
            engineState = true;
        }
        public void TurnCarOff()
        {
            engineState = false;
        }
        /*public void set_color(string a)
        {
            color = a;
        }
        public string get_color()
        {
            return color;
        }*/
        //creating a property so we don't have get and sets.
        //public string Color { get { return color; } set { color = value; } }
    }
}
