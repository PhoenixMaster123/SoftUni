package exercise._06_Fix_Emails;

import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        Map<String, String> workerEmails = new LinkedHashMap<>();

        String input = scanner.nextLine();

        while (!input.equals("stop"))
        {
            String name = input;
            String email = scanner.nextLine();

            if(!email.endsWith("us") && !email.endsWith("uk") && !email.endsWith("com"))
            {
                workerEmails.put(name, email);
            }

            input = scanner.nextLine();
        }

        for(Map.Entry<String, String> entry : workerEmails.entrySet())
        {
            System.out.println(entry.getKey() + " -> " + entry.getValue());
        }
    }
}
