using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallyNotAnOgameBot.Data.Buildings
{
    class MoonBuildings
    {
        public Buildings LunarBase;
        public Buildings SensorPhalanx;
        public Buildings JumpGate;
        public Buildings MetalStorge;
        public Buildings CrystalStorge;
        public Buildings DeuteriumTank;
        public Buildings RoboticsFactory;
        public Buildings Shipyard;
        public Buildings AllianceDepot;

        public MoonBuildings()
        {
            LunarBase = new Buildings(Buildings.Type.LunarBase, 0);
            SensorPhalanx = new Buildings(Buildings.Type.SensorPhalanx, 0);
            JumpGate = new Buildings(Buildings.Type.JumpGate, 0);
            RoboticsFactory = new Buildings(Buildings.Type.RoboticsFactory, 0);
            Shipyard = new Buildings(Buildings.Type.Shipyard, 0);
            AllianceDepot = new Buildings(Buildings.Type.AllianceDepot, 0);
            MetalStorge = new Buildings(Buildings.Type.MetalStorge, 0);
            CrystalStorge = new Buildings(Buildings.Type.CrystalStorge, 0);
            DeuteriumTank = new Buildings(Buildings.Type.DeuteriumTank, 0);
        }

        public void add(MoonBuildings otherMoonBuildings)
        {
            LunarBase.addLevel(otherMoonBuildings.LunarBase.getLevel());
            SensorPhalanx.addLevel(otherMoonBuildings.SensorPhalanx.getLevel());
            JumpGate.addLevel(otherMoonBuildings.SensorPhalanx.getLevel());
            RoboticsFactory.addLevel(otherMoonBuildings.RoboticsFactory.getLevel());
            Shipyard.addLevel(otherMoonBuildings.Shipyard.getLevel());
            AllianceDepot.addLevel(otherMoonBuildings.AllianceDepot.getLevel());
            MetalStorge.addLevel(otherMoonBuildings.MetalStorge.getLevel());
            CrystalStorge.addLevel(otherMoonBuildings.CrystalStorge.getLevel());
            DeuteriumTank.addLevel(otherMoonBuildings.DeuteriumTank.getLevel());
        }

        public void substract(MoonBuildings otherMoonBuildings)
        {
            LunarBase.substractLevel(otherMoonBuildings.LunarBase.getLevel());
            SensorPhalanx.substractLevel(otherMoonBuildings.SensorPhalanx.getLevel());
            JumpGate.substractLevel(otherMoonBuildings.SensorPhalanx.getLevel());
            RoboticsFactory.substractLevel(otherMoonBuildings.RoboticsFactory.getLevel());
            Shipyard.substractLevel(otherMoonBuildings.Shipyard.getLevel());
            AllianceDepot.substractLevel(otherMoonBuildings.AllianceDepot.getLevel());
            MetalStorge.substractLevel(otherMoonBuildings.MetalStorge.getLevel());
            CrystalStorge.substractLevel(otherMoonBuildings.CrystalStorge.getLevel());
            DeuteriumTank.substractLevel(otherMoonBuildings.DeuteriumTank.getLevel());
        }
    }
}
