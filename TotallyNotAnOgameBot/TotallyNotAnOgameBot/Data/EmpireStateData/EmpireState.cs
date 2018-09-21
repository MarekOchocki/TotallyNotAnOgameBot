using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotallyNotAnOgameBot.Data.Resarch;
using TotallyNotAnOgameBot.Exceptions;

namespace TotallyNotAnOgameBot.Data.EmpireStateData
{
    class EmpireState
    {
        public ResarchState resarch;
        public int amountOfPlanets;
        public PlanetState[] planets;

        public EmpireState(int planetQuantity)
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
        }
    }
}
