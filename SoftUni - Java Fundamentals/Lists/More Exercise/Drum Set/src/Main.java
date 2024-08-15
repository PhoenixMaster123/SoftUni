import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        double savings = Double.parseDouble(scanner.nextLine());
        List<Integer> quality = Arrays.stream(scanner.nextLine().split(" "))
                .map(Integer::parseInt).toList();

        List<Integer> copy = new ArrayList<>(quality);

        while (true) {
            String text = scanner.nextLine();
            if (text.equals("Hit it again, Gabsy!")) {

                String str = copy.stream().filter(n -> n > 0).map(String::valueOf).collect(Collectors.joining(" "));
                System.out.println(str);
                System.out.printf("Gabsy has %.2flv.", savings);
                break;
            }
            for (int i = 0; i < quality.size(); i++)
            {
                copy.set(i, copy.get(i) - Integer.parseInt(text));
                if (copy.get(i) <= 0) {
                    if (savings >= quality.get(i) * 3) {
                        copy.set(i, quality.get(i));
                        savings -= quality.get(i) * 3;
                    }
                }

            }
        }
    }
}