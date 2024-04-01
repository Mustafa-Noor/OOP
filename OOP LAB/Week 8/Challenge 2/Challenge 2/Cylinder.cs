using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    internal class Cylinder:Circle
    {
        private double Height = 1.0;
        public Cylinder() { }

        public Cylinder(double radius): base(radius) { }

        public Cylinder(double radius, double height) : base(radius)
        {
            this.Height = height;
        }
        public Cylinder(double radius, double height, string color) : base(radius, color)
        {
            this.Height = height;
        }

        public double GetHeight()
        { return Height; }


        public void SetHeight(double height)
        {
            this.Height = height;
        }

        public double GetVolume()
        {
            return base.GetArea()*Height;
        }

    }
}
