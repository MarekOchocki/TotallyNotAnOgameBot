using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotallyNotAnOgameBot.Exceptions;

namespace TotallyNotAnOgameBot.Data.Defenses
{
    public class Defense
    {
        public enum Type {RocletLauncher, LightLaser, HeavyLaser, GaussCannon, IonCannon, PlasmaTurret,
        SmallShieldDome, LargeShieldDome, AntiBalisticMissiles, InterplanetaryMissiles}

        private readonly Type type;
        private int quantity;

        public Defense(Type defenseType, int defenseQuantity)
        {
            type = defenseType;
            if (defenseQuantity < 0)
            {
                throw new LessThanZeroException();
            }
            quantity = defenseQuantity;
        }

        public Type getType()
        {
            return type;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public void setQuantity(int value)
        {
            if (value < 0)
            {
                throw new LessThanZeroException();
            }
            quantity = value;
        }

        public void addQuantity(int value)
        {
            quantity += value;
        }

        public void substractQuantity(int value)
        {
            if ((quantity - value) < 0)
            {
                throw new LessThanZeroException();
            }
            quantity -= value;
        }
    }
}
