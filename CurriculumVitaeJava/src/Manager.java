
public class Manager extends Employee {
	private int DutyAllowance;//職務加給
	public Manager(String Name,int BaseSalary,int OvertimePay,int DutyAllowance){
		super(Name,BaseSalary,OvertimePay);
		this.DutyAllowance=DutyAllowance;
	}
	public int TotalPay(){//計算經理的總薪水
		return super.TotalPay()+DutyAllowance;
	}
}
