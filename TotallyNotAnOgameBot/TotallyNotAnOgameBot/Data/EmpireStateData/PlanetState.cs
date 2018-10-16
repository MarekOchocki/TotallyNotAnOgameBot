using TotallyNotAnOgameBot.Data.Resource;
using TotallyNotAnOgameBot.Data.FleetData;
using TotallyNotAnOgameBot.Data.Defenses;
using TotallyNotAnOgameBot.Data.Buildings;

namespace TotallyNotAnOgameBot.Data.EmpireStateData
{
    public class PlanetState
    {
        public Resources resources;
        public Fleet fleet;
        public DefenseState defense;
        public MoonState moon;
        public ProductionBuildings production;
        public StationBuildings station;
        public string name;

        public PlanetState(string planetName = "Colony")
        {
            resources = new Resources();
            fleet = new Fleet();
            defense = new DefenseState();
            moon = new MoonState();
            production = new ProductionBuildings();
            station = new StationBuildings();
            name = planetName;
        }
    }
}
