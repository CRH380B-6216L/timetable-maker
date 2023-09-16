using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timetable_maker
{
    [Serializable]
    internal class Spot
    {
        public Kilometer StKilometer { get; set; }
        public int MaxSpeed { get; set; }
        public Spot? PreviousSpot { get; set; }
        public Spot? NextSpot { get; set; }

        internal Kilometer ZhanJianKM;
        public Spot(Kilometer kmvalue, int maxspeed) 
        {
            StKilometer = kmvalue;
            MaxSpeed = maxspeed;
        }

        public Spot(int km, int m, int maxspeed)
        {
            StKilometer = new Kilometer(km, m);
            MaxSpeed = maxspeed;
        }

        public override string ToString()
        {
            return "Spot";
        }

        public virtual void Attach(Spot sp)
        {
            if (sp == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                sp.NextSpot = this;
                PreviousSpot = sp;
                ZhanJianKM = StKilometer - sp.StKilometer;
            }
        }

        public Kilometer CalculateZhanjianKM()
        {
            return ZhanJianKM;
        }

        public DateTime CalculatePassageTime()
        {
            int result = ZhanJianKM.Value();
            DateTime time = new();
            double seconds = result * 3.6 / MaxSpeed;
            return time.AddSeconds(seconds);
        }
    }
}
