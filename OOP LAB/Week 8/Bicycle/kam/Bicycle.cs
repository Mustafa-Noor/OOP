using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kam
{
    internal class Bicycle
    {
        protected int cadence;
        protected int gear;
        protected int speed;

        public Bicycle(int cadence, int speed, int gear)
        {
            this.cadence = cadence;
            this.gear = gear;
            this.speed = speed;
        }

        public void setCadence(int cadence)
        {
            this.cadence = cadence;
        }
        public void setGear(int gear) {  this.gear = gear; }
        public void applyBrake(int decrement)
        {
            speed = speed -decrement;
        }
        public void speedUp(int increment)
        {
            speed +=increment;
        }

        public void showInfo()
        {
            Console.WriteLine($"Cadence: {cadence} \nGear: {gear} \nSpeed: {speed}");
        }
    }
}
