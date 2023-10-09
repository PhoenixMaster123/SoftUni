import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
        List<String> listOfLists = Arrays.asList(input.split("\\|"));
        List<String> result = new ArrayList<>();

        for (int i = listOfLists.size() - 1; i >= 0; i--) {
            String[] currentList = listOfLists.get(i).split("\\s+");
            for (String item : currentList) {
                if (!item.isEmpty()) {
                    result.add(item);
                }
            }
        }

        System.out.println(String.join(" ", result));
    }
}
