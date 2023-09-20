package equalSumsEvenOddPosition;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int num = Integer.parseInt(sc.nextLine());
		int num2 = Integer.parseInt(sc.nextLine());
		
		for (int i = num; i <=num2; i++) {
			String currentNum = "" + i;
			int oddSum = 0;
			int evenSum = 0;
			for (int j = 0; j < currentNum.length(); j++) {
				int currentDigit = Integer.parseInt(String.valueOf(currentNum.charAt(j))); // second option -> "" + currentNum.chartAt(j);
				if(j % 2 == 0)
				{
					evenSum+=currentDigit;
				}
				else
				{
					oddSum+=currentDigit;
				}
				
			}
			if(oddSum == evenSum)
			{
				System.out.print(i + " ");
			}
			
		}

	}

}
