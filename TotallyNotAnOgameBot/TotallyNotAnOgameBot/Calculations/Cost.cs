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
            resources = new Resources(metalValue, crystalValue, deuterValue);
            energy = new Energy(energyValue);
        }

        public void rbMultiplication(double multipler, int level)
        {
            double metalValue = resources.getMetalQuantity();
            metalValue = metalValue * Math.Pow(multipler, level);
            double crystalValue = resources.getCrystalQuantity();
            crystalValue = Math.Pow(multipler, level) * crystalValue;
            double deuterValue = resources.getDeuterQuantity();
            deuterValue = Math.Pow(multipler, level) * deuterValue;
            double energyValue = energy.getValue();
            energyValue = Math.Pow(multipler, level) * energyValue;

            resources.setResources((long)metalValue, (long)crystalValue, (long)deuterValue);
            energy.setValue((long)energyValue);
        }

        public void dsMultiplication(int quantity)
        {
            double metalValue = resources.getMetalQuantity() * quantity;
            double crystalValue = resources.getCrystalQuantity() * quantity;
            double deuterValue = resources.getDeuterQuantity() * quantity;

            resources.setResources((long)metalValue, (long)crystalValue, (long)deuterValue);
        }
    }
}
