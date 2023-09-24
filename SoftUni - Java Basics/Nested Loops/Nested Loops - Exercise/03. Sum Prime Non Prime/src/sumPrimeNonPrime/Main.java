package sumPrimeNonPrime;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		String command = sc.nextLine();
		int primeNumber = 0;
		int nonPrimeNumber = 0;
		while(!command.equals("stop"))
		{
			int num = Integer.parseInt(command);
			if(num < 0)
			{
				System.out.println("Number is negative.");
			}
			else 
			{
				 int count = 0;
                 for(int i=1;i<=num;i++)
                 {
                     if (num % i == 0) 
                     {
                         count++;
                     }
                 }
                 if(count==2)
                 {
                     primeNumber += num;
                 }
                 else
                 {
                     nonPrimeNumber += num;
                 }
			}
			command = sc.nextLine();
		}
		System.out.printf("Sum of all prime numbers is: %d\n", primeNumber);
		System.out.printf("Sum of all non prime numbers is: %d", nonPrimeNumber);

	}

}
