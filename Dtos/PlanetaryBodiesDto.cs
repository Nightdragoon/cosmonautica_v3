namespace cosmonautica_v2.Dtos;

public class PlanetaryBodiesDto
{
    public List<Body> bodies { get; set; }

}
    public class AroundPlanet
    {
        public string planet { get; set; }
        public string rel { get; set; }
    }

    public class Body
    {
        public string id { get; set; }
        public string name { get; set; }
        public string englishName { get; set; }
        public bool isPlanet { get; set; }
        public List<Moon> moons { get; set; }
        public int semimajorAxis { get; set; }
        public int perihelion { get; set; }
        public int aphelion { get; set; }
        public int eccentricity { get; set; }
        public int inclination { get; set; }
        public Mass mass { get; set; }
        public Vol vol { get; set; }
        public int density { get; set; }
        public int gravity { get; set; }
        public int escape { get; set; }
        public int meanRadius { get; set; }
        public int equaRadius { get; set; }
        public int polarRadius { get; set; }
        public int flattening { get; set; }
        public string dimension { get; set; }
        public int sideralOrbit { get; set; }
        public int sideralRotation { get; set; }
        public AroundPlanet aroundPlanet { get; set; }
        public string discoveredBy { get; set; }
        public string discoveryDate { get; set; }
        public string alternativeName { get; set; }
        public int axialTilt { get; set; }
        public int avgTemp { get; set; }
        public int mainAnomaly { get; set; }
        public int argPeriapsis { get; set; }
        public int longAscNode { get; set; }
        public string bodyType { get; set; }
        public string rel { get; set; }
    }

    public class Mass
    {
        public int massValue { get; set; }
        public int massExponent { get; set; }
    }

    public class Moon
    {
        public string moon { get; set; }
        public string rel { get; set; }
    }

    

    public class Vol
    {
        public int volValue { get; set; }
        public int volExponent { get; set; }
    }
