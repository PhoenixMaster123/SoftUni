import java.util.*;

public class Main {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        LinkedHashMap<Double, Integer> map = new LinkedHashMap<>();

        List<Double> numbers = Arrays.stream(scanner.nextLine().split(" "))
                .map(Double::parseDouble).toList();

        for (Double number : numbers)
        {
            if(!map.containsKey(number))
            {
                map.put(number, 1);
            }
            else
            {
                map.put(number, map.get(number) + 1);
            }
        }

        for (Double key : map.keySet())
        {
            System.out.println(String.format("%.1f -> %d", key, map.get(key)));
        }
    }
}