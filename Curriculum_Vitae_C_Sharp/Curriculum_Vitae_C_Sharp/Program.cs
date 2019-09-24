using System;

namespace Curriculum_Vitae_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("這是一個Demo(This is a Demo.)");
            Console.WriteLine("物件導向三大特性(Three Object-Oriented Principles):");
            Console.WriteLine("封裝(Encapsulation):\n");
            string name, ch = "y";  
            int quiz, midterm, var_final;
            transcript myObj;
            while (ch == "y" || ch == "Y")//詢問使用者是否繼續輸入
            {
                Console.Write("enter name:");
                name = Console.ReadLine();
                Console.Write("enter quiz score:");
                quiz = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter midterm exam score:");
                midterm = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter final exam score:");
                var_final = Convert.ToInt32(Console.ReadLine());
                myObj = new transcript(name, quiz, midterm, var_final);
                myObj.printReport();
                Console.Write("do it again?Y/N:");
                ch = Console.ReadLine();
            }
            Console.WriteLine("\n繼承(inheritance):\n");
            int numA, numB;
            Console.Write("enter numA:");
            numA = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter numB:");
            numB = Convert.ToInt32(Console.ReadLine());
            ClassB bdata = new ClassB(numA, numB);
            bdata.show();
            Console.WriteLine("\n多載(polymorphism)中的覆寫(override):\n");
            Employee employee = new Employee("John", 25000, 10000);
            Console.WriteLine(employee.TotalPay());
            Manager manager = new Manager("Eric", 25000, 10000, 20000);
            Console.WriteLine(manager.TotalPay());
        }
    }
}
