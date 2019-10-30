from Builder import Builder
from Type import Type
from Wood import Wood
from Inventory import Inventory as inventory
from Guitar import Guitar
from GuitarSpec import GuitarSpec 


def initalizeInventory(inventory):
    inventory().addGuitar("11277", 3999.95, GuitarSpec(Builder.COLLINGS.value, "CJ", Type.ACOUSTIC.value, 6, Wood.INDIAN_ROSEWOOD.value, Wood.SITKA.value))
    inventory().addGuitar("V95693", 1499.95, GuitarSpec(Builder.FENDER.value, "Stratocastor", Type.ELECTRIC.value, 6, Wood.ALDER.value, Wood.ALDER.value))
    inventory().addGuitar("V9512", 1549.95, GuitarSpec(Builder.FENDER.value, "Stratocastor", Type.ELECTRIC.value, 6, Wood.ALDER.value, Wood.ALDER.value))
    inventory().addGuitar("122784", 5495.95, GuitarSpec(Builder.MARTIN.value, "D-18", Type.ACOUSTIC.value, 6, Wood.MAHOGANY.value, Wood.ADIRONDACK.value))
    inventory().addGuitar("76531", 6295.95, GuitarSpec(Builder.MARTIN.value, "OM-28", Type.ACOUSTIC.value, 6, Wood.BRAZILIAN_ROSEWOOD.value, Wood.ADIRONDACK.value))
    inventory().addGuitar("70108276", 2295.95, GuitarSpec(Builder.GIBSON.value, "Les Paul", Type.ELECTRIC.value, 6, Wood.MAHOGANY.value, Wood.MAHOGANY.value))
    inventory().addGuitar("82765501", 1890.95, GuitarSpec(Builder.GIBSON.value, "SG '61 Reissue", Type.ELECTRIC.value, 6, Wood.MAHOGANY.value, Wood.MAHOGANY.value))
    inventory().addGuitar("77023", 6275.95, GuitarSpec(Builder.MARTIN.value, "D-28", Type.ACOUSTIC.value, 6, Wood.BRAZILIAN_ROSEWOOD.value, Wood.ADIRONDACK.value))
    inventory().addGuitar("1092", 12995.95, GuitarSpec(Builder.OLSON.value, "SJ", Type.ACOUSTIC.value, 12, Wood.INDIAN_ROSEWOOD.value, Wood.CEDAR.value))
    inventory().addGuitar("566-62", 8999.95, GuitarSpec(Builder.RYAN.value, "Cathedral", Type.ACOUSTIC.value, 12, Wood.COCOBOLO.value, Wood.CEDAR.value))
    inventory().addGuitar("629584", 2100.95, GuitarSpec(Builder.PRS.value, "Dave Navarro Signature", Type.ELECTRIC.value, 6, Wood.MAHOGANY.value, Wood.MAPLE.value))

if __name__ == "__main__":
    initalizeInventory(inventory)
    whatErinLikes = GuitarSpec(Builder.FENDER.value, "Stratocastor", Type.ELECTRIC.value, 6, Wood.ALDER.value, Wood.ALDER.value)
    machingGuitars = inventory().search(whatErinLikes)
    if machingGuitars != [] :
        print("Erin, you might like these guitars:")
        index = 0
        for i in machingGuitars:
            guitar = machingGuitars[index]
            spec = guitar.GetSpec()
            index +=1
            print("We have a",spec.getBuilder(),spec.getModel(),spec.getType(),"guitar:\n",spec.getBackWood(),"back and sides,\n",spec.getTopWood(),"top.\n You can have it for only $",guitar.getPrice(),"!\n")
    else:
        print("Sorry, Erin, we have nothing for you.")