from Resource_Class import Resource
from Resource_Class import ResourceType

class Resources:
    def __init__(self, metalValue = 0, crystalValue = 0, deuterValue = 0):
        self.metal = Resource(ResourceType.Metal)
        self.metal.setQuantity(metalValue)

        self.crystal = Resource(ResourceType.Crystal)
        self.crystal.setQuantity(crystalValue)

        self.deuter = Resource(ResourceType.Deuter)
        self.deuter.setQuantity(deuterValue)

    def getMetalQuantity(self):
        return self.metal.getQuantity()

    def getCrystalQuantity(self):
        return self.crystal.getQuantity()

    def getDeuterQuantity(self):
        return self.deuter.getQuantity()

    def setResources(self, metalValue, crystalValue, deuterValue):
        self.metal.setQuantity(metalValue)
        self.crystal.setQuantity(crystalValue)
        self.deuter.setQuantity(deuterValue)

    def add(self, otherResources):
        self.metal.add(otherResources.metal)
        self.crystal.add(otherResources.crystal)
        self.deuter.add(otherResources.deuter)

    def substract(self, otherResources):
        self.metal.substract(otherResources.metal)
        self.crystal.substract(otherResources.crystal)
        self.deuter.substract(otherResources.deuter)

    def addResource(self, resource):
        if resource.resourceType == ResourceType.Metal:
            self.metal.add(resource)
        elif resource.resourceType == ResourceType.Crystal:
            self.crystal.add(resource)
        elif resource.resourceType == ResourceType.Deuter:
            self.deuter.add(resource)

    def substractResource(self, resource):
        if resource.resourceType == ResourceType.Metal:
            self.metal.substract(resource)
        elif resource.resourceType == ResourceType.Crystal:
            self.crystal.substract(resource)
        elif resource.resourceType == ResourceType.Deuter:
            self.deuter.substract(resource)
