import java.util.*;

public class transcript {
	private String name;//name�N��m�W���p���]private�^�r���ƶ���
    private int quiz;//quiz�N��p�Ҧ��Z���p���ƭȸ�ƶ���
    private int midterm;//midterm�N������Ҧ��Z���p���ƭȸ�ƶ���
    private int var_final;//var_final�N������Ҧ��Z���p���ƭȸ�ƶ���
    private String grade;
	public transcript(String name, int quiz, int midterm, int var_final)
    {
        this.name = name;
        this.quiz = quiz;
        this.midterm = midterm;
        this.var_final = var_final;
    }
	public double calScore()//�p��Ǵ����Z�]score�^���p���ƭȸ�ƶ���
    {
        return quiz * 0.15 + midterm * 0.35 + var_final * 0.5;
    }
	public String calGrade()//�p�⦨�Z���ġ]grade�^���p���r����ƶ���
    {
        double score = calScore();
        if (score >= 90)
        {
            grade = "A";
        }
        else if (score >= 80)
        {
            grade = "B";
        }
        else if (score >= 70)
        {
            grade = "C";
        }
        else if (score >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "E";
        }
        return (grade);
    }
	public void printReport()//��ܥX�ǥͩm�W�B�Ǵ����Z�P���Z���ĵ��G
    {
		System.out.println("name:" + name + "\nquiz    midterm final    score   grade\n" + quiz + "      " + midterm + "      " + var_final + "       " + calScore() + "      " + calGrade());
    }
}
