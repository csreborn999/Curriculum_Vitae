class GuitarSpec:
    def __init__(self,builder,model,type,numStrings,backWood,topWood):
        self._builder = builder
        self._model = model
        self._type = type
        self._numStrings = numStrings
        self._backWood = backWood
        self._topWood = topWood
        
    def getBuilder(self):
        return self._builder

    def getModel(self):
        return self._model

    def getType(self):
        return self._type

    def getNumStrings(self):
        return self._numStrings

    def getBackWood(self):
        return self._backWood

    def getTopWood(self):
        return self._topWood

    def matches(self,otherSpec):
        if self._builder != otherSpec._builder:
            return False
        elif self._model != None and self._model != "" and self._model.lower() != otherSpec._model.lower():
            return False
        elif self._type != otherSpec._type:
            return False
        elif self._numStrings != otherSpec._numStrings:
            return False
        elif self._backWood != otherSpec._backWood:
            return False
        elif self._topWood != otherSpec._topWood:
            return False
        else: return True