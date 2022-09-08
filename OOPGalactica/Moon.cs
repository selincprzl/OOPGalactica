using Galactica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGalactica
{
    //A class called moon, taking info from SpaceObjects
    internal class Moon: SpaceObjects
    {
        //Properties
        public Planet Planet { get; set; }
        public string Type { get; set; }

        public int Diameter { get; set; }
        public int RotationPeriod;
        public int RevolutionPeriod;
    }
}
