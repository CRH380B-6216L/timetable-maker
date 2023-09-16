using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timetable_maker
{
    [Serializable]
    internal class Station : Spot
    {
        public string Name { get; set; }
        public Station(string name, Kilometer kmvalue, int maxspeed) : base(kmvalue, maxspeed)
        {
            Name = name;
            StKilometer = kmvalue;
            MaxSpeed = maxspeed;
        }

        public Station(string name, int km, int m, int maxspeed) : base(km, m, maxspeed) 
        {
            Name = name;
            StKilometer = new Kilometer(km, m);
            MaxSpeed = maxspeed;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    internal class FirstStation : Station
    {
        public FirstStation(string name, Kilometer kmvalue) : base(name, kmvalue, 0)
        {
            Name = name;
            StKilometer = kmvalue;
        }

        public override void Attach(Spot sp)
        {
            throw new Exception("Not allowed first spot attached");
        }
    }
}
