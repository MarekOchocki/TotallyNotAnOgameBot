using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallyNotAnOgameBot.Data.Fleet
{
    class Spaceships
    {
        public enum Type {LightFighter, HeavyFighter, Crusier, Battleship, Battlecrusier, Bomber, Destroyer, Deathstar};

        private Type type;
        private long quantity;

        public Spaceships(Type spaceshipType, long spaceshipQuantity)
        {
            type = spaceshipType;
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
            quantity = value;
        }

        public void addQuantity(long value)
        {
            quantity += value;
        }

        public void substractQuantity(long value)
        {
            quantity -= value;
        }
    }
}
