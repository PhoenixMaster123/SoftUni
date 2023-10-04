package changeList;
//import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		List<Integer> numbers = Arrays.stream(sc.nextLine()			
				.split(" ")).map(Integer::parseInt).collect(Collectors.toList());
		
		 // ArrayList<Integer> numbers = Arrays.stream(sc.nextLine().split(" ")).map(Integer::parseInt).collect(Collectors.toCollection(ArrayList::new));
		
		  /*List<Integer> numbers = new ArrayList<>();
	        String[] inputNumbers = sc.nextLine().split(" ");
	        for (String num : inputNumbers) {
	            numbers.add(Integer.parseInt(num));
	        }
	        */
		String command = sc.nextLine();
		
		while(!command.equals("end"))
		{
			String[] item = command.split(" ");
			String funktion = item[0];			
			
			if(funktion.equals("Delete"))
			{
				int items = Integer.parseInt(item[1]);
			    numbers.removeIf(n -> n == items);
			}
			else if(funktion.equals("Insert"))
			{
				int items1 = Integer.parseInt(item[1]);
				int items2 = Integer.parseInt(item[2]);
				numbers.add(items2,items1);
			}
		
		command = sc.nextLine();
		
		}
		 for (int i = 0; i < numbers.size(); i++) {
	            System.out.print(numbers.get(i));
	            if (i < numbers.size() - 1) {
	                System.out.print(" ");
	}
		 }
	}
}
