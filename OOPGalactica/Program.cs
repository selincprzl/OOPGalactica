using OOPGalactica;
using static Galactica.SpaceObjects;
using static OOPGalactica.Starr;
using static OOPGalactica.Planet;
using static OOPGalactica.Moon;
using Galactica;

//Created a star called "sun" gave it an ID, name, type and temparature. I called the properties i created in SpaceObjects class and Star class.
Star sun = new Star();
sun.ID = "1";
sun.Name = " Sun";
sun.Type = SpaceObjects.StarType.YellowDwarf.ToString();
sun.Temparature = 5500;

//Created all the planets, gave them ID, name, type, diameter, rotation and revoluation period. I called the properties I created in Class called Planet and class called SpaceObjects.
Planet mercury = new Planet();
mercury.ID = "1";
mercury.Name = "Mercury";
mercury.Type = PlanetType.Terrestial.ToString();
mercury.Diameter = 4880000;
mercury.RotationPeriod = 1407;
mercury.RevolutionPeriod = 176;

Planet venus = new Planet();
venus.ID= "2";
venus.Name = "Venus";
venus.Type = PlanetType.Terrestial.ToString();
venus.Diameter = 6051800;
venus.RotationPeriod = 5682;
venus.RevolutionPeriod = 116;

Planet earth = new Planet();
earth.ID = "3";
earth.Name = "Earth";
earth.Type = PlanetType.Terrestial.ToString();
earth.Diameter = 12742000;
earth.RotationPeriod = 24;
earth.RevolutionPeriod = 365;

Planet mars = new Planet();
mars.ID = "4";
mars.Name = "Mars";
mars.Type = PlanetType.Terrestial.ToString();
mars.Diameter = 6779000;
mars.RotationPeriod = 25;
mars.RevolutionPeriod = 687;

Planet jupiter = new Planet();
jupiter.ID = "5";
jupiter.Name = "Jupiter";
jupiter.Type = PlanetType.Terrestial.ToString();
jupiter.Diameter = 139820000;
jupiter.RotationPeriod = 10;
jupiter.RevolutionPeriod = 4300;

Planet saturn = new Planet();
saturn.ID = "6";
saturn.Name = "Saturn";
saturn.Type = PlanetType.Terrestial.ToString();
saturn.Diameter = 116460000;
saturn.RotationPeriod = 10;
saturn.RevolutionPeriod = 11000;

Planet uranus = new Planet();
uranus.ID = "7";
uranus.Name = "Uranus";
uranus.Type = PlanetType.Terrestial.ToString();
uranus.Diameter = 50724000;
uranus.RotationPeriod = 17;
uranus.RevolutionPeriod = 30660;

Planet neptune = new Planet();
neptune.ID = "8";
neptune.Name = "Neptune";
neptune.Type = PlanetType.Terrestial.ToString();
neptune.Diameter = 49244000;
neptune.RotationPeriod = 161;
neptune.RevolutionPeriod = 1658;

//Created all the moons that has been asked.
Moon luna = new Moon();
luna.ID = "1";
luna.Name = "Luna";
luna.Type = PlanetType.Terrestial.ToString();
luna.Diameter = 49244000;
luna.RotationPeriod = 16;
luna.RevolutionPeriod = 165;

Moon titan = new Moon();
titan.ID = "2";
titan.Name = "Titan";
titan.Type = PlanetType.Terrestial.ToString();
titan.Diameter = 49244000;
titan.RotationPeriod = 17;
titan.RevolutionPeriod = 165;

Moon phobos = new Moon();
phobos.ID = "3";
phobos.Name = "Phobos";
phobos.Type = PlanetType.Terrestial.ToString();
phobos.Diameter = 49244000;
phobos.RotationPeriod = 16;
phobos.RevolutionPeriod = 165;

Moon europe = new Moon();
europe.ID = "4";
europe.Name = "Europe";
europe.Type = PlanetType.Terrestial.ToString();
europe.Diameter = 49244000;
europe.RotationPeriod = 17;
europe.RevolutionPeriod = 165;

Moon deimos = new Moon();
deimos.ID = "5";
deimos.Name = "Deimos";
deimos.Type = PlanetType.Terrestial.ToString();
deimos.Diameter = 49244000;
deimos.RotationPeriod = 17;
deimos.RevolutionPeriod = 165;

Moon ganymedes = new Moon();
ganymedes.ID = "6";
ganymedes.Name = "Ganymedes";
ganymedes.Type = PlanetType.Terrestial.ToString();
ganymedes.Diameter = 49244000;
ganymedes.RotationPeriod = 16;
ganymedes.RevolutionPeriod = 156;

Moon io = new Moon();
io.ID = "7";
io.Name = "Io";
io.Type = PlanetType.Terrestial.ToString();
io.Diameter = 49244000;
io.RotationPeriod = 16;
io.RevolutionPeriod = 154;

Moon mimas = new Moon();
mimas.ID = "6";
mimas.Name = "Mimas";
mimas.Type = PlanetType.Terrestial.ToString();
mimas.Diameter = 49244000;
mimas.RotationPeriod = 14;
mimas.RevolutionPeriod = 143;

//added the planets in the Planet list 
sun.PlanetList.Add(mercury);
sun.PlanetList.Add(venus);
sun.PlanetList.Add(earth);
sun.PlanetList.Add(mars);
sun.PlanetList.Add(uranus);
sun.PlanetList.Add(neptune);
sun.PlanetList.Add(jupiter);
sun.PlanetList.Add(saturn);

//added the planets in Moon list.
earth.MoonList.Add(luna);
saturn.MoonList.Add(titan);
saturn.MoonList.Add(phobos);
mars.MoonList.Add(europe);
mars.MoonList.Add(deimos);
jupiter.MoonList.Add(ganymedes);
jupiter.MoonList.Add(io);
jupiter.MoonList.Add(mimas);


//printing planets and moons on the screen

foreach (var Planet in sun.PlanetList)
{
    Console.WriteLine($"Id: {Planet.ID}\n" + $"Name: {Planet.Name}\n" + $"Type: {Planet.Type}\n" + $"Diameter: {Planet.Diameter}\n" + $"Rotation Period: {Planet.RotationPeriod}\n" + $"Revoluation Period: {Planet.RevolutionPeriod}\n"); 

    foreach (var Moon in Planet.MoonList)
    {
        Console.WriteLine($"Id: {Moon.ID}\n" + $"Name: {Moon.Name}\n" + $"Type: {Moon.Type}\n" + $"Diameter: {Moon.Diameter}\n" + $"Rotation Period: {Moon.RotationPeriod}\n" + $"Revoluation Period: {Moon.RevolutionPeriod}\n");
    }

}
    Console.ReadKey();






