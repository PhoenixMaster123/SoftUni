package dayofWeek;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		// Ctrl + Shift + O; -> fast inport
		
		Scanner scanner = new Scanner(System.in);
		
		String[] days = 
			{"Monday","Tuesday","Wednesday",
		    "Thursday","Friday","Saturday","Sunday"}; 
		int day = Integer.parseInt(scanner.nextLine());
		
			if(day >= 1 && day <= days.length)
			{
				System.out.println(days[day - 1]);
			}
			else
			{
				System.out.print("Invalid day!");
			}
		}

	}


