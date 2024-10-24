
package _06_Greedy_Times;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        long bagCapacity = Long.parseLong(scanner.nextLine());
        String[] safe = scanner.nextLine().split("\\s+");

        Bag bag = new Bag(bagCapacity);


        for (int i = 0; i < safe.length; i += 2) {
            String itemName = safe[i];
            long amount = Long.parseLong(safe[i + 1]);

            ItemType itemType = ItemType.getItem(itemName);
            Item item = new Item(itemName, itemType, amount);

            bag.add(item);

        }
        bag.printBack();
    }
}