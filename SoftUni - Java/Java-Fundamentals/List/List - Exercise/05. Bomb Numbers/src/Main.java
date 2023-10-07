import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        List<Integer> numbers = Arrays.stream(sc.nextLine().split(" "))
                .map(Integer::parseInt)
                .collect(Collectors.toList());

        List<Integer> bombNumbers = Arrays.stream(sc.nextLine().split(" "))
                .map(Integer::parseInt)
                .collect(Collectors.toList());

        int bombNum = bombNumbers.get(0);
        int power = bombNumbers.get(1);
        int sum = 0;

        while (numbers.contains(bombNum)) {
            int index = numbers.indexOf(bombNum);
            int leftBound = Math.max(0, index - power);
            int rightBound = Math.min(numbers.size() - 1, index + power);

            for (int i = rightBound; i >= leftBound; i--) {
                numbers.remove(i);
            }
        }

        for (int number : numbers) {
            sum += number;
        }

        System.out.println(sum);
    }
}
