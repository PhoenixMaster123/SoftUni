package _05_Comparing_Objects;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        List<Person> personList = new ArrayList<>();
        String line = scanner.nextLine();
        while (!"END".equals(line)) {

            String[] tokens = line.split(" ");
            String name = tokens[0];
            int age = Integer.parseInt(tokens[1]);
            String town = tokens[2];

            Person person = new Person(name, age, town);
            personList.add(person);

            line = scanner.nextLine();
        }
        int n = Integer.parseInt(scanner.nextLine());

        int counter = 0;

        Person person = personList.get(n - 1);
        for (Person person2 : personList) {

            if (person.compareTo(person2) == 0) {
                counter++;
            }
        }

        if(counter == 1) {
            System.out.println("No matches");
        } else {
            System.out.println(counter + " " + (personList.size() - counter) + " " + personList.size());
        }
    }
}
