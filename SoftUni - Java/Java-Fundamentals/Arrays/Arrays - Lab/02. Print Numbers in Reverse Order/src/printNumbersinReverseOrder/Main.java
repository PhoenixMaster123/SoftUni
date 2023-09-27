package printNumbersinReverseOrder;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		int n = Integer.parseInt(sc.nextLine());
	    int[] number = new int[n];
	    
	    for (int i = 0;i<n;i++)
        {
            number[i] = Integer.parseInt(sc.nextLine());
        }
	    for (int i = number.length-1; i >= 0; i--)

        {
	    	System.out.print(number[i] + " ");
        }
	    /* ArrayList<Integer> numbers = new ArrayList<>();
	    
	    for (int i = 0; i < n; i++) {
			
	    	int nums = Integer.parseInt(sc.nextLine());
	    	numbers.add(nums);
		}
	    Collections.reverse(numbers);
	    System.out.println(numbers);
	    */

	}

}
