package exam_17_February_2024._01_Checken_Snack;

import java.util.ArrayDeque;
import java.util.Arrays;
import java.util.Deque;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] moneyAmount = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int[] foodPrices = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        Deque<Integer> stackMoney = new ArrayDeque<>();
        Deque<Integer> queueFoodPrice = new ArrayDeque<>();

        Arrays.stream(moneyAmount).forEach(stackMoney::push);
        Arrays.stream(foodPrices).forEach(queueFoodPrice::offer);

        int foodCounter = 0;

        while (!stackMoney.isEmpty() && !queueFoodPrice.isEmpty()) {

            int currentMoney = stackMoney.peek();
            int currentFootPrice = queueFoodPrice.peek();

            if(currentMoney == currentFootPrice) {
                stackMoney.pop();
                queueFoodPrice.poll();
                foodCounter++;
            }
            else if(currentMoney > currentFootPrice) {
                int money = stackMoney.pop();
                int price = queueFoodPrice.poll();

                if(!stackMoney.isEmpty()) {
                    int difference = money - price;
                    int secondMoney = stackMoney.pop();
                    stackMoney.push(difference + secondMoney);
                    foodCounter++;
                    continue;
                }
                stackMoney.push(money - price);

                foodCounter++;
            }
            else if(currentMoney < currentFootPrice) {
                stackMoney.pop();
                queueFoodPrice.poll();
            }
        }

        if(foodCounter >= 4) {
            System.out.println("Gluttony of the day! Henry ate " + foodCounter + " foods.");
        }
        else if(foodCounter < 4 && foodCounter != 0) {
            if(foodCounter == 1) {
                System.out.println("Henry ate: " + foodCounter + " food.");
            }
            else {
                System.out.println("Henry ate: " + foodCounter + " foods.");
            }

        }
        else {
            System.out.println("Henry remained hungry. He will try next weekend again.");
        }

    }
}
