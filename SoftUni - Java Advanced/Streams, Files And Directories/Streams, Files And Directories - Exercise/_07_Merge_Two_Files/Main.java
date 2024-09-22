package exercise._07_Merge_Two_Files;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;

public class Main
{
    public static void main(String[] args)
    {
        String file1 = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\inputOne.txt";
        String file2 = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\inputTwo.txt";
        String fileToWrite = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\outputMergeTwoFiles.txt";

        try(BufferedReader readerFile1 = Files.newBufferedReader(Path.of(file1));
            BufferedReader readerFile2 = Files.newBufferedReader(Path.of(file2));
            BufferedWriter writer = Files.newBufferedWriter(Path.of(fileToWrite));)
        {
            mergeFiles(readerFile1, writer);
            mergeFiles(readerFile2, writer);
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
    }

    private static void mergeFiles(BufferedReader readFile, BufferedWriter writer) throws IOException
    {
        String line;
        while ((line = readFile.readLine()) != null)
        {
            writer.write(line);
            writer.newLine();
            writer.flush();
        }
    }
}
