using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotallyNotAnOgameBot.Data.Resarch;
using TotallyNotAnOgameBot.Data.Buildings;

namespace TotallyNotAnOgameBot.Data.TechnologyRequirements
{
    class TechRequirements
    {
        public ResarchState resarchState;
        public StationBuildings stationBuildings;
        public ProductionBuildings productionBuildings;
        public MoonBuildings moonBuildings;

        public TechRequirements()
        {
            resarchState = new ResarchState();
            stationBuildings = new StationBuildings();
            productionBuildings = new ProductionBuildings();
            moonBuildings = new MoonBuildings();
        }

    }
}
