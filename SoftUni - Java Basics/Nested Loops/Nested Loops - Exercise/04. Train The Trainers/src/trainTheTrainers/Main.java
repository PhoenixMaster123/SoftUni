package trainTheTrainers;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		 
		Scanner sc = new Scanner(System.in);
		
		int count = Integer.parseInt(sc.nextLine());
		double grade = 0;
		double theWholeGrade = 0;
		double studentsGrade = 0;
		int gradeCount = 0;
		String command = sc.nextLine();
		while(!command.equals("Finish"))
		{
			String name = command;
			for (int j = 0; j < count; j++) {
				 grade = Double.parseDouble(sc.nextLine());
				theWholeGrade+=grade;
				studentsGrade +=grade;
				gradeCount++;
			}
			System.out.printf("%s - %.2f.\n",name,(studentsGrade/count));
			studentsGrade =0;
			command = sc.nextLine();
		}
		System.out.printf("Student's final assessment is %.2f.",theWholeGrade/gradeCount);
		
		
		}

	}
