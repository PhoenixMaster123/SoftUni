package lab._03_Copy_Bytes;

import java.io.*;

public class Main
{
    public static void main(String[] args){

        String pathToRead = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\resources\\input.txt";
        String pathToWrite = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\resources\\03.CopyBytesOutput.txt";


        try (FileReader reader = new FileReader(pathToRead);
             FileWriter writer = new FileWriter(pathToWrite))
        {
            int oneByte = reader.read();
            while (oneByte >= 0)
            {
                // If the byte is a space or newline, we write it as is
                if (oneByte == ' ' || oneByte == '\n') {
                    writer.write(oneByte);
                } else {
                    // Convert the byte to its string numeric representation
                    String byteAsString = String.valueOf(oneByte);
                    // Write each character of the string representation
                    for (char c : byteAsString.toCharArray()) {
                        writer.write(c);
                    }
                }
                oneByte = reader.read();
            }
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
    }
}
