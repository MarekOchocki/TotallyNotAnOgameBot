using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotallyNotAnOgameBot.Data.Research;
using TotallyNotAnOgameBot.Data.Buildings;

namespace TotallyNotAnOgameBot.Data.TechnologyRequirements
{
    class TechRequirements
    {
        public ResearchState researchState;
        public StationBuildings stationBuildings;
        public ProductionBuildings productionBuildings;
        public MoonBuildings moonBuildings;

        public TechRequirements()
        {
            researchState = new ResearchState();
            stationBuildings = new StationBuildings();
            productionBuildings = new ProductionBuildings();
            moonBuildings = new MoonBuildings();
        }

    }
}
