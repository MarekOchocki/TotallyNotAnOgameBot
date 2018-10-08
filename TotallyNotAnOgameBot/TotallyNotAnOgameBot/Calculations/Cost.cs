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

        public void multiply(double multiplier)
        {
            double metalValue = resources.getMetalQuantity() * multiplier;
            double crystalValue = resources.getCrystalQuantity() * multiplier;
            double deuterValue = resources.getDeuterQuantity() * multiplier;
            double energyValue = energy.getValue() * multiplier;

            resources.setResources((long)metalValue, (long)crystalValue, (long)deuterValue);
            energy.setValue((long)energyValue);
        }
    }
}
