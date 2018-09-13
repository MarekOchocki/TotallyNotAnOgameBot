using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallyNotAnOgameBot.Data.Resource
{
    class Energy
    {
        private long usage;
        private long production;

        public Energy(long energyUsage = 0, long energyProduction = 0)
        {
            usage = energyUsage;
            production = energyProduction;
        }

        public long getUsage()
        {
            return usage;
        }

        public long getProduction()
        {
            return production;
        }

        public void setUsage(long value)
        {
            usage = value;
        }

        public void setProduction(int value)
        {
            production = value;
        }

        public long getEnergy()
        {
            return (getProduction() - getUsage());
        }
    }
}
