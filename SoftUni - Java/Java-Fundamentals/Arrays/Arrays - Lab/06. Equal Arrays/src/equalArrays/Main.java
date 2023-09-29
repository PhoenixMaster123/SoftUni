package equalArrays;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
///////////////////////// Third Variant /////////////////////////
		Scanner sc = new Scanner(System.in);
        int [] items = Arrays.stream(sc.nextLine().split(" ")).mapToInt(e -> Integer.parseInt(e)).toArray();
        int[] numbers = Arrays.stream(sc.nextLine().split(" ")).mapToInt(e -> Integer.parseInt(e)).toArray();
        int sum = 0;         
        //bool flag = false;
        for ( int i = 0; i < items.length; i++)
        {
            sum += items[i];
            if (items[i] != numbers[i])
            {
                System.out.printf("Arrays are not identical. Found difference at %d index.",i);
               // flag = true;
                return;
               // break;
                
            }   
        }
        System.out.printf("Arrays are identical. Sum: %d", sum);
        //if (!flag)
        //{
        //    System.out.printf("Arrays are identical. Sum: %d", sum);
        //}  


///////////////////////// Second Variant /////////////////////////
		/*Scanner scanner = new Scanner(System.in);

        String[] itemsString = scanner.nextLine().split(" ");
        String[] numbersString = scanner.nextLine().split(" ");

        int[] items = new int[itemsString.length];
        int[] numbers = new int[numbersString.length];

        for (int i = 0; i < itemsString.length; i++) {
            items[i] = Integer.parseInt(itemsString[i]);
        }

        for (int i = 0; i < numbersString.length; i++) {
            numbers[i] = Integer.parseInt(numbersString[i]);
        }

        int sum = 0;
        boolean flag = false;

        for (int i = 0; i < items.length; i++) {
            sum += items[i];
            if (items[i] != numbers[i]) {
                System.out.printf("Arrays are not identical. Found difference at %d index.", i);
                flag = true;
                break;
            }
        }

        if (!flag) {
            System.out.printf("Arrays are identical. Sum: %d%n", sum);
        }
        */
///////////////////////// First Variant /////////////////////////
		/* Scanner sc = new Scanner(System.in);
		
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
		*/
	}

}
