package walking;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		int steps = 0;
		String command = sc.nextLine();
		int lastSteps = 0;
		int daySteps = 0;
		
		while(true)
		{
			if(command.equals("Going home"))
			{
				lastSteps = Integer.parseInt(sc.nextLine());
				steps+=lastSteps;
				if(steps >= 10000)
				{
					steps-=10000;
					System.out.printf("Goal reached! Good job!\n%d steps over the goal!", steps);
					break;
				}
				else {
					steps = 10000-steps;
					System.out.printf("%d more steps to reach goal.", steps);
					break;
				}
			}
			daySteps = Integer.parseInt(command);
			steps+=daySteps;
			
			if(steps >= 10000)
			{
				steps-=10000;
				System.out.printf("Goal reached! Good job!\n%d steps over the goal!", steps);
				break;
			}
			
			command = sc.nextLine();
		}

	}

}
