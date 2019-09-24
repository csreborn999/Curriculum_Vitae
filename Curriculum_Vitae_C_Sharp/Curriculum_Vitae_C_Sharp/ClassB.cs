using System;
using System.Collections.Generic;
using System.Text;

namespace Curriculum_Vitae_C_Sharp
{
    class ClassB : ClassA//子類別繼承自ClassA
    {
        public ClassB(int A, int B)//設定繼承而來的成員numA,numB
        {
            this.numA = A;
            this.numB = B;
        }
        public void show()//顯示numA與numB
        {
            Console.WriteLine(numA + "," + numB);
        }
    }
}
