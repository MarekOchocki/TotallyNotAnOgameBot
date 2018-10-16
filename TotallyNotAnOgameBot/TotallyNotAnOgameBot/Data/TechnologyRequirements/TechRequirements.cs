using System;
using TotallyNotAnOgameBot.Data.ResearchData;
using TotallyNotAnOgameBot.Data.Buildings;

namespace TotallyNotAnOgameBot.Data.TechnologyRequirements
{
    public class TechRequirements
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

        public TechRequirements addRequirement(Building.Type building, int level )
        {
            if ((int)building <= 7)
            {
                productionBuildings.setBuildingLevel(building, level);
            }
            else if ((int)building <= 15)
            {
                stationBuildings.setBuildingLevel(building, level);
            }
            else if ((int)building <= 24)
            {
                moonBuildings.setBuildingLevel(building, level);
            }
            else
                throw new Exception();

            return this;
        }

        public TechRequirements addRequirement(Research.Type research, int level)
        {
            researchState.setResearchLevel(research, level);
            return this;
        }
    }
}
