using TotallyNotAnOgameBot.Data.ResearchData;
using TotallyNotAnOgameBot.Exceptions;

namespace TotallyNotAnOgameBot.Data.EmpireStateData
{
    public class EmpireState
    {
        public ResearchState research;
        public int amountOfPlanets;
        public PlanetState[] planets;

        public EmpireState(int planetQuantity = 1)
        {
            if(planetQuantity < 0)
            {
                throw new LessThanZeroException();
            }else if(planetQuantity == 0)
            {
                throw new EqualZeroException();
            }
            amountOfPlanets = planetQuantity;
            planets = new PlanetState[planetQuantity];
            research = new ResearchState();
        }
    }
}
