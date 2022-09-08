using Galactica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGalactica
{
    //enum of planet types
    public enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }

    //A class called planet, takes informations from spaceobjects
    internal class Planet: SpaceObjects
    {
        //Properties
        public string? Type { get; set; }

        //Moonlist
        public List<Moon> MoonList = new List<Moon>();

        public int Diameter;
        public int RotationPeriod;
        public int RevolutionPeriod;

        
        }
    }

