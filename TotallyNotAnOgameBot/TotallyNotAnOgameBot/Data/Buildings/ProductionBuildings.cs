using System;

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

        public void setBuildingLevel(Building.Type type, int level)
        {
            if (type == Building.Type.MetalMine)
            {
                MetalMine.setLevel(level);
            }
            else if (type == Building.Type.CrystalMine)
            {
                CrystalMine.setLevel(level);
            }
            else if (type == Building.Type.DeuteriumSynthesizer)
            {
                DeuteriumSynthesizer.setLevel(level);
            }
            else if (type == Building.Type.SolarPlant)
            {
                SolarPlant.setLevel(level);
            }
            else if (type == Building.Type.FusionReactor)
            {
                FusionReactor.setLevel(level);
            }
            else if (type == Building.Type.MetalStorage)
            {
                MetalStorage.setLevel(level);
            }
            else if (type == Building.Type.CrystalStorage)
            {
                CrystalStorage.setLevel(level);
            }
            else if (type == Building.Type.DeuteriumTank)
            {
                DeuteriumTank.setLevel(level);
            }
            else
                throw new Exception();
        }
    }
}
