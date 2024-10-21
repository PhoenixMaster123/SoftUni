package _04_Hotel_Reservation;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] data = scanner.nextLine().split(" ");
        double pricePerDay = Double.parseDouble(data[0]);
        int numberOfDays = Integer.parseInt(data[1]);
        Season season = Season.valueOf(data[2].toUpperCase()); // Take the enum with this name. If it is not there, it will return exception
        Discount discount = Discount.valueOf(data[3].toUpperCase());

        System.out.printf("%.2f ", PriceCalculator.calculatePrice(pricePerDay,numberOfDays,season,discount));
    }
}
