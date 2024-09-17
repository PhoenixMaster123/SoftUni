package lab._07_Cities_by_Continent_and_Country;

import java.util.LinkedHashMap;
import java.util.LinkedList;
import java.util.Map;
import java.util.Scanner;
import java.util.stream.Collectors;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        LinkedHashMap<String, LinkedHashMap<String, LinkedList<String>>> countries = new LinkedHashMap<>();

        for (int i = 0; i < n; i++)
        {
            String[] tokens = scanner.nextLine().split(" ");

            String continent = tokens[0];
            String county = tokens[1];
            String city = tokens[2];

            // put the continent and create new LinkedHashMap
            countries.putIfAbsent(continent, new LinkedHashMap<>());
            // get the value of the first map
            LinkedHashMap<String, LinkedList<String>> innerInput = countries.get(continent);
            // put the value in the inner map and create LinkedList
            innerInput.putIfAbsent(county, new LinkedList<>());
            // get the inner value
            LinkedList<String> list = innerInput.get(county);
            // add the value in the LinkedList
            list.add(city);


        }

        for(Map.Entry<String, LinkedHashMap<String, LinkedList<String>>> entry : countries.entrySet())
        {
            System.out.println(entry.getKey() + ":");

            LinkedHashMap<String, LinkedList<String>> innerData = entry.getValue();

            for(Map.Entry<String, LinkedList<String>> innerEntry : innerData.entrySet())
            {
                System.out.print(innerEntry.getKey() + " -> ");
                String s = innerEntry.getValue().stream().collect(Collectors.joining(", "));
                System.out.println(s);
            }
        }
    }
}
