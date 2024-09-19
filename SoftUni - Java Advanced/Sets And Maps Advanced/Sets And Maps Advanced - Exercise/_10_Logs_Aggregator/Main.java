package exercise._10_Logs_Aggregator;

import java.util.*;
import java.util.stream.Collectors;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        Map<String, TreeSet<String>> map = new TreeMap<>();
        Map<String, List<Integer>> map2 = new HashMap<>();

        for (int i = 0; i < n; i++)
        {
            String[] tokens = scanner.nextLine().split(" ");
            String ip = tokens[0];
            String user = tokens[1];
            int duration = Integer.parseInt(tokens[2]);

            map.computeIfAbsent(user, k -> new TreeSet<>()).add(ip);
            map2.computeIfAbsent(user, k -> new ArrayList<>()).add(duration);

        }

        for (Map.Entry<String, TreeSet<String>> entry : map.entrySet())
        {
            /*System.out.println(entry.getKey() + ":"
                    + calculateDuration(map2.get(entry.getKey())) + "[" +
                    entry.getValue().forEach(ip -> System.out.print(ip + ", ")) + "]");
             */
            System.out.print(entry.getKey() + ": "
                    + calculateDuration(map2.get(entry.getKey())) + " [");
            String str = String.join(", ", entry.getValue());
            System.out.print(str + "]\n");

        }
    }

    private static int calculateDuration(List<Integer> values)
    {
       return values.stream().mapToInt(Integer::intValue).sum();
    }
}
