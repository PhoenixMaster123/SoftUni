package cake;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int breit = Integer.parseInt(sc.nextLine());
		int lang = Integer.parseInt(sc.nextLine());
		
		int ganzeTorte = breit * lang;
		
		String command = sc.nextLine();
		
		while(true)
		{
			if(command.equals("STOP"))
			{
				System.out.printf("%d pieces are left.", ganzeTorte);
				break;
			}
			int stücks = Integer.parseInt(command);
			ganzeTorte-=stücks;
			if(ganzeTorte < 0)
			{
				System.out.printf("No more cake left! You need %d pieces more.", Math.abs(ganzeTorte));
				break;
			}
			command = sc.nextLine();
		}


	}

}
