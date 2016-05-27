using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public enum Status
    {
        EngineOn,
        EngineOff,
        Stopped,
        Moving,
        Other
    }
    public class Car
    {
        private bool accelerator;
        private bool brake;
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
        public void PressAccelerator()
        {
            accelerator = true;
            brake = false;
        }
        public void PressBrake()
        {
            accelerator = false;
            brake = true;
        }
        public Status GetStatus()
        {
            if(engineState == true)
            {
                if (accelerator == true)
                {
                    return Status.Moving;
                }
                if(brake == true)
                {
                    return Status.Stopped;
                }
                    return Status.EngineOn;
            }
            else if(engineState == false)
            {
                return Status.EngineOff;
            }
            else
            {
                return Status.Other;
            }
           
          
        }


       
        /*public bool Moving()
        {
            if(engineState == true && accelerator == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Stopped()
        {
            if (engineState == false)
            {
                return true;
            }
            else if (accelerator == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/

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
