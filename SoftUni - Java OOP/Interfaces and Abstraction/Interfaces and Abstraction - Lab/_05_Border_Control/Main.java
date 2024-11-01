package _05_Border_Control;

import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        //Map<String, Citizen> citizenMap = new LinkedHashMap<>();
        //Map<String, Robot> robotMap = new LinkedHashMap<>();
        List<Identifiable> identifiables = new ArrayList<>();


        String line = scanner.nextLine();

        while (!"End".equals(line)) {
            String[] tokens = line.split(" ");

            String argument = tokens[0];
            switch (tokens.length) {
                case 3:
                    String name = argument;
                    int age = Integer.parseInt(tokens[1]);
                    String id = tokens[2];
                    Identifiable citizen = new Citizen(name, age, id);
                    identifiables.add(citizen);
                    //citizenMap.putIfAbsent(name, citizen);
                    break;
                case 2:
                    String model = argument;
                    id = tokens[1];
                    Identifiable robot = new Robot(model, id);
                    identifiables.add(robot);
                    //robotMap.putIfAbsent(model, robot);
                    break;
            }


            line = scanner.nextLine();
        }
        String fakeIds = scanner.nextLine();

        identifiables.stream().map(Identifiable::getId)
                .filter(id -> id.endsWith(fakeIds))
                .forEach(System.out::println);

        /*citizenMap.values().stream()
                .map(Citizen::getId) // Get the ID of each citizen
                .filter(id -> id.endsWith(fakeIds)) // Filter IDs ending with fakeIds
                .forEach(System.out::println); // Print each matching ID

        robotMap.values().stream()
                .map(Robot::getId) // Get the ID of each robot
                .filter(id -> id.endsWith(fakeIds)) // Filter IDs ending with fakeIds
                .forEach(System.out::println); // Print each matching ID
         */
    }
}
