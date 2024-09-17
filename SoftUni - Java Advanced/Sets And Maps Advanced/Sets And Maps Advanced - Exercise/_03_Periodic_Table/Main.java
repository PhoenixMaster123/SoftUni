package exercise._03_Periodic_Table;

import java.util.*;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        Set<String> table = new TreeSet<>();

        for (int i = 0; i < n; i++) {

            String[] elements = scanner.nextLine().split(" ");

           /* for (String element : elements)
            {
                table.add(element);
            }
            */
            // Short Version:
            //table.addAll(Arrays.asList(elements));
            Collections.addAll(table, elements);
        }
        table.forEach(ele -> System.out.print(ele + " "));
    }
}
