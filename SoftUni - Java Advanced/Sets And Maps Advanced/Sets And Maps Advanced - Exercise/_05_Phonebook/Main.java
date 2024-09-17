package exercise._05_Phonebook;

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        Map<String, String> phonebook = new HashMap<>();

        String input = scanner.nextLine();

        while (!input.equals("search"))
        {
            String[] tokens = input.split("-");
            String name = tokens[0];
            String phone = tokens[1];

            phonebook.put(name, phone);

            input = scanner.nextLine();
        }
        input = scanner.nextLine();
        while (!input.equals("stop"))
        {
            String searchName = input;

            if(phonebook.containsKey(searchName))
            {
                System.out.println(searchName + " -> " + phonebook.get(searchName));
            }
            else
            {
                System.out.println("Contact " + searchName + " does not exist.");
            }

            input = scanner.nextLine();
        }
    }

}
