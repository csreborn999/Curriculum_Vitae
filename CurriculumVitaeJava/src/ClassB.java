
public class ClassB extends ClassA {//子類別繼承自ClassA
	ClassB(int A,int B){//設定繼承而來的成員numA,numB
		this.numA=A;
		this.numB=B;
	}
	public void show(){//顯示numA與numB
		System.out.println(numA+","+numB);
	}
}
