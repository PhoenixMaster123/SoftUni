import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        List<Integer> player1 = Arrays.stream(scanner.nextLine().split(" "))
                .map(Integer::parseInt).toList();
        List<Integer> player2 = Arrays.stream(scanner.nextLine().split(" "))
                .map(Integer::parseInt).toList();

        Set<Integer> copy1 = new LinkedHashSet<>(player1);
        Set<Integer> copy2 = new LinkedHashSet<>(player2);
        int counter = 1;
        while (!copy1.isEmpty() && !copy2.isEmpty() && counter != 50) {

            int firstNumber = copy1.iterator().next();
            copy1.remove(firstNumber);
            int secondNumber = copy2.iterator().next();
            copy2.remove(secondNumber);

            if (firstNumber > secondNumber) {
                copy1.add(firstNumber);
                copy1.add(secondNumber);
            } else if (secondNumber > firstNumber) {
                copy2.add(firstNumber);
                copy2.add(secondNumber);
            }
            counter++;
        }

        if(copy1.isEmpty())
        {
            System.out.println("Second player win!");
        }
        else if(copy2.isEmpty())
        {
            System.out.println("First player win!");
        }
        else
        {
            double sum1 = copy1.stream().mapToDouble(n -> n).sum();
            double sum2 = copy2.stream().mapToDouble(n -> n).sum();

            if(sum1 > sum2)
            {
                System.out.println("First player win!");
            } else if (sum1 < sum2)
            {
                System.out.println("Second player win!");
            }
            else
            {
                System.out.println("Draw!");
            }
        }


    }
}