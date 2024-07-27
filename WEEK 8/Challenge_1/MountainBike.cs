using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class MountainBike : Bicycle
    {
        private int SeatHeight;
        public  MountainBike(int SeatHeight,int Cadence ,int speed ,int gear) :base( Cadence, speed, gear)
        {
            this.SeatHeight = SeatHeight;
            this.cadence = Cadence;
            this.speed = speed;
            this.gear = gear;
        }
        public void SetSeatHeiht(int seatHeight)
        {
            this.SeatHeight = seatHeight;
        }
        public int GetSeatHeiht() {  return this.SeatHeight; }

    }
}
