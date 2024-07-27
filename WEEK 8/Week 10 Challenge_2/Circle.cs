using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10_Challenge_2
{
    internal class Circle
    {
        protected double radius ;
        private string color ;
        public Circle() { }
        public Circle(double radius) 
        {
            this.radius = radius;
        }
        public Circle(double radius ,string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public string GetColor()
        {
            return this.color;
        }
        public double GetArea()
        {
            return this.radius;
        }
        public string toString()
        {
            return this.color;
        }


    }
}
