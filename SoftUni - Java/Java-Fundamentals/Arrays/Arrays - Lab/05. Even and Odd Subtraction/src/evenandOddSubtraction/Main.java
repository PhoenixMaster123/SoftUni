package evenandOddSubtraction;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int[] numbers = Arrays.stream(sc.nextLine().split(" "))
		.mapToInt(e -> Integer.parseInt(e)).toArray();
		
		int sumEven = 0;
		int sumOdd = 0;
		
		for (int i = 0; i < numbers.length; i++) {
			
			if(numbers[i] % 2 == 0)
			{
				sumEven+=numbers[i];
			}
			else
			{
				sumOdd +=numbers[i];
			}
		}
		int result = sumEven-sumOdd;
		System.out.println(result);
	}

}
