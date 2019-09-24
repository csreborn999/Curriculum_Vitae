using System;
using System.Collections.Generic;
using System.Text;

namespace Curriculum_Vitae_C_Sharp
{
    class Employee
    {
        private string Name;//員工姓名
        private int BaseSalary;//基本薪水
        private int OvertimePay;//加班費
        public Employee(string Name, int BaseSalary, int OvertimePay)
        {
            this.Name = Name;
            this.BaseSalary = BaseSalary;
            this.OvertimePay = OvertimePay;
        }
        public int TotalPay()//計算員工總薪水
        {
            return BaseSalary + OvertimePay;
        }
    }
}
