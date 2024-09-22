package lab._01_Read_File;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;

public class Main {
    public static void main(String[] args) throws IOException {


        String path = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\resources\\input.txt";

        // read byte to byte (1 symbol) from a file
        FileInputStream fileStream = new FileInputStream(path);

        int oneByte = fileStream.read(); // we read numbers from ASCII Table

        while (oneByte >= 0)
        {
            System.out.print(Integer.toBinaryString(oneByte) + " ");
            oneByte = fileStream.read();
        }
        fileStream.close();
    }
}