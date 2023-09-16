using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timetable_maker
{
    internal class Line
    {
        public string Name {  get; set; }
        public FirstStation FirstStation { get; set; }
       
        public Line(string name, FirstStation firstStation)
        {
            Name = name;
            FirstStation = firstStation;
        }
    }
}
