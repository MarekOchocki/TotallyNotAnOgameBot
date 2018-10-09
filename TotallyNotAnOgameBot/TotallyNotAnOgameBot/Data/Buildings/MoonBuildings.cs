using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallyNotAnOgameBot.Data.Buildings
{
    public class MoonBuildings
    {
        public Building LunarBase;
        public Building SensorPhalanx;
        public Building JumpGate;
        public Building MetalStorage;
        public Building CrystalStorage;
        public Building DeuteriumTank;
        public Building RoboticsFactory;
        public Building Shipyard;
        public Building AllianceDepot;

        public MoonBuildings()
        {
            LunarBase = new Building(Building.Type.LunarBase, 0);
            SensorPhalanx = new Building(Building.Type.SensorPhalanx, 0);
            JumpGate = new Building(Building.Type.JumpGate, 0);
            RoboticsFactory = new Building(Building.Type.RoboticsFactory, 0);
            Shipyard = new Building(Building.Type.Shipyard, 0);
            AllianceDepot = new Building(Building.Type.AllianceDepot, 0);
            MetalStorage = new Building(Building.Type.MetalStorage, 0);
            CrystalStorage = new Building(Building.Type.CrystalStorage, 0);
            DeuteriumTank = new Building(Building.Type.DeuteriumTank, 0);
        }
    }
}
