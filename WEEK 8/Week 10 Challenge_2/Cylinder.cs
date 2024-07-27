using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10_Challenge_2
{
    internal class Cylinder : Circle
    {
        private double height;

        public Cylinder()
        { }
        public Cylinder(double height ,double radius): base( radius )
        { 
            this.height =height;
            this.radius = radius;
        }
        public void SetHeight(double height)
        {
            this.height = height;
        }
        public double GetHeigh()
        {
            return this.height;
        }
       
        

    }
}
