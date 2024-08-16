import java.util.*;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        List<String> words = Arrays.stream(scanner.nextLine().split(" "))
                .map(String::valueOf).toList();
        LinkedHashSet<String> result = new LinkedHashSet<>();
        for (int i = 0; i < words.size(); i++)
        {
            String current = words.get(i);

            if(count(current.toLowerCase(), words) % 2 != 0)
            {
                result.add(current.toLowerCase());
            }
        }
        System.out.println(result.stream().map(String::valueOf).collect(Collectors.joining(", ")));
    }

    private static int count(String current, List<String> words)
    {
        int n = 0;
        for (String word : words)
        {
            if(current.equals(word.toLowerCase()))
            {
                n++;
            }
        }
        return n;
    }
}