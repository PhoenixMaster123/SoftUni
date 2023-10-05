import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

// Press Shift twice to open the Search Everywhere dialog and type `show whitespaces`,
// then press Enter. You can now see whitespace characters in your code.
public class Main {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int participants = Integer.parseInt(sc.nextLine());
        ArrayList<String> people = new ArrayList<>();
        for (int i = 0; i < participants; i++) {
            String names = sc.nextLine();
            String[] item = names.split(" ");
            String name = item[0];
            String comming = item[2];

            if (comming.equals("not") && people.contains(name)) {
                people.remove(name);
                continue;
            }
            if (comming.equals("not") && !people.contains(name)) {
                System.out.printf("%s is not in the list!\n", name);
                continue;
            }
            if (people.contains(name)) {
                System.out.printf("%s is already in the list!\n", name);
            } else {
                people.add(name);
            }
        }
        for (int i = 0; i < people.size(); i++) {
            System.out.print(people.get(i));
            if (i < people.size() - 1) {
                System.out.println(" ");
            }
        }
    }
}