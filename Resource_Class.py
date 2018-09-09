from enum import Enum
class ResourceType(Enum):
    Metal = 1
    Crystal = 2
    Deuter = 3

class Resource:

    def __init__(self, resourceType):
        self.resourceType = resourceType
        self.quantity = int(0)

    def getType(self):
        return self.resourceType

    def getQuantity(self):
        return self.quantity

    def setQuantity(self,value):
        self.quantity = value

    def add(self,otherResource):
        self.quantity = self.quantity + otherResource.getQuantity()

    def substract(self,otherResource):
        self.quantity = self.quantity - otherResource.getQuantity()




metal = Resource(ResourceType.Metal)
crystal = Resource(ResourceType.Crystal)
metal.setQuantity(8)
crystal.setQuantity(200)
name = metal.getQuantity()
print (name)
metal.add(crystal)
name = metal.getQuantity()
print(name)
metal.substract(crystal)
name = metal.getQuantity()
print (name)
