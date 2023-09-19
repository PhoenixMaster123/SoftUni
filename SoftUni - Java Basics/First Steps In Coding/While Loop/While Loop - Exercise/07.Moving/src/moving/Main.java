package moving;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int breit = Integer.parseInt(sc.nextLine());
		int lang = Integer.parseInt(sc.nextLine());
		int hoch = Integer.parseInt(sc.nextLine());
		int platz = breit *  lang * hoch;
		String command = sc.nextLine();
		
		while(!command.equals("Done"))
		{
			int meters = Integer.parseInt(command);
			platz-=meters;
			if(platz < 0)
			{
				System.out.printf("No more free space! You need %d Cubic meters more.", Math.abs(platz));
				break;
			}
			command = sc.nextLine();
		}
		if(command.equals("Done"))
		{
			System.out.printf("%d Cubic meters left.", platz);
		}
		
	}

}
