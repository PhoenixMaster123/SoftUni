package _03_Birthday_Celebrations;

import java.util.LinkedList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String line = scanner.nextLine();

        List<Birthable> birthableList = new LinkedList<>();

        while (!"End".equals(line)) {

            String[] tokens = line.split(" ");

            switch (tokens[0]) {
                case "Citizen" -> {
                    String name = tokens[1];
                    int age = Integer.parseInt(tokens[2]);
                    String id = tokens[3];
                    String birthDate = tokens[4];
                    Birthable citizen = new Citizen(name, age, id, birthDate);
                    birthableList.add(citizen);
                }
                case "Pet" -> {
                    String name = tokens[1];
                    String birthDate = tokens[2];

                    Birthable pet = new Pet(name, birthDate);
                    birthableList.add(pet);
                }
            }

            line = scanner.nextLine();
        }
        String year = scanner.nextLine();

        birthableList.stream().filter(birthable -> birthable.getBirthDate().endsWith(year))
                .forEach(birthable -> System.out.println(birthable.getBirthDate()));
    }
}
