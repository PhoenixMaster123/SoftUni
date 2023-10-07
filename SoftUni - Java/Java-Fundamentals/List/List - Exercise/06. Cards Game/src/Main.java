import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        List<Integer> first = Arrays.stream(sc.nextLine().split(" "))
                .map(Integer::parseInt)
                .collect(Collectors.toList());

        List<Integer> second = Arrays.stream(sc.nextLine().split(" "))
                .map(Integer::parseInt)
                .collect(Collectors.toList());
        int size = first.size();
        int sumFirstPlayer = 0;
        int sumSecondPlayer = 0;

        for (int i = 0; i < size ; i++)
        {
            i=0;
            if(first.isEmpty() || second.isEmpty())
            {
               break;
            }
            if(first.get(i) > second.get(i))
            {
                int elementToRemoveFirst = first.get(i);  // Store the element
                first.remove(i);  // Remove the element
                first.add(elementToRemoveFirst);
                int elementToRemoveSecond = second.get(i);
                second.remove(i);
                first.add(elementToRemoveSecond);

            }
            else if(first.get(i).equals(second.get(i)))
            {
                first.remove(first.get(i));
                second.remove(second.get(i));
            }
            else
            {
                int elementToRemoveSecond = second.get(i);
                second.remove(i);
                second.add(elementToRemoveSecond);
                int elementToRemoveFirst = first.get(i);  // Store the element
                first.remove(i);  // Remove the element
                second.add(elementToRemoveFirst);
            }
        }
        if(first.isEmpty())
        {
            for (int i = 0; i < second.size(); i++) {
                sumSecondPlayer += second.get(i);
            }
        }
        else {
            for (int i = 0; i < first.size(); i++) {
                sumFirstPlayer += first.get(i);
            }
        }
        if(first.size() > second.size())
        {
            System.out.printf("First player wins! Sum: %d", sumFirstPlayer);
        }
        else
        {
            System.out.printf("Second player wins! Sum: %d", sumSecondPlayer);
        }

    }
}