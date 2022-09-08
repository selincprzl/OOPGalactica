using Galactica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOPGalactica
{
    internal class Starr
    {
        //A class called star, taking informations from Space Objects classed
        public class Star : SpaceObjects

        {
            //Properties
            public string Type { get; set; }
            public int Temparature { get; set; }
           

            //list of Planets
            public List<Planet> PlanetList = new List<Planet>();
           
              



        }
    }
}
