using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotallyNotAnOgameBot.Data.Resource;

namespace TotallyNotAnOgameBot.Calculations
{
    class Cost
    {
        public Resources resources;
        public Energy energy;

        public Cost(long metalValue = 0, long crystalValue = 0, long deuterValue = 0, long energyValue = 0)
        {
            if (metalValue < 0 || crystalValue < 0 || deuterValue < 0 || energyValue < 0)
                throw new ArgumentException();
            resources = new Resources(metalValue, crystalValue, deuterValue);
            energy = new Energy(energyValue);
        }

        public void multiplication(double number)
        {
            double metalValue = resources.getMetalQuantity() * number;
            double crystalValue = resources.getCrystalQuantity() * number;
            double deuterValue = resources.getDeuterQuantity() * number;
            double energyValue = energy.getValue() * number;
        }
    }
}
