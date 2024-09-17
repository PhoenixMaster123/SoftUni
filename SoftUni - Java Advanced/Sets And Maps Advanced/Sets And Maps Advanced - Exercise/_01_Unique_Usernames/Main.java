package exercise._01_Unique_Usernames;

import java.util.LinkedHashSet;
import java.util.Scanner;
import java.util.Set;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        Set<String> names = new LinkedHashSet<>();
        for (int i = 0; i < n; i++)
        {
            String name = scanner.nextLine();
            names.add(name);
        }
        names.forEach(System.out::println);
    }
}
