import java.util.*;

public class FibonacciWithMemoization {
	
	public static long fibArray[] = new long[127];
	public static long fib(long n) {
		long fibValue = 0;
		if (n <= 1) {
			return n;
		}else if(fibArray[(int)n]!=0) {
			return fibArray[(int)n];
		}else {
			fibValue=fib(n-1)+fib(n-2);
			fibArray[(int) n]=fibValue;
			return fibValue;
		}
	}
	
	public static void main(String[] args) {
		fibArray[0]=1;
		fibArray[1]=1;
		System.out.println(fib(71));
	}
}
