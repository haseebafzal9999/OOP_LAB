using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Bicycle
    {
        protected int cadence;
        protected int gear;
        protected int speed;

        public Bicycle(int cadence, int speed, int gear)
            {
                this.cadence = cadence;
            this.speed = speed;
            this.gear = gear;
            }
        public void SetCadence(int cardence)
        {
            this.cadence = cardence;
        }
        public int GetCadence() 
        { 
            return this.cadence;
        }
        public void SetGear(int gear)
        {
            this.gear = gear;
        }
        public int GetGear() 
        {
            return gear;
        }
        public void ApplyBrakes(int decrement)
        {
            speed -= decrement;
        }
        public void SpeedUp(int increment)
        {
            this.speed += increment;
        }


          
    }
}
