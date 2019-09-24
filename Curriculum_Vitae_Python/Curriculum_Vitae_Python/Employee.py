class Employee(object):
    def __init__ (self,Name,BaseSalary,OvertimePay):
        self._Name=Name
        self._BaseSalary=BaseSalary
        self._OvertimePay=OvertimePay

    def TotalPay(self):
        return self._BaseSalary+self._OvertimePay