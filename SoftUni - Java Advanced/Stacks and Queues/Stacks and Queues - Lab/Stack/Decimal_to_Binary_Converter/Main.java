package Stack.Decimal_to_Binary_Converter;

import java.util.ArrayDeque;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int num = Integer.parseInt(scanner.nextLine());

        ArrayDeque<String> stack = new ArrayDeque<>();

        if(num == 0)
        {
            System.out.println(num);
        }

        while (num != 0)
        {
            stack.push(String.valueOf(num % 2));
            num /= 2;
        }
        int length = stack.size();
        stack.reversed();
        for (int i = 0; i < length; i++)
        {
            System.out.print(stack.pop());
        }
    }
}
