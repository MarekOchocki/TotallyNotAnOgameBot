using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallyNotAnOgameBot.Data.Resource
{
    class Resource
    {
        public enum Type { Metal, Crystal, Deuter };
        private long quantity = 0;
        private Type type;

        public Resource(Type resourceType, long resourceQuantity = 0)
        {
            type = resourceType;
            quantity = resourceQuantity;
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

        public void addQuantity(Resource otherResource)
        {
            quantity += otherResource.getQuantity();
        }

        public void substract(Resource otherResource)
        {
            quantity -= otherResource.getQuantity();
        }
    }

}
