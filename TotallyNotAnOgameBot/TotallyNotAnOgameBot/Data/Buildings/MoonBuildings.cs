using System;

namespace TotallyNotAnOgameBot.Data.Buildings
{
    public class MoonBuildings
    {
        public Building LunarBase;
        public Building SensorPhalanx;
        public Building JumpGate;
        public Building MoonMetalStorage;
        public Building MoonCrystalStorage;
        public Building MoonDeuteriumTank;
        public Building MoonRoboticsFactory;
        public Building MoonShipyard;
        public Building MoonAllianceDepot;

        public MoonBuildings()
        {
            LunarBase = new Building(Building.Type.LunarBase, 0);
            SensorPhalanx = new Building(Building.Type.SensorPhalanx, 0);
            JumpGate = new Building(Building.Type.JumpGate, 0);
            MoonRoboticsFactory = new Building(Building.Type.MoonRoboticsFactory, 0);
            MoonShipyard = new Building(Building.Type.MoonShipyard, 0);
            MoonMetalStorage = new Building(Building.Type.MoonMetalStorage, 0);
            MoonCrystalStorage = new Building(Building.Type.MoonCrystalStorage, 0);
            MoonDeuteriumTank = new Building(Building.Type.MoonDeuteriumTank, 0);
            MoonAllianceDepot = new Building(Building.Type.MoonAllianceDepot, 0);
        }

        public void setBuildingLevel(Building.Type type, int level)
        {
            if (type == Building.Type.LunarBase)
            {
                LunarBase.setLevel(level);
            }
            else if (type == Building.Type.SensorPhalanx)
            {
                SensorPhalanx.setLevel(level);
            }
            else if (type == Building.Type.JumpGate)
            {
                JumpGate.setLevel(level);
            }
            else if (type == Building.Type.MoonRoboticsFactory)
            {
                MoonRoboticsFactory.setLevel(level);
            }
            else if (type == Building.Type.MoonShipyard)
            {
                MoonShipyard.setLevel(level);
            }
            else if (type == Building.Type.MoonMetalStorage)
            {
                MoonMetalStorage.setLevel(level);
            }
            else if (type == Building.Type.MoonCrystalStorage)
            {
                MoonCrystalStorage.setLevel(level);
            }
            else if (type == Building.Type.MoonDeuteriumTank)
            {
                MoonDeuteriumTank.setLevel(level);
            }
            else if(type == Building.Type.MoonAllianceDepot)
            {
                MoonAllianceDepot.setLevel(level);
            }
            else
                throw new Exception();
        }
    }
}
