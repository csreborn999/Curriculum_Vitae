import java.util.*;

public class CurriculumVitaeJava {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("�o�O�@��Demo(This is a Demo.)");
		System.out.println("����ɦV�T�j�S��(Three Object-Oriented Principles):");
		System.out.println("�ʸ�(Encapsulation):\n");
		Scanner scanner = new Scanner(System.in);
		String name, ch = "y";  
        int quiz, midterm, var_final;
        transcript myObj;
        while(ch.equals("y") || ch.equals("Y")) {
        	scanner = new Scanner(System.in);
        	System.out.print("enter name:");
			name = scanner.nextLine();
			System.out.print("enter quiz score:");
			quiz = scanner.nextInt();
			System.out.print("enter midterm exam score:");
			midterm = scanner.nextInt();
			System.out.print("enter final exam score:");
			var_final = scanner.nextInt();
            myObj = new transcript(name, quiz, midterm, var_final);
            myObj.printReport();
            scanner = new Scanner(System.in);
			System.out.print("play again?Y/N:");
			ch = scanner.nextLine();
        }
        System.out.println("\n�~��(inheritance):\n");
        int numA, numB;
        scanner = new Scanner(System.in);
        System.out.print("enter numA:");
        numA = scanner.nextInt();
        System.out.print("enter numB:");
        numB = scanner.nextInt();
        ClassB bdata = new ClassB(numA,numB);
        bdata.show();
        System.out.println("\n�h��(polymorphism)�����мg(override):\n");
        Employee employee1 = new Employee("John",25000,10000);
		System.out.println(employee1.TotalPay());
		Manager manager1 = new Manager("Eric",25000,10000,20000);
		System.out.println(manager1.TotalPay());
	}

}
