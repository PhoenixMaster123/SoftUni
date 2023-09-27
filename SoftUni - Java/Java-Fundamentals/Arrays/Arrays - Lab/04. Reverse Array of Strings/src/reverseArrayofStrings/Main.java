package reverseArrayofStrings;

import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		  Scanner scanner = new Scanner(System.in);
	        String[] words = scanner.nextLine().split(" ");
	        String[] values = new String[words.length];
	        
	        for (int i = 0; i < values.length; i++) {
	            values[i] = words[i].trim();
	        }
	        
	        for (int i = values.length - 1; i >= 0; i--) {
	            System.out.print(values[i] + " ");
	        }
		/*Scanner sc = new Scanner(System.in);
		String[] arr = sc.nextLine().split(" ");
		
		for (int i = arr.length-1; i >= 0; i--) {
			
			for (int j = arr.length-1; j >= 0; j--) {
				
				arr[i] = arr[j];
				System.out.print(arr[j] + " ");
				
			}
			break;
		}
		*/
		
	}

}
