from ClassA import ClassA

class ClassB(ClassA): #子類別繼承自ClassA
    def __init__(self,A,B): #設定繼承而來的成員numA,numB
        self.numA=A
        self.numB=B

    def show(self): #顯示numA與numB
        print(self.numA,self.numB)