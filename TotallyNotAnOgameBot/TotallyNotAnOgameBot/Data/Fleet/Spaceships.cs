using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotallyNotAnOgameBot.Exceptions;

namespace TotallyNotAnOgameBot.Data.Fleet
{
    class Spaceships
    {
        public enum Type {SmallCargo, LargeCargo, ColonyShip, Recykler, EspionageProbe, SolarSatelite,  LightFighter,
            HeavyFighter, Crusier, Battleship, Battlecrusier, Bomber, Destroyer, Deathstar};

        private readonly Type type;
        private long quantity;

        public Spaceships(Type spaceshipType, long spaceshipQuantity)
        {
            type = spaceshipType;
            if (spaceshipQuantity < 0)
            {
                throw new LessThanZeroException();
            }
                quantity = spaceshipQuantity;

        }

        public Type getType()
        {
            return type;
        }

        public long getQuantity()
        {
            return quantity;
        }

        public void setQuantity(long value)
        {
            if (value < 0)
            {
                throw new LessThanZeroException();
            }
            quantity = value;
        }

        public void addQuantity(long value)
        {
            quantity += value;
        }

        public void substractQuantity(long value)
        {
            if((quantity - value) < 0 )
            {
                throw new LessThanZeroException();
                
            }
            quantity -= value;
        }
    }
}
