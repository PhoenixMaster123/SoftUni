package exercise._05_Line_Numbers;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;

public class Main
{
    public static void main(String[] args)
    {
        String pathToRead = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\inputLineNumbers.txt";
        String pathToWrite = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\outputInputLineNumbers.txt";

        try(BufferedReader reader = Files.newBufferedReader(Path.of(pathToRead));
            BufferedWriter writer = Files.newBufferedWriter(Path.of(pathToWrite)))
        {
            String line;
            int counter = 1;
            while ((line = reader.readLine()) != null)
            {
                writer.write(counter + ". " + line);
                writer.newLine();
                writer.flush();
                counter++;
            }
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
    }
}
