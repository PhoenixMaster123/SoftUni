package exam_10_April_2024._01_Pie_Pursuit;

import java.util.*;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] contestants = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int[] pies = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        Deque<Integer> queueContestants = new ArrayDeque<>();
        Deque<Integer> stackPies = new ArrayDeque<>();

        Arrays.stream(contestants).forEach(queueContestants::offer);
        Arrays.stream(pies).forEach(stackPies::push);

        while (!queueContestants.isEmpty() && !stackPies.isEmpty()) {

            int currentContestant = queueContestants.poll();
            int currentPie = stackPies.pop();

            if(currentContestant >= currentPie) {
                currentContestant -= currentPie;
                if(currentContestant <= 0) {
                    continue;
                }
                // Move to the back of the line
                queueContestants.offer(currentContestant);
            }
            else if(currentPie > currentContestant) {
                currentPie -= currentContestant;
                if(currentPie == 1 && stackPies.size() > 1) {
                    stackPies.push(stackPies.pop() + 1);
                    continue;
                }
                stackPies.push(currentPie);
            }
        }

        if(stackPies.isEmpty() && !queueContestants.isEmpty()) {
            System.out.println("We will have to wait for more pies to be baked!");
            String s = queueContestants.stream().map(String::valueOf).collect(Collectors.joining(", "));
            System.out.println("Contestants left: " + s);

        }
        else if(stackPies.isEmpty() && queueContestants.isEmpty()) {
            System.out.println("We have a champion!");
        }
        else {
            System.out.println("Our contestants need to rest!");
            String s = stackPies.stream().map(String::valueOf).sorted(Comparator.naturalOrder()).collect(Collectors.joining(", "));
            System.out.println("Pies left: " + s);
        }

    }
}
