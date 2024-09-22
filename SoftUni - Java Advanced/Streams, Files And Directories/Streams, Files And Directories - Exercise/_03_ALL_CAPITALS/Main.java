package exercise._03_ALL_CAPITALS;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.Locale;

public class Main
{
    public static void main(String[] args)
    {
        String pathToRead = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\input.txt";
        String pathToWrite = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\output.txt";

        // This is new version of io -> nio
        try(BufferedReader reader = Files.newBufferedReader(Path.of(pathToRead));
            BufferedWriter writer = Files.newBufferedWriter(Path.of(pathToWrite)))
        {
            String line;
            while ((line = reader.readLine()) != null)
            {
             // line = line.toUpperCase();
              writer.write(line.toUpperCase());
              writer.newLine();
              writer.flush();
            }
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
    }
}
