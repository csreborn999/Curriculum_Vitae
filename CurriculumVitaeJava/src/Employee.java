
public class Employee {
	private String Name;//���u�m�W
	private int BaseSalary;//���~��
	private int OvertimePay;//�[�Z�O
	public Employee(String Name,int BaseSalary,int OvertimePay){
		this.Name=Name;
		this.BaseSalary=BaseSalary;
		this.OvertimePay=OvertimePay;
	}
	public int TotalPay(){//�p����u�`�~��
		return BaseSalary+OvertimePay;
	}
}
