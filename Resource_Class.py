from enum import Enum
class Type(Enum):
    Metal = 1
    Crystal = 2
    Deuter = 3

class Resource:

    def __init__(self, resource_type):
        self.resourcetype = resource_type
        self.quantity = int(0)

    def get_type(self):
        return self.resourcetype

    def get_quantity(self):
        return self.quantity

    def set_quantity(self,value):
        self.quantity = value

    def add(self,Other_resource):
        self.quantity = self.quantity + Other_resource.get_quantity()

    def substract(self,Other_resource):
        self.quantity = self.quantity - Other_resource.get_quantity()




metal = Resource(Type.Metal)
crystal = Resource(Type.Crystal)
metal.set_quantity(8)
crystal.set_quantity(200)
name = metal.get_quantity()
print (name)
metal.add(crystal)
name = metal.get_quantity()
print(name)
metal.substract(crystal)
name = metal.get_quantity()
print (name)
