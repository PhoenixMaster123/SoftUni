package exercise._10_Predicate_Party;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.function.Function;
import java.util.function.Predicate;
import java.util.stream.Collectors;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        List<String> guests = Arrays.stream(scanner.nextLine().split(" "))
                .collect(Collectors.toList());

        String line = scanner.nextLine();


        while (!line.equals("Party!"))
        {
            String[] tokens = line.split(" ");

            String command = tokens[0];
            String condition = tokens[1];
            String conditionValue = tokens[2];

            Predicate<String> predicate = getStringPredicate(condition, conditionValue);
            Function<List<String>, List<String>> addFunction = guestNames ->
            {
                List<String> updateList = new ArrayList<>();
                if(condition.equals("Length"))
                {
                    int conditionLength = Integer.parseInt(conditionValue);
                    for (String name : guestNames)
                    {
                        if(name.length() == conditionLength)
                        {
                            updateList.add(name);
                            updateList.add(name);
                        }
                        else
                        {
                            updateList.add(name);
                        }
                    }
                }
                else
                {
                    for (String name : guestNames)
                    {
                        if ((condition.equals("StartsWith") && name.startsWith(conditionValue)) ||
                           (condition.equals("EndsWith") && name.endsWith(conditionValue)))
                        {
                            updateList.add(name);
                            updateList.add(name);
                        }
                        else
                        {
                            updateList.add(name);
                        }
                    }
                }

                return updateList.stream().sorted().toList();
            };


            switch (command)
            {
                case "Remove" -> guests = guests.stream().filter(predicate.negate()).collect(Collectors.toList());
                case "Double" -> guests = addFunction.apply(guests);
            }

            line = scanner.nextLine();
        }
        if(guests.isEmpty())
        {
            System.out.println("Nobody is going to the party!");
        }
        else
        {
            String s = guests.stream().map(String::valueOf).collect(Collectors.joining(", "));
            System.out.println(s + " are going to the party!");
        }
    }

    private static Predicate<String> getStringPredicate(String condition, String conditionValue) {
        Predicate<String> predicate;
        {
            if(condition.equals("StartsWith"))
            {
                predicate = name -> name.startsWith(conditionValue);
            }
            else if(condition.equals("EndsWith"))
            {
                predicate = name -> name.endsWith(conditionValue);
            }
            else
            {
                int removeCondition = Integer.parseInt(conditionValue);
                predicate = name -> name.length() == removeCondition;
            }
        }
        return predicate;
    }
}
