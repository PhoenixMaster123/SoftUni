package exercise._02_Sum_Bytes;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;

public class Main
{
    public static void main(String[] args)
    {
        String path = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\input.txt";

        //Path path = Path.of()
        //Variant 3: -> with nio (new version -> more methods)

        try(BufferedReader reader = Files.newBufferedReader(Path.of(path)))
        {
            // It gives wrong result: Reason: read -> read also the empty space,
            //                        but readLine -> the whole line by line without the new line
            /*int b;
            long sum = 0;
            while ((b = reader.read()) != -1)
            {
                sum += b;
            }
            System.out.println(sum);
             */
            String line;
            long sum = 0;
            while ((line = reader.readLine()) != null)
            {
                for (char c : line.toCharArray())
                {
                    sum += c;
                }
            }
            System.out.println(sum);
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }

        // Variant 2: -> with Stream API
       /* try (BufferedReader reader = new BufferedReader(new FileReader(path))) {
            long sum = reader.lines().flatMapToInt(String::chars).sum();
            System.out.println(sum);
        } catch (IOException e) {
            e.printStackTrace(); // Print stack trace for better debugging
        }
        */


        // Variant 1: -> with io (old version)
        /*try(BufferedReader reader = new BufferedReader(new FileReader(path)))
        {
            String line;
            long sum = 0;
            while ((line = reader.readLine()) != null)
            {
                sum += sumASCIISymbols(line);
            }
            System.out.println(sum);
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
        */
    }

    /*private static long sumASCIISymbols(String line)
    {
        long sum = 0;
        for (char c : line.toCharArray())
        {
            sum += c;
        }
        return sum;
    }
         */
}
