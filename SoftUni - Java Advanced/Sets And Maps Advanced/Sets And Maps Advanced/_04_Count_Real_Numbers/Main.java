package lab._04_Count_Real_Numbers;

import java.util.*;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        double[] numbers = Arrays.stream(scanner.nextLine().split(" "))
                .mapToDouble(Double::parseDouble).toArray();

        Map<Double, Integer> map = new LinkedHashMap<>();

        for (double number : numbers)
        {
            /* Variant 1
           if(!map.containsKey(number))
           {
               map.put(number, 1);
           }
           else
           {
               map.put(number, map.get(number) + 1);
           }
             */
            // Variant 2
            map.putIfAbsent(number, 0);
            map.put(number, map.get(number) + 1);
        }

        for (Map.Entry<Double, Integer> entry : map.entrySet())
        {
            System.out.printf("%.1f -> %d\n",entry.getKey(), entry.getValue());

            //System.out.println(String.format());
        }
    }
}
