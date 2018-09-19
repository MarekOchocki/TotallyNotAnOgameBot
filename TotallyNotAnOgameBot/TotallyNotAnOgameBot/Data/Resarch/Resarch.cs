using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotallyNotAnOgameBot.Exceptions;

namespace TotallyNotAnOgameBot.Data.Resarch
{
    class Resarch
    {
        public enum Type {EnergyTechnology, LaserTechnology, IonTechnology, HyperspaceTechnology, PlasmaTechnology,
        EspionageTechnology, ComputerTechnology, Astrophysics, IntergalacticResearchNetwork, GravitonTechnology,
        WeaponsTechnology, ShieldingTechnology, ArmourTechnology, CombustionDrive, ImpulseDrive, HyperspaceDrive}

        private int level;
        private readonly Type type;

        public Resarch(Type resarchType, int resarchLevel = 0)
        {
            type = resarchType;
            if (resarchLevel < 0)
            {
                throw new LessThanZeroException();
            }
            level = resarchLevel;
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
