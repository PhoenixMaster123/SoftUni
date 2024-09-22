package lab._02_Write_to_File;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;

public class Main
{
    public static void main(String[] args)
    {

        String pathToRead = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\resources\\input.txt";
        String pathToWrite = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\resources\\02.WriteToFileOutput.txt";
        // Read a file:
        try(FileInputStream fileInputStream = new FileInputStream(pathToRead);
            FileOutputStream fileOutputStream = new FileOutputStream(pathToWrite))
        {
            int oneByte = fileInputStream.read();
            while (oneByte >= 0) {
                char currentChar = (char) oneByte;
                if (currentChar != ',' && currentChar != '.' && currentChar != '!' && currentChar != '?') {
                    fileOutputStream.write(oneByte);
                }
                oneByte = fileInputStream.read();
            }
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
    }
}
