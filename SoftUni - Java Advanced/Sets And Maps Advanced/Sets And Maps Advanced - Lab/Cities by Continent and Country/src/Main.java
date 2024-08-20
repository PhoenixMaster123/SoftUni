import java.util.*;

public class Main {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        LinkedHashMap<String, LinkedHashMap<String, List<String>>> countries = new LinkedHashMap<>();

        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < n; i++)
        {
            String[] items = scanner.nextLine().split(" ");
            String continent  = items[0];
            String country = items[1];
            String city = items[2];

            countries.computeIfAbsent(continent, k -> new LinkedHashMap<>())
                    .computeIfAbsent(country, k -> new LinkedList<>()).add(city);
        }

        for (String continent : countries.keySet()) {
            System.out.println(String.format("%s:", continent));
            LinkedHashMap<String, List<String>> countriesInContinent = countries.get(continent);

            for (String country : countriesInContinent.keySet()) {
                List<String> cities = countriesInContinent.getOrDefault(country, Collections.emptyList());
                System.out.println(String.format("  %s -> %s", country, String.join(", ", cities)));
            }
        }
    }
}