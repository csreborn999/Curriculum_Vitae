from Employee import Employee

class Manager(Employee):
    def __init__(self,Name,BaseSalary,OvertimePay,DutyAllowance):
        super(Manager,self).__init__(Name,BaseSalary,OvertimePay)#覆寫員工類別
        self._DutyAllowance=DutyAllowance #職務加給
    
    def TotalPay(self):
        return super().TotalPay()+self._DutyAllowance #計算經理的總薪水
