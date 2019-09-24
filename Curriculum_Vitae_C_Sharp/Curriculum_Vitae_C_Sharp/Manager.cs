using System;
using System.Collections.Generic;
using System.Text;

namespace Curriculum_Vitae_C_Sharp
{
    class Manager : Employee
    {
        private int DutyAllowance;//職務加給
        public Manager(string Name, int BaseSalary, int OvertimePay, int DutyAllowance): base(Name, BaseSalary, OvertimePay)//覆寫員工類別
        {
            this.DutyAllowance = DutyAllowance; 
        }
        public int TotalPay()//計算經理的總薪水
        {
            return base.TotalPay() + DutyAllowance;
        }
    }
}
