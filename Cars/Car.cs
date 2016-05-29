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
        private float currentSpeed;
        protected float cruisingSpeed = 20;
        protected float maximumSpeed = 100;
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
      
        public void PressBrake()
        {
            accelerator = false;
            brake = true;
        }
        public void PressAccelerator()
        {
            PressAccelerator(cruisingSpeed);
        }
        public void PressAccelerator(float speed)
        {
            accelerator = true;
            brake = false;
            if (speed >= maximumSpeed)
            {
                currentSpeed = maximumSpeed;
            }
            else
            {
                currentSpeed = speed;
            }
        }
        private Status GetStatus()
        {
            if (engineState == true)
            {
                if (accelerator == true)
                {
                    return Status.Moving;
                }
                if (brake == true)
                {
                    return Status.Stopped;
                }
                return Status.EngineOn;
            }
            else if (engineState == false)
            {
                return Status.EngineOff;
            }
            else
            {
                return Status.Other;
            }
        }

        public Report GetReport()
        {
            Report report = new Report();
            report.Status = this.GetStatus();
            report.CurrentSpeed = this.currentSpeed;
            return report;
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
