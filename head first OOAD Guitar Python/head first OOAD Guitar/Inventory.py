from Guitar import Guitar
from GuitarSpec import GuitarSpec

staticList1 = []#use static list
staticList2 = []#declare different variable to assign avoid append matchingGuitar, also append self._guitars
class Inventory(object):
    def __init__(self):
        self._guitars = staticList1

    def addGuitar(self,serialNumber,price,spec):
        self.guitar = Guitar(serialNumber,price,spec)
        self._guitars.append(self.guitar)

    def getGuitar(self,serialNumber):
        index = 0
        for i in self._guitars:
            self.guitar = self._guitars[index]
            if self.guitar.getSerialNumber() == serialNumber:
                return self.guitar
            index += 1
        return None

    def search(self,searchSpec):
        self.matchingGuitars = staticList2
        index = 0
        for i in self._guitars:
            self.guitar = self._guitars[index]
            if self.guitar.GetSpec().matches(searchSpec):
                self.matchingGuitars.append(self.guitar)
            index+=1
        return self.matchingGuitars