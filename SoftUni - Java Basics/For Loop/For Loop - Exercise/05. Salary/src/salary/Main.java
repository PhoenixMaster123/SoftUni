package salary;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int openTaps = Integer.parseInt(sc.nextLine());
		int salary = Integer.parseInt(sc.nextLine());
		
		for (int i = 0; i < openTaps; i++) {
			String sites = sc.nextLine();
			if(salary <= 0)
			{
				System.out.println("You have lost your salary.");
			}
		if(sites.equals("Facebook"))
			{
			salary -= 150;
			}
		else if(sites.equals("Instagram"))
				{
			salary -= 100;
				}
		else if(sites.equals("Reddit"))
		{
			salary -= 50;
		}
		
		if(salary <= 0)
		{
			System.out.println("You have lost your salary.");
			break;
		}
		else continue;
		
	}
		if(salary > 0)
		{
			System.out.println(salary);
		}
	}

}
