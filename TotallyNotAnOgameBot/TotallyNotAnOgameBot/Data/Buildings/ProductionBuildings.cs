using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallyNotAnOgameBot.Data.Buildings
{
    public class ProductionBuildings
    {
        public Building MetalMine;
        public Building CrystalMine;
        public Building DeuteriumSynthesizer;
        public Building SolarPlant;
        public Building FusionReactor;
        public Building MetalStorage;
        public Building CrystalStorage;
        public Building DeuteriumTank;

        public ProductionBuildings()
        {
            MetalMine = new Building(Building.Type.MetalMine, 0);
            CrystalMine = new Building(Building.Type.CrystalMine, 0);
            DeuteriumSynthesizer = new Building(Building.Type.DeuteriumSynthesizer, 0);
            SolarPlant = new Building(Building.Type.SolarPlant, 0);
            FusionReactor = new Building(Building.Type.FusionReactor, 0);
            MetalStorage = new Building(Building.Type.MetalStorage, 0);
            CrystalStorage = new Building(Building.Type.CrystalStorage, 0);
            DeuteriumTank = new Building(Building.Type.DeuteriumTank, 0);
        }
    }
}
