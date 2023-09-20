package NumberPyramid;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		int current = 1;
		boolean isBigger = false;
		int num = Integer.parseInt(sc.nextLine());
		
		for (int rows = 1; rows <= num; rows++) 
		{
			for (int cols = 1; cols <= rows; cols++) 
			{
				if(current > num) 
				{
					isBigger = true;
					break;
				}
				System.out.print(current + " ");
				current++;
				
			}			
			if(isBigger)
			{
				break;
			}
			System.out.println();
		}
		

	}

}
