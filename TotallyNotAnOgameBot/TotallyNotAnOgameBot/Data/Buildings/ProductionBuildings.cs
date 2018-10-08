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
        public Building SolarSatelite;
        public Building MetalStorge;
        public Building CrystalStorge;
        public Building DeuteriumTank;

        public ProductionBuildings()
        {
            MetalMine = new Building(Building.Type.MetalMine, 0);
            CrystalMine = new Building(Building.Type.CrystalMine, 0);
            DeuteriumSynthesizer = new Building(Building.Type.DeuteriumSynthesizer, 0);
            SolarPlant = new Building(Building.Type.SolarPlant, 0);
            FusionReactor = new Building(Building.Type.FusionReactor, 0);
            SolarSatelite = new Building(Building.Type.SolarSatelite, 0);
            MetalStorge = new Building(Building.Type.MetalStorge, 0);
            CrystalStorge = new Building(Building.Type.CrystalStorge, 0);
            DeuteriumTank = new Building(Building.Type.DeuteriumTank, 0);
        }
    }
}
