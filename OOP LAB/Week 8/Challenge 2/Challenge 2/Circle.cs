using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    internal class Circle
    {
        protected double Radius = 1.0;
        protected string Color = "red";

        public Circle() { }
        public Circle(double radius)
        { 
            this.Radius = radius;
        }
        public double GetRadius()
        {
            return this.Radius;
        }
        public void SetRadius(double radius)
        {
            this.Radius = radius;
        }
        public string GetColor()
        {
              return this.Color;
        }
        public void SetColor(string color)
        {
            this.Color = color;
        }

        public double GetArea()
        {
            return ((3.14) * (Radius * Radius));
        }
        public string toString()
        {
            return $"(Circle[radius = {Radius}, color = {Color}])";
        }

        public Circle(double radius, string color)
        {
            this.Radius = radius;
            this.Color = color;
        }
    }
}
