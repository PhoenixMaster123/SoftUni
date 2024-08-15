import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        //////////////////////////// Variant 2 -> Optimized /////////////////////
                Scanner scanner = new Scanner(System.in);
                String encrypted = scanner.nextLine();

                List<Integer> digits = new ArrayList<>();
                List<Character> characters = new ArrayList<>();

                // Separate digits and characters
                for (char ch : encrypted.toCharArray()) {
                    if (Character.isDigit(ch)) {
                        digits.add(ch - '0'); // Convert char to int more directly
                    } else {
                        characters.add(ch);
                    }
                }

                int counter = 0;
                int digitsSize = digits.size();

                // Process digits and characters based on take/skip logic
                for (int i = 0; i < digitsSize; i += 2) {
                    int take = digits.get(i);
                    int skip = (i + 1 < digitsSize) ? digits.get(i + 1) : 0;

                    // Print 'take' characters
                    for (int j = 0; j < take && counter < characters.size(); j++) {
                        System.out.print(characters.get(counter++));
                    }

                    // Skip 'skip' characters
                    counter += skip;
                }
            }
        }


        ////////////////////////////// Variant 1 /////////////////////////
        /*
        Scanner scanner = new Scanner(System.in);

        String encrypted = scanner.nextLine();

        List<Integer> digits = new ArrayList<>();
        List<Character> characters = new ArrayList<>();

        char[] chars = encrypted.toCharArray();

        for (char ch : chars)
        {
            if(Character.isDigit(ch))
            {
                digits.add(Integer.parseInt(String.valueOf(ch)));
            }
            else
            {
                characters.add(ch);
            }
        }

        List<Integer> takeLst = new ArrayList<>();
        List<Integer> splitLst = new ArrayList<>();
        int count = 1;
        for (Integer digit : digits) {
            if (count % 2 != 0) {
                takeLst.add(digit);
            } else {
                splitLst.add(digit);
            }
            count++;
        }

        int counter = 0;
        for (int i = 0; i < takeLst.size(); i++)
        {
            int take = takeLst.get(i);
            int skip = splitLst.get(i);
            if (take == 0)
            {

            }
            else
            {
                for (int j = 0; j < take; j++)
                {
                    if (counter == characters.size())
                    {
                        break;
                    }
                    System.out.print(characters.get(counter));
                    counter++;
                }
            }
            if (skip == 0)
            {
                continue;
            }
            else
            {
                for (int j = 0; j < skip; j++)
                {
                    counter++;
                }
            }
        }
    }
         */
}