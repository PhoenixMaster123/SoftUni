import java.security.Key;
import java.text.DecimalFormat;
import java.util.*;

public class Main {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        List<Double> numbers = Arrays.stream(scanner.nextLine().split(" "))
                .map(Double::parseDouble).toList();

        TreeMap<Double, Integer> map = new TreeMap<>();

        int counter = 0;
        for (Double num : numbers)
        {
            if(map.containsKey(num))
            {
                map.put(num, counter++);
            }
            map.put(num,counter);
        }

        for (Map.Entry<Double,Integer> entry : map.entrySet())
        {
            DecimalFormat df = new DecimalFormat("#.#######");
            System.out.printf("%s -> %d%n",df.format(entry.getKey()), entry.getValue());
        }

    }
}