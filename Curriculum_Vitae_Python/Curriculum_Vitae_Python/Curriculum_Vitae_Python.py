from transcript import transcript
from ClassA import ClassA
from ClassB import ClassB
from Employee import Employee
from Manager import Manager

if __name__ == "__main__":
    print("這是一個Demo(This is a Demo.)")
    print("物件導向三大特性(Three Object-Oriented Principles):")
    print("封裝(Encapsulation):\n")
    ch="y"
    while ch=="y" or ch=="Y":
        name=input("enter name:")
        quiz=float(input("enter quiz score:"))
        midterm=float(input("enter midterm exam score:"))
        final=float(input("enter final exam score:"))
        myObj = transcript(name,quiz,midterm,final)
        myObj.printReport()
        ch = input("do it again?Y/N:")
    print("\n繼承(inheritance):\n")
    numA = float(input("enter numA:"))
    numB = float(input("enter numB:"))
    bdata=ClassB(numA,numB)
    bdata.show()
    print("\n多載(polymorphism)中的覆寫(override):\n")
    employee = Employee('John',25000,10000)
    print(employee.TotalPay())
    manager = Manager("Eric",25000,10000,20000)
    print(manager.TotalPay())
