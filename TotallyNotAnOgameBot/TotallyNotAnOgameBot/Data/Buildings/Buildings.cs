using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallyNotAnOgameBot.Data.Buildings
{
    class Buildings
    {
        public enum Type {MetalMine, CrystalMine, DeuteriumSynthesizer, SolarPlant, FusionReactor, SolarSatelite,
        MetalStorge, CrystalStorge, DeuteriumTank, RoboticsFactory, Shipyard, ResarchLab, AllianceDepot, MissileSilo,
        NaniteFactory, Terraformer, SpaceDock, LunarBase, SensorPhalanx, JumpGate}

        private int level;
        private readonly Type type;

        public Buildings(Type buildingType, int buildingLevel)
        {
            type = buildingType;
            level = buildingLevel;
        }

        public Type getType()
        {
            return type;
        }

        public int getLevel()
        {
            return level;
        }

        public void setLevel(int value)
        {
            level = value;
        }

        public void addLevel(int value)
        {
            level += value;
        }

        public void substractLevel(int value)
        {
            level -= value;
        }
    }
}
