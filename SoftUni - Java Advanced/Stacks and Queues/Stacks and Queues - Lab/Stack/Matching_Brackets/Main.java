package Stack.Matching_Brackets;

import java.util.ArrayDeque;
import java.util.Scanner;

public class Main {
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        ArrayDeque<Integer> indexes = new ArrayDeque<>();
        for (int i = 0; i < input.length(); i++)
        {
            if(input.charAt(i) == '(')
            {
                indexes.push(i); // that's the beginning of the range (push the start range)
            }
            else if(input.charAt(i) == ')')
            {
                int startIndex = indexes.pop(); // we take the start point from the stack
                String substring = input.substring(startIndex, i + 1); // take the substring
                System.out.println(substring); // print it
            }
        }
    }
}
