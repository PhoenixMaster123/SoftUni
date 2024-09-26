package lab._05_Filter_by_Age;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.function.Consumer;
import java.util.function.Predicate;

public class Main
{

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        Map<String, Integer> namesMap = new LinkedHashMap<>();

        for (int i = 0; i < n; i++)
        {
            String[] tokens = scanner.nextLine().split(", ");
            namesMap.putIfAbsent(tokens[0], Integer.parseInt(tokens[1]));
        }

        String condition = scanner.nextLine();
        int ageLimit = Integer.parseInt(scanner.nextLine());
        String format = scanner.nextLine();

        Predicate<Integer> agePredicate;
        {
            if(condition.equals("younger"))
            {
                agePredicate = personAge -> personAge <= ageLimit;
            }
            else
            {
                agePredicate = personAge -> personAge >= ageLimit;
            }
        }
        Consumer<Map.Entry<String, Integer>> printFormat;

        if(format.equals("name"))
        {
            printFormat = entry -> System.out.println(entry.getKey());
        }
        else if(format.equals("age"))
        {
            printFormat = entry -> System.out.println(entry.getValue());
        }
        else
        {
            printFormat = entry -> System.out.println(entry.getKey() + " - " + entry.getValue());
        }
        namesMap.entrySet().stream()
                .filter(entry -> agePredicate.test(entry.getValue()))
                .forEach(printFormat);
    }
}
