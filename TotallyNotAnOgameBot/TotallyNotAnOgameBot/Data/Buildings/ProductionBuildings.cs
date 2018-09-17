using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallyNotAnOgameBot.Data.Buildings
{
    class ProductionBuildings
    {
        public Buildings MetalMine;
        public Buildings CrystalMine;
        public Buildings DeuteriumSynthesizer;
        public Buildings SolarPlant;
        public Buildings FusionReactor;
        public Buildings SolarSatelite;
        public Buildings MetalStorge;
        public Buildings CrystalStorge;
        public Buildings DeuteriumTank;

        public ProductionBuildings()
        {
            MetalMine = new Buildings(Buildings.Type.MetalMine, 0);
            CrystalMine = new Buildings(Buildings.Type.CrystalMine, 0);
            DeuteriumSynthesizer = new Buildings(Buildings.Type.DeuteriumSynthesizer, 0);
            SolarPlant = new Buildings(Buildings.Type.SolarPlant, 0);
            FusionReactor = new Buildings(Buildings.Type.FusionReactor, 0);
            SolarSatelite = new Buildings(Buildings.Type.SolarSatelite, 0);
            MetalStorge = new Buildings(Buildings.Type.MetalStorge, 0);
            CrystalStorge = new Buildings(Buildings.Type.CrystalStorge, 0);
            DeuteriumTank = new Buildings(Buildings.Type.DeuteriumTank, 0);
        }

        public void add(ProductionBuildings otherProductionBuildings)
        {
            MetalMine.addLevel(otherProductionBuildings.MetalMine.getLevel());
            CrystalMine.addLevel(otherProductionBuildings.CrystalMine.getLevel());
            DeuteriumSynthesizer.addLevel(otherProductionBuildings.DeuteriumSynthesizer.getLevel());
            SolarPlant.addLevel(otherProductionBuildings.SolarPlant.getLevel());
            FusionReactor.addLevel(otherProductionBuildings.FusionReactor.getLevel());
            SolarSatelite.addLevel(otherProductionBuildings.SolarSatelite.getLevel());
            MetalStorge.addLevel(otherProductionBuildings.MetalStorge.getLevel());
            CrystalStorge.addLevel(otherProductionBuildings.CrystalStorge.getLevel());
            DeuteriumTank.addLevel(otherProductionBuildings.DeuteriumTank.getLevel());
        }

        public void substract(ProductionBuildings otherProductionBuildings)
        {
            MetalMine.substractLevel(otherProductionBuildings.MetalMine.getLevel());
            CrystalMine.substractLevel(otherProductionBuildings.CrystalMine.getLevel());
            DeuteriumSynthesizer.substractLevel(otherProductionBuildings.DeuteriumSynthesizer.getLevel());
            SolarPlant.substractLevel(otherProductionBuildings.SolarPlant.getLevel());
            FusionReactor.substractLevel(otherProductionBuildings.FusionReactor.getLevel());
            SolarSatelite.substractLevel(otherProductionBuildings.SolarSatelite.getLevel());
            MetalStorge.substractLevel(otherProductionBuildings.MetalStorge.getLevel());
            CrystalStorge.substractLevel(otherProductionBuildings.CrystalStorge.getLevel());
            DeuteriumTank.substractLevel(otherProductionBuildings.DeuteriumTank.getLevel());
        }
    }
}
