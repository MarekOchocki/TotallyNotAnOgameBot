using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallyNotAnOgameBot.Data.EmpireStateData
{
    class PlanetLocation
    {
        private readonly int planetNumber;
        private readonly int galaxyNumber;
        private readonly int systemNumber;


        public PlanetLocation(int planetNumber, int systemNumber, int galaxyNumber)
        {
            this.planetNumber = planetNumber;
            this.galaxyNumber = galaxyNumber;
            this.systemNumber = systemNumber;
        }

        public int getPlanetNumber()
        {
            return planetNumber;
        }

        public int getGalaxyNumber()
        {
            return galaxyNumber;
        }

        public int getSystemNumber()
        {
            return systemNumber;
        }
    }
}
