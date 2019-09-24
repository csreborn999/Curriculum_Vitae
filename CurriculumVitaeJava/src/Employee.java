
public class Employee {
	private String Name;//員工姓名
	private int BaseSalary;//基本薪水
	private int OvertimePay;//加班費
	public Employee(String Name,int BaseSalary,int OvertimePay){
		this.Name=Name;
		this.BaseSalary=BaseSalary;
		this.OvertimePay=OvertimePay;
	}
	public int TotalPay(){//計算員工總薪水
		return BaseSalary+OvertimePay;
	}
}
