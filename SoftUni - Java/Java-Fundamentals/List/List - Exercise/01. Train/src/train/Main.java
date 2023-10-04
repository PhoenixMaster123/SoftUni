package train;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class Main {

	public static void main(String[] args) {
		
		Scanner scanner = new Scanner(System.in);
	    
		List<Integer> numbers = Arrays.stream(scanner.nextLine()			
		.split(" ")).map(Integer::parseInt).collect(Collectors.toList());
		
		int capacity = Integer.parseInt(scanner.nextLine());
		
		String command = scanner.nextLine();
		
		while(!command.equals("end"))
		{
			String[] item = command.split(" ");
			String funktion = item[0];
			
			if(funktion.equals("Add"))
			{
				int num = Integer.parseInt(item[1]);
				numbers.add(num);
			}
			else
			{
				int num = Integer.parseInt(item[0]);
				
				for (int i = 0; i < numbers.size(); i++) {
					
					if(numbers.get(i) + num <= capacity)
					{
						numbers.set(i, numbers.get(i) + num);
						break;
					}
				   
				}
			}
			command = scanner.nextLine();
		}
		 for (int i = 0; i < numbers.size(); i++) {
	            System.out.print(numbers.get(i));
	            if (i < numbers.size() - 1) {
	                System.out.print(" ");
		
	}
		 }
	}
}

