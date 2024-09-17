package lab._06_Product_Shop;

import java.util.*;

public class Main
{
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Map<String, LinkedHashMap<String, Double>> shops = new TreeMap<>();

        String input = scanner.nextLine();

        while (!input.equals("Revision"))
        {
            String[] tokens = input.split(", ");

            String shop = tokens[0];
            String product = tokens[1];
            double price = Double.parseDouble(tokens[2]);

            // Variant 1:
            shops.putIfAbsent(shop, new LinkedHashMap<>());
            LinkedHashMap<String, Double> innerData = shops.get(shop);
            innerData.putIfAbsent(product, price);

            // Variant 2:
           //shops.computeIfAbsent(shop, k -> new LinkedHashMap<>()).put(product, price);

            input = scanner.nextLine();
        }

        for(Map.Entry<String, LinkedHashMap<String, Double>> entry : shops.entrySet())
        {

            System.out.println(entry.getKey() + "->");
            LinkedHashMap<String, Double> innerData = entry.getValue();
            for (Map.Entry<String, Double> innerEntry : innerData.entrySet())
            {
                System.out.printf("Product: %s, Price: %.1f\n", innerEntry.getKey(), innerEntry.getValue());
            }


        }
    }
}
