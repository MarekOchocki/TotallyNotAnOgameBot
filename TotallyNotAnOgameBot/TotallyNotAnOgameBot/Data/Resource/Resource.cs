using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotallyNotAnOgameBot.Exceptions;

namespace TotallyNotAnOgameBot.Data.Resource
{
    public class Resource
    {
        public enum Type { Metal, Crystal, Deuter };

        private long quantity;
        private readonly Type type;

        public Resource(Type resourceType, long resourceQuantity = 0)
        {
            type = resourceType;
            if (resourceQuantity < 0)
            {
                throw new LessThanZeroException();
            }
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
            if (value < 0)
            {
                throw new LessThanZeroException();
            }
            quantity = value;

        }

        public void addQuantity(Resource otherResource)
        {
            quantity += otherResource.getQuantity();
        }

        public void substractQuantity(Resource otherResource)
        {
            if((quantity - otherResource.getQuantity() ) < 0)
            {
                throw new LessThanZeroException();
            }
            quantity -= otherResource.getQuantity();
        }
    }
}
