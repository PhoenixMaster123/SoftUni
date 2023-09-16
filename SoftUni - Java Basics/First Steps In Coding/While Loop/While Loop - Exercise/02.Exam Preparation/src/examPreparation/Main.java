package examPreparation;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		int grade = Integer.parseInt(sc.nextLine());
		String input = sc.nextLine();
		double sum = 0;
		int count = 0;
		int badGrade = 0;
		String lastProblem = null;
		while(!input.equals("Enough"))
		{
			String name = input;
			int note = Integer.parseInt(sc.nextLine());
			sum +=note;
			count++;
			if(note <= 4)
			{
				badGrade++;
			}
			if(badGrade >= grade)
			{
				System.out.printf("You need a break, %d poor grades.", grade);
				break;
			}
			lastProblem = input;
			input = sc.nextLine();
		}
		
		if(input.equals("Enough"))
		{
			double average = sum/count;
			System.out.printf("Average score: %.2f\nNumber of problems: %d\nLast problem: %s", average,count, lastProblem);
		}
	}

}
