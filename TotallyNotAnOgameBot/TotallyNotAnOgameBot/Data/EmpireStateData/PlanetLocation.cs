using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallyNotAnOgameBot.Data.EmpireStateData
{
    class PlanetLocation
    {
        public readonly int planetNumber;
        public readonly int galaxyNumber;
        public readonly int systemNumber;


        public PlanetLocation(int galaxyNumber, int systemNumber, int planetNumber)
        {
            if ((planetNumber < 1) || (planetNumber > 15))
                throw new ArgumentOutOfRangeException("less than 1 or more than 15");
            if ((systemNumber < 1) || (systemNumber > 499))
                throw new ArgumentOutOfRangeException("less than 1 or more than 499");
            if ((galaxyNumber < 1) || (galaxyNumber > 7))
                throw new ArgumentOutOfRangeException("less than 1 or more than 7");

            this.planetNumber = planetNumber;
            this.galaxyNumber = galaxyNumber;
            this.systemNumber = systemNumber;
        }
    }
}
