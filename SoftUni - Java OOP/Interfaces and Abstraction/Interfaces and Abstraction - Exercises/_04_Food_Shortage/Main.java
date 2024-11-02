package _04_Food_Shortage;

import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        Map<String , Buyer> buyerMap = new HashMap<>();

        int totalFoodAmount = 0;

        for (int i = 0; i < n; i++) {
            String[] tokens = scanner.nextLine().split(" ");

            switch (tokens.length) {
                case 4:
                    String name = tokens[0];
                    int age = Integer.parseInt(tokens[1]);
                    String id = tokens[2];
                    String birthday = tokens[3];

                    Buyer citizen = new Citizen(name, age, id, birthday);
                    buyerMap.putIfAbsent(name, citizen);
                    break;
                case 3:
                    name = tokens[0];
                    age = Integer.parseInt(tokens[1]);
                    String group = tokens[2];

                    Buyer rebel = new Rebel(name, age, group);
                    buyerMap.putIfAbsent(name, rebel);
                    break;
            }
        }
            String line = scanner.nextLine();

            while (!"End".equals(line)) {
                    if(buyerMap.containsKey(line)) {
                        Buyer currentBuyer = buyerMap.get(line);
                        currentBuyer.buyFood();
                        totalFoodAmount += currentBuyer.getFood();
                    }
                line = scanner.nextLine();
            }
            System.out.println(totalFoodAmount);
    }
}
