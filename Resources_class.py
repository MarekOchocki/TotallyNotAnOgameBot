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


    def getMetalValue(self):
        return self.metal.getQuantity()

    def getCrystalValue(self):
        return self.crystal.getQuantity()

    def getDeuterValue(self):
        return self.deuter.getQuantity()

    def setResources(self, metalValue, crystalValue , deuterValue):
        self.metal.setQuantity(metalValue)
        self.crystal.setQuantity(crystalValue)
        self.deuter.setQuantity(deuterValue)

    def add(self, otherResourcesObject):
        self.metal.add(otherResourcesObject.getMetal())
        self.crystal.add(otherResourcesObject.getCrystal())
        self.deuter.add(otherResourcesObject.getDeuter())

    def substract(self, otherResourcesObject):
        self.metal.substract(otherResourcesObject.getMetal())
        self.crystal.substract(otherResourcesObject.getCrystal())
        self.deuter.substract(otherResourcesObject.getDeuter())

    def addResource(self, ResourceObject):
        if ResourceObject.resourceType == ResourceType(1):
            self.metal.add(ResourceObject)
        elif ResourceObject.resourceType == ResourceType(2):
            self.crystal.add(ResourceObject)
        elif ResourceObject.resourceType == ResourceType(3):
            self.deuter.add(ResourceObject)

    def substractResource(self, ResourceObject):
        if ResourceObject.resourceType == ResourceType(1):
            self.metal.substract(ResourceObject)
        elif ResourceObject.resourceType == ResourceType(2):
            self.crystal.substract(ResourceObject)
        elif ResourceObject.resourceType == ResourceType(3):
            self.deuter.substract(ResourceObject)
