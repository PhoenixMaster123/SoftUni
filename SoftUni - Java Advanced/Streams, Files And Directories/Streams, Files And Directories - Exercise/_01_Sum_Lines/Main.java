package exercise._01_Sum_Lines;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.Arrays;

public class Main
{
    public static void main(String[] args)
    {
        String path = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\input.txt";

        try(BufferedReader reader = new BufferedReader(new FileReader(path)))
        {
            // Variant 1:
            /*String line;
            while ((line = reader.readLine()) != null)
            {
              int sum = sumASCIISymbols(line);
              System.out.println(sum);
            }
             */
            // Variant 2:
            String line = reader.readLine();
            while (line != null)
            {
                long sum = sumASCIISymbols(line);
                System.out.println(sum);
                line = reader.readLine();
            }

        }
        catch (IOException e)
        {
            e.printStackTrace();
        }

    }

    private static int sumASCIISymbols(String line)
    {
        int sum = 0;
        for (char c : line.toCharArray())
        {
            sum += c;
        }
        return sum;
    }
}
