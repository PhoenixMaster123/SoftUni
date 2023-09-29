package equalArrays;

import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int[] numbers = Arrays.stream(sc.nextLine().split(" "))
				.mapToInt(e -> Integer.parseInt(e)).toArray();
		int[] numbers2 = Arrays.stream(sc.nextLine().split(" "))
				.mapToInt(e -> Integer.parseInt(e)).toArray();
		int count = 0;
		int sum = 0;
		for (int i = 0; i < numbers.length; i++) {
			for (int j = 0; j < numbers2.length; j++) {
				if(numbers[i] == numbers2[j])
				{
					count++;
					sum+=numbers[i];
					if(count == numbers.length)
					{
						System.out.printf("Arrays are identical. Sum: %d", sum);
						break;
					}
					i++;	
					continue;
				}
				else
				{
					System.out.printf("Arrays are not identical. Found difference at %d index.", j);
					break;
				}
			}
			break;
		}
	}

}
