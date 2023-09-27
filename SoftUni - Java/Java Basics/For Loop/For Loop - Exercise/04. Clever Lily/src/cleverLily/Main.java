package cleverLily;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		 Scanner scanner = new Scanner(System.in);

	        int age = Integer.parseInt(scanner.nextLine());
	        double price = Double.parseDouble(scanner.nextLine());
	        int priceToy = Integer.parseInt(scanner.nextLine());

	        int toys = 0;
	        int money = 0;
	        int allMoney = 0;

	        for (int i = 1; i <= age; i++) {
	            money += 5;
	            if (i % 2 == 0) {
	                allMoney += money - 1;
	            } else {
	                toys++;
	            }
	        }

	        allMoney += toys * priceToy;

	        if (allMoney >= price) {
	            System.out.printf("Yes! %.2f", allMoney - price);
	        } else {
	            System.out.printf("No! %.2f", price - allMoney);
	        }

	}

}
