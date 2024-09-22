package lab._04_Extract_Integers;

import java.io.FileInputStream;
import java.io.FileReader;
import java.io.IOException;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args) throws IOException {

        String path = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\resources\\input.txt";

        FileInputStream fileInputStream = new FileInputStream(path);
        Scanner scanner = new Scanner(fileInputStream);

        while (scanner.hasNext()) // while I have next argument (if I have next element)
        {
            if(scanner.hasNextInt()) // if the next element is an int digit
            {
                System.out.println(scanner.nextInt());
            }
            scanner.next(); // go to the next element
        }



    }
}
