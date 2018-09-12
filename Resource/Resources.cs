using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotallyNotAnOgameBot.Data.Resource
{
    class Resources
    {
        private Resource metal = new Resource(Resource.Type.Metal);
        private Resource crystal = new Resource(Resource.Type.Crystal);
        private Resource deuter = new Resource(Resource.Type.Deuter);

        public Resources(long metalValue = 0, long crystalValue = 0, long deuterValue = 0)
        {
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
            metal.substract(otherResources.metal);
            crystal.substract(otherResources.crystal);
            deuter.substract(otherResources.deuter);
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
                metal.substract(resource);
            else if (resource.getType() == Resource.Type.Crystal)
                crystal.substract(resource);
            else if (resource.getType() == Resource.Type.Deuter)
                deuter.substract(resource);
        }
    }
}
