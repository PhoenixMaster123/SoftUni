import java.util.*;
import java.util.stream.Collectors;

public class Main {
    public static void main(String[] args) {
        ///////////////////////// Variant 1 /////////////////////////////////////

       /* Scanner scanner = new Scanner(System.in);
        List<Integer> numbers = Arrays.stream(scanner.nextLine().split(" "))
                .map(Integer::parseInt)
                .toList();
        String text = scanner.nextLine();
        char[] textSize = text.toCharArray();

        List<Character> text2 = new ArrayList<>();

        for (char c : textSize)
        {
            text2.add(c);
        }

        int sum = 0;
        int counter = 0;
        for (int i = 0; i < numbers.size(); i++)
        {
            String str = String.valueOf(numbers.get(i));
            char[] chars = str.toCharArray();
            for (char ch : chars)
            {
                sum += Integer.parseInt(String.valueOf(ch));
            }
            for (int j = 0; j <= text2.size(); j++)
            {
                if(j >= text2.size())
                {
                    j = 0;
                }
                else if(counter == sum)
                {
                    System.out.print(text2.get(j));
                    text2.remove(j);
                    break;
                }
                counter++;
            }
            sum = 0;
            counter = 0;
        }
    }
        */
        ///////////////////////// Variant 2 /////////////////////////////////////
                Scanner scanner = new Scanner(System.in);

                // Parsing the numbers
                List<Integer> numbers = Arrays.stream(scanner.nextLine().split(" "))
                        .map(Integer::parseInt)
                        .toList();

                // Converting the text into a List of Characters
                List<Character> textCharacters = scanner.nextLine()
                        .chars()
                        .mapToObj(c -> (char) c)
                        .toList();

                // Iterating over each number
                for (int number : numbers) {
                    int sumOfDigits = sumDigits(number);

                    // Find the character to print based on the sum of digits
                    int index = sumOfDigits % textCharacters.size();
                    System.out.print(textCharacters.get(index));

                    // Remove the used character from the list
                    textCharacters.remove(index);

                    // If no characters are left, break the loop
                    if (textCharacters.isEmpty()) {
                        break;
                    }
                }
            }

            // Method to calculate the sum of digits of a number
            private static int sumDigits(int number) {
                int sum = 0;
                while (number != 0) {
                    sum += number % 10;
                    number /= 10;
                }
                return sum;
            }
        }
    }
}