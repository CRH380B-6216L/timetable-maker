using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timetable_maker
{
    [Serializable]
    internal class Kilochange : Spot
    {
        public Kilometer NewKM
        {
            get => StKilometer;
            set => StKilometer = value;
        }

        public Kilometer OldKM { get; set; }

        public Kilochange(Kilometer oldKM, Kilometer newKM, int maxspeed) : base (oldKM, maxspeed)
        {
            OldKM = oldKM;
            NewKM = newKM;
        }

        public override void Attach(Spot sp)
        {
            if (sp == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                sp.NextSpot = this;
                PreviousSpot = sp;
                ZhanJianKM = OldKM - sp.StKilometer;
            }
        }

        public override string ToString()
        {
            return $"里程突变点 {OldKM}";
        }
    }
}
