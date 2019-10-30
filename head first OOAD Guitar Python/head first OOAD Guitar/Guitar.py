from GuitarSpec import GuitarSpec

class Guitar(object):
    def __init__(self,serialNumber,price,spec):
        self._serialNumber = serialNumber
        self._price = price
        self._spec = spec

    def getSerialNumber(self):
        return self._serialNumber

    def getPrice(self):
        return self._price

    def setPrice(self,newPrice):
        self._price = newPrice
        
    def GetSpec(self):
        return self._spec