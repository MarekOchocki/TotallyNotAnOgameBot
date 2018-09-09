class Resources:
    def __init__(self, metalValue = 0, crystalValue = 0, deuterValue = 0):
        self.metal = metalValue
        self.crystal = crystalValue
        self.deuter = deuterValue

    def getMetal(self):
        return self.metal

    def getCrystal(self):
        return self.crystal

    def getDeuter(self):
        return self.deuter

    def setResources(self, metalValue = 0, crystalValue = 0, deuterValue = 0):
        self.metal = metalValue
        self.crystal = crystalValue
        self.deuter = deuterValue

    def add(self, otherResourcesObject):
        self.metal += otherResourcesObject.getMetal()
        self.crystal += otherResourcesObject.getCrystal()
        self.deuter += otherResourcesObject.getDeuter()

    def addMetal(self, otherResourcesObject):
        self.metal += otherResourcesObject.getMetal()

    def addCrystal(self, otherResourcesObject):
        self.metal += otherResourcesObject.getCrystal()

    def addDeuter(self, otherResourcesObject):
        self.metal += otherResourcesObject.getDeuter()

    def substract(self, otherResourcesObject):
        self.metal -= otherResourcesObject.getMetal()
        self.crystal -= otherResourcesObject.getCrystal()
        self.deuter -= otherResourcesObject.getDeuter()

    def substractMetal(self, otherResourcesObject):
        self.metal -= otherResourcesObject.getMetal()

    def substractCrystal(self, otherResourcesObject):
        self.metal -= otherResourcesObject.getCrystal()

    def substractDeuter(self, otherResourcesObject):
        self.metal -= otherResourcesObject.getDeuter()

aaa = Resources(1000, 1000, 1000)
bbb = Resources(1000, 1000, 1000)
bbb.setResources(500, 500, 500)
ccc = Resources()
ccc.add(aaa)
bbb.addCrystal(aaa)
print(aaa.metal)
print(bbb.crystal)
print(ccc.deuter)
ccc.substract(aaa)
print(ccc.metal)