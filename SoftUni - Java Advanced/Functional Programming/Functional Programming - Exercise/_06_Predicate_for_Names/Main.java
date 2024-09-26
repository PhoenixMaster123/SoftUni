package exercise._06_Predicate_for_Names;

import java.util.Scanner;
import java.util.function.Predicate;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int length = Integer.parseInt(scanner.nextLine());
        String[] names = scanner.nextLine().split(" ");

        Predicate<String> checkNameLength = nameLength -> nameLength.length() <= length;

        for (String name : names)
        {
            if(checkNameLength.test(name))
            {
                System.out.println(name);
            }
        }
    }
}
