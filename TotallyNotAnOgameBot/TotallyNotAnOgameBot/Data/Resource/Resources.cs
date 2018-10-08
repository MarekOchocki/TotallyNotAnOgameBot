using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallyNotAnOgameBot.Data.Resource
{
    public class Resources
    {
        private Resource metal;
        private Resource crystal;
        private Resource deuter;

        public Resources(long metalValue = 0, long crystalValue = 0, long deuterValue = 0)
        {
            metal = new Resource(Resource.Type.Metal);
            crystal = new Resource(Resource.Type.Crystal);
            deuter = new Resource(Resource.Type.Deuter);
            metal.setQuantity(metalValue);
            crystal.setQuantity(crystalValue);
            deuter.setQuantity(deuterValue);
        }

        public long getMetalQuantity()
        {
            return metal.getQuantity();
        }

        public long getCrystalQuantity()
        {
            return crystal.getQuantity();
        }

        public long getDeuterQuantity()
        {
            return deuter.getQuantity();
        }

        public void setResources(long metalValue,long crystalValue,long deuterValue)
        {
            metal.setQuantity(metalValue);
            crystal.setQuantity(crystalValue);
            deuter.setQuantity(deuterValue);
        }

        public void add(Resources otherResources)
        {
            metal.addQuantity(otherResources.metal);
            crystal.addQuantity(otherResources.crystal);
            deuter.addQuantity(otherResources.deuter);
        }

        public void substract(Resources otherResources)
        {
            metal.substractQuantity(otherResources.metal);
            crystal.substractQuantity(otherResources.crystal);
            deuter.substractQuantity(otherResources.deuter);
        }

        public void addResource(Resource resource)
        {
            if (resource.getType() == Resource.Type.Metal)
                metal.addQuantity(resource);
            else if (resource.getType() == Resource.Type.Crystal)
                crystal.addQuantity(resource);
            else if (resource.getType() == Resource.Type.Deuter)
                deuter.addQuantity(resource);
        }

        public void substractResource(Resource resource)
        {
            if (resource.getType() == Resource.Type.Metal)
                metal.substractQuantity(resource);
            else if (resource.getType() == Resource.Type.Crystal)
                crystal.substractQuantity(resource);
            else if (resource.getType() == Resource.Type.Deuter)
                deuter.substractQuantity(resource);
        }
    }
}
