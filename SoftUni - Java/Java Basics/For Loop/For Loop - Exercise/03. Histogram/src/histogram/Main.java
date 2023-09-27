package histogram;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int n = Integer.parseInt(sc.nextLine());
		
		double p1 = 0;
		double p2 = 0;
		double p3 = 0;
		double p4 = 0;
		double p5 = 0;
		for (int i = 0; i < n; i++) {
			
			int num = Integer.parseInt(sc.nextLine());
			if(num < 200)
			{
				p1++;
			}
			else if(num >= 200 && num <= 399)
			{
				p2++;
			}
			else if(num >= 400 && num <= 599)
			{
				p3++;
			}
			else if(num >= 600 && num <= 799)
			{
				p4++;
			}
			else
			{
				p5++;
			}
		}
		
		System.out.printf("%.2f%%\n", p1/n * 100);
		System.out.printf("%.2f%%\n", p2/n * 100);
		System.out.printf("%.2f%%\n", p3/n * 100);
		System.out.printf("%.2f%%\n", p4/n * 100);
		System.out.printf("%.2f%%\n", p5/n * 100);
		

	}

}
