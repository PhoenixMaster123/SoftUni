package oldBooks;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		String searchBook = sc.nextLine();
		String books = sc.nextLine(); 
		int checkBooks = 0;
		while(!books.equals("No More Books"))
		{
			if(books.equals(searchBook))
			{
				System.out.printf("You checked %d books and found it.", checkBooks);
				break;
				
			}
			checkBooks++;
			books = sc.nextLine();
		}		
		if(books.equals("No More Books"))
		{
			System.out.printf("The book you search is not here!\nYou checked %d books.", checkBooks );
		}
		
	}

}
