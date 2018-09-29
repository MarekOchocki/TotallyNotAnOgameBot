using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallyNotAnOgameBot.Data.Resource
{
    class Energy
    {
        private long value;

        public Energy(long energyValue = 0)
        {
            value = energyValue;
        }

        public long getValue()
        {
            return value;
        }

        public void setValue(long energyValue)
        {
            value = energyValue;
        }
    }
}
