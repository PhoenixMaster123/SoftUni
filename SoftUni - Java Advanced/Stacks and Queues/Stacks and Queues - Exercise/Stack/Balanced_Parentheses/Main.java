package Stack.Balanced_Parentheses;

import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Read input and convert to list of characters
        String input = scanner.nextLine();
        String result = isBalanced(input) ? "YES" : "NO";

        System.out.print(result);
    }

    private static boolean isBalanced(String brackets) {
        Deque<Character> openBrackets = new ArrayDeque<>();

        for (char bracket : brackets.toCharArray()) {
            switch (bracket) {
                case '}':
                    if (openBrackets.isEmpty() || openBrackets.pop() != '{') {
                        return false;
                    }
                    break;
                case ']':
                    if (openBrackets.isEmpty() || openBrackets.pop() != '[') {
                        return false;
                    }
                    break;
                case ')':
                    if (openBrackets.isEmpty() || openBrackets.pop() != '(') {
                        return false;
                    }
                    break;
                /*
                case '{':
                case '[':
                case '(':
                    openBrackets.push(bracket);
                    break;
                 */
                default:
                    // If input contains characters other than brackets, you can handle it here
                    openBrackets.push(bracket);
                    break;
            }
        }

        return openBrackets.isEmpty();
    }
}
