package tennisRanklist;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int countTournire = Integer.parseInt(sc.nextLine());
		int startPoints = Integer.parseInt(sc.nextLine());
		double wins = 0;
		int allPoints = 0;
		for (int i = 0; i < countTournire; i++) {
			
			String result = sc.nextLine();
			
			if(result.equals("W"))
			{
				startPoints += 2000;
				allPoints += 2000;
				wins++;
			}
			else if(result.equals("F"))
			{
				startPoints += 1200;
				allPoints += 1200;
			}
			else
			{
				startPoints += 720;
				allPoints += 720;
			}
		}
			 int averagePoints = allPoints / countTournire;
			 double winsPercent = (wins/countTournire) * 100;
			 
			 System.out.printf("Final points: %d\n", startPoints);
			 System.out.printf("Average points: %d\n", averagePoints);
			 System.out.printf("%.2f%%\n", winsPercent);
		}
	}

