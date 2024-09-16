package lab._01_Parking_Lot;

import java.util.LinkedHashSet;
import java.util.Scanner;
import java.util.Set;

public class Main {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        Set<String> parking = new LinkedHashSet<>();

        while (!input.equals("END"))
        {
            String[] tokens = input.split(", ");

            String directions = tokens[0];
            String carNumber = tokens[1];

            if(directions.equals("IN"))
            {
                parking.add(carNumber);
            }
            else
            {
                parking.remove(carNumber);
            }

            input = scanner.nextLine();
        }

        if(parking.isEmpty())
        {
            System.out.println("Parking Lot is Empty");
        }
        else {
            parking.forEach(System.out::println);
        }
    }
}