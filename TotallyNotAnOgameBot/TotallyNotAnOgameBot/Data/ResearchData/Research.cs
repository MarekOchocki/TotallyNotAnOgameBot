using TotallyNotAnOgameBot.Exceptions;

namespace TotallyNotAnOgameBot.Data.ResearchData
{
    public class Research
    {
        public enum Type {EnergyTechnology, LaserTechnology, IonTechnology, HyperspaceTechnology, PlasmaTechnology,
        EspionageTechnology, ComputerTechnology, Astrophysics, IntergalacticResearchNetwork, GravitonTechnology,
        WeaponsTechnology, ShieldingTechnology, ArmourTechnology, CombustionDrive, ImpulseDrive, HyperspaceDrive}

        private int level;
        private readonly Type type;

        public Research(Type researchType, int researchLevel = 0)
        {
            type = researchType;
            if (researchLevel < 0)
            {
                throw new LessThanZeroException();
            }
            level = researchLevel;
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
            if (level - value < 0)
            {
                throw new LessThanZeroException();
            }
            level -= value;
        }
    }
}
