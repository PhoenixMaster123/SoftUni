package exercise._11_Cat_Lady;

import java.util.*;
import java.util.stream.Stream;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String line = scanner.nextLine();
       // List<Cat> catList = new ArrayList<>();
        Map<String, Cat> catMap = new HashMap<>();
        while (!"End".equals(line)) {
            String[] tokens = line.split(" ");
            String typeCat = tokens[0];
            String catName = tokens[1];
            double value = Double.parseDouble(tokens[2]);

            Cat cat = null;
            cat = switch (typeCat) {
                case "Siamese" -> new Siamese(catName, typeCat, value);
                case "Cymric" -> new Cymric(catName, typeCat, value);
                case "StreetExtraordinaire" -> new StreetExtraordinaire(catName, typeCat, value);
                default -> cat;
            };
            catMap.putIfAbsent(catName, cat);


            line = scanner.nextLine();
        }
        String searchCat = scanner.nextLine();

        Cat cat = catMap.get(searchCat);
         System.out.println(cat);

    }
}
