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


        public PlanetLocation(int planetNumber, int systemNumber, int galaxyNumber)
        {
            if ((planetNumber < 0) || (planetNumber > 15))
                throw new ArgumentOutOfRangeException("less than 0 or more than 15");
            if ((systemNumber < 0) || (systemNumber > 499))
                throw new ArgumentOutOfRangeException("less than 0 or more than 499");
            if ((galaxyNumber < 0) || (galaxyNumber > 7))
                throw new ArgumentOutOfRangeException("less than 0 or more than 8");

            this.planetNumber = planetNumber;
            this.galaxyNumber = galaxyNumber;
            this.systemNumber = systemNumber;
        }
    }
}
