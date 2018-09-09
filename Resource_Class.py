from enum import Enum

class ResourceType(Enum):
    Metal = 1
    Crystal = 2
    Deuter = 3

class Resource:
    def __init__(self, resourceType):
        self.resourceType = resourceType
        self.quantity = 0

    def getType(self):
        return self.resourceType

    def getQuantity(self):
        return self.quantity

    def setQuantity(self, value):
        self.quantity = value

    def add(self, otherResource):
        self.quantity += otherResource.getQuantity()

    def substract(self, otherResource):
        self.quantity -= otherResource.getQuantity()
