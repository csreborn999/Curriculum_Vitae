
public class Manager extends Employee {
	private int DutyAllowance;//¾�ȥ[��
	public Manager(String Name,int BaseSalary,int OvertimePay,int DutyAllowance){
		super(Name,BaseSalary,OvertimePay);
		this.DutyAllowance=DutyAllowance;
	}
	public int TotalPay(){//�p��g�z���`�~��
		return super.TotalPay()+DutyAllowance;
	}
}
