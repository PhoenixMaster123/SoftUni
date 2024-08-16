import java.util.*;

public class Main {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        LinkedHashMap<String, ArrayList<String>> dictionary = new LinkedHashMap<>();
        for (int i = 0; i < n; i++)
        {
            String word = scanner.nextLine();
            String synonym = scanner.nextLine();

            dictionary.putIfAbsent(word, new ArrayList<>());
            dictionary.get(word).add(synonym);
        }
        for (Map.Entry<String, ArrayList<String>> entry : dictionary.entrySet()) {
            String word = entry.getKey();
            List<String> synonyms = entry.getValue();
            System.out.println(word + " - " + String.join(", ", synonyms));
        }
    }
}