package exercise._04_Count_Symbols;

import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        Map<Character, Integer> map = new TreeMap<>();

        char[] symbols = scanner.nextLine().toCharArray();

        for (char symbol : symbols)
        {
            map.putIfAbsent(symbol, 0);
            map.put(symbol, map.get(symbol) + 1);
        }
        /*for(Map.Entry<Character, Integer> entry : map.entrySet())
        {
            System.out.println(entry.getKey() + ": " + entry.getValue() + " time/s");
        }
         */
        map.forEach((key, value) -> System.out.printf("%c: %d time/s\n", key, value));
    }
}
