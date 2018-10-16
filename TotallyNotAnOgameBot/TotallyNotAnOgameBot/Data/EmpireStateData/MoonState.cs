using TotallyNotAnOgameBot.Data.Buildings;
using TotallyNotAnOgameBot.Data.Defenses;
using TotallyNotAnOgameBot.Data.Resource;
using TotallyNotAnOgameBot.Data.FleetData;

namespace TotallyNotAnOgameBot.Data.EmpireStateData
{
    public class MoonState
    {
        public MoonBuildings moonBuilding;
        public Resources moonResources;
        public Fleet moonFleet;
        public DefenseState moonDefenses;

        public MoonState()
        {
            moonBuilding = new MoonBuildings();
            moonResources = new Resources();
            moonFleet = new Fleet();
            moonDefenses = new DefenseState();
        }
    }
}
