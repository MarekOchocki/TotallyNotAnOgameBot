using TotallyNotAnOgameBot.Exceptions;

namespace TotallyNotAnOgameBot.Data.Buildings
{
    public class Building
    {
        public enum Type {MetalMine, CrystalMine, DeuteriumSynthesizer, SolarPlant, FusionReactor,
        MetalStorage, CrystalStorage, DeuteriumTank, RoboticsFactory, Shipyard, ResarchLab, AllianceDepot, MissileSilo,
        NaniteFactory, Terraformer, SpaceDock, LunarBase, SensorPhalanx, JumpGate, MoonRoboticsFactory, MoonShipyard,
        MoonMetalStorage, MoonCrystalStorage, MoonDeuteriumTank, MoonAllianceDepot}

        private int level;
        private readonly Type type;

        public Building(Type buildingType, int buildingLevel)
        {
            type = buildingType;
            if (buildingLevel < 0)
            {
                throw new LessThanZeroException();
            }
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
            if (value < 0)
            {
                throw new LessThanZeroException();
            }
            level = value;
        }

        public void addLevel(int value)
        {
            level += value;
        }

        public void substractLevel(int value)
        {
            if ((level - value) < 0)
            {
                throw new LessThanZeroException();
            }
            level -= value;
        }
    }
}
