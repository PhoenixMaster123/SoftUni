package exercise._11_The_Party_Reservation_Filter_Module;

import java.util.*;
import java.util.function.BiFunction;
import java.util.function.Function;
import java.util.function.Predicate;
import java.util.stream.Collectors;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        List<String> guests = Arrays.stream(scanner.nextLine().split(" ")).collect(Collectors.toList());


        String line = scanner.nextLine();

        Map<String, Predicate<String>> predicateMap = new HashMap<>();

        Predicate<String> predicate;

        while (!line.equals("Print"))
        {
            String[] tokens = line.split(";");
            String command = tokens[0];
            String typeFilter = tokens[1];
            String parameter = tokens[2];
            String predicateName = tokens[1] + ";" + tokens[2];

            switch (command)
            {
                case "Add filter":

                    switch (typeFilter)
                    {
                        case "Starts with":
                            predicate = s -> s.startsWith(parameter);
                            predicateMap.putIfAbsent(predicateName, predicate);
                            break;
                        case "Ends with":
                            predicate = s -> s.endsWith(parameter);
                            predicateMap.putIfAbsent(predicateName, predicate);
                            break;
                        case "Length":
                            predicate = s -> s.length() == Integer.parseInt(parameter);
                            predicateMap.putIfAbsent(predicateName, predicate);
                            break;
                        case "Contains":
                            predicate = s -> s.contains(parameter);
                            predicateMap.putIfAbsent(predicateName, predicate);
                            break;

                    }
                    break;
                case "Remove filter":
                    predicateMap.remove(predicateName);
                    break;
            }

            line = scanner.nextLine();
        }

        for(String key : predicateMap.keySet())
        {
            Predicate<String> predicate1 = predicateMap.get(key);

           // guests = guests.stream().filter(predicate1.negate()).collect(Collectors.toList());
            guests.removeIf(predicate1);
        }
        guests.forEach(guest -> System.out.print(guest + " "));
    }
}
