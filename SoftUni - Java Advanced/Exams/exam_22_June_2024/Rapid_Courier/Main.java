package exam_22_June_2024.Rapid_Courier;

import java.util.*;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // values = weight
        int[] packages = Arrays.stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();

        // values = capacities
        int[] couriers = Arrays.stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt).toArray();

        ArrayDeque<Integer> stack = new ArrayDeque<>();
        ArrayDeque<Integer> queue = new ArrayDeque<>();

        Arrays.stream(packages).forEach(stack::push);
        Arrays.stream(couriers).forEach(queue::offer);

        int weightSum = 0;
        while (!stack.isEmpty() && !queue.isEmpty()) {

            int lastPackage = stack.peek();
            int firstCourier = queue.peek();

            if(lastPackage == firstCourier) {
                weightSum += stack.pop();
                queue.poll();
            }
            else if(firstCourier > lastPackage) {
                firstCourier = firstCourier - (lastPackage * 2);
                queue.poll();
                weightSum += stack.pop();
                if(firstCourier > 0) {
                    queue.offerLast(firstCourier);
                }
            }
            else if(firstCourier < lastPackage) {
                weightSum += firstCourier;
                firstCourier = Math.abs(firstCourier - lastPackage);
                stack.pop();
                queue.poll();
                stack.push(firstCourier);
            }
        }
        if(stack.isEmpty() && queue.isEmpty()) {
            System.out.println("Total weight: " + weightSum + " kg");
            System.out.println("Congratulations, all packages were delivered successfully by the couriers today.");
        }
        else if(queue.isEmpty()){
            ArrayDeque<Integer> result = new ArrayDeque<>(stack.reversed());
            System.out.println("Total weight: " + weightSum + " kg");
            System.out.print("Unfortunately, there are no more available couriers to deliver the following packages: ");
            String s = result.stream().map(String::valueOf).collect(Collectors.joining(", "));
            System.out.print(s);
        }
        else {
            System.out.println("Total weight: " + weightSum + " kg");
            System.out.print("Couriers are still on duty: ");
            String s = queue.stream().map(String::valueOf).collect(Collectors.joining(", "));
            System.out.print(s);
            System.out.println(" but there are no more packages to deliver.");
        }
    }
}

