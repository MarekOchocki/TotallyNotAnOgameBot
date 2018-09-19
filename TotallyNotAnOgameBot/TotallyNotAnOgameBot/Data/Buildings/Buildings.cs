using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotallyNotAnOgameBot.Exceptions;

namespace TotallyNotAnOgameBot.Data.Buildings
{
    class Building
    {
        public enum Type {MetalMine, CrystalMine, DeuteriumSynthesizer, SolarPlant, FusionReactor, SolarSatelite,
        MetalStorge, CrystalStorge, DeuteriumTank, RoboticsFactory, Shipyard, ResarchLab, AllianceDepot, MissileSilo,
        NaniteFactory, Terraformer, SpaceDock, LunarBase, SensorPhalanx, JumpGate}

        private int level;
        private readonly Type type;

        public Building(Type buildingType, int buildingLevel)
        {
            type = buildingType;
            if (buildingLevel >= 0)
            {
                level = buildingLevel;
            }
            else
            {
                throw new LessThanZeroException();
            }
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
            if (value >= 0)
            {
                level = value;
            }else
            {
                throw new LessThanZeroException();
            }
        }

        public void addLevel(int value)
        {
            level += value;
        }

        public void substractLevel(int value)
        {
            if ((level - value) >= 0)
            {
                level -= value;
            }else
            {
                throw new LessThanZeroException();
            }
        }
    }
}
