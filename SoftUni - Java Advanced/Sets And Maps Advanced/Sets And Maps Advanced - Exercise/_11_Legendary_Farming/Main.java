package exercise._11_Legendary_Farming;

import java.util.*;

public class Main
{
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Map<String, Integer> keyMaterials = new TreeMap<>();
        Map<String, Integer> junkItems = new TreeMap<>();

        keyMaterials.putIfAbsent("shards", 0);
        keyMaterials.putIfAbsent("fragments", 0);
        keyMaterials.putIfAbsent("motes", 0);

        boolean isObtained = false;
        String legendaryItem = "";

        while (true)
        {
            String[] tokens = scanner.nextLine().split(" ");

            for (int i = 0; i < tokens.length; i += 2)
            {
                int quantity = Integer.parseInt(tokens[i]);
                String material = tokens[i + 1].toLowerCase();

                switch (material)
                {
                    case "shards":
                    case "fragments":
                    case "motes":
                        keyMaterials.put(material, keyMaterials.get(material) + quantity);

                        if(keyMaterials.get(material) >= 250)
                        {
                            isObtained = true;
                            legendaryItem = getItem(material);
                            keyMaterials.put(material, keyMaterials.get(material) - 250);
                        }
                        break;
                    default:
                        if(!junkItems.containsKey(material))
                        {
                            junkItems.putIfAbsent(material, quantity);
                        }
                        else
                        {
                            junkItems.put(material, junkItems.get(material) + quantity);
                        }
                        break;
                }
                if(isObtained)
                {
                    break;
                }
            }
            if(isObtained)
            {
                break;
            }
        }

        System.out.println(legendaryItem);

        keyMaterials.entrySet()
                .stream()
                .sorted((n1, n2) -> n2.getValue().compareTo(n1.getValue()))
                .forEach(material -> System.out.println(material.getKey() + ": " + material.getValue()));

        junkItems.forEach((key, value) -> System.out.println(key + ": " + value));

    }

    private static String getItem(String material)
    {
        return switch (material)
        {
            case "shards" -> "Shadowmourne obtained!";
            case "fragments" -> "Valanyr obtained!";
            case "motes" -> "Dragonwrath obtained!";
            default -> null;
        };
    }
}
