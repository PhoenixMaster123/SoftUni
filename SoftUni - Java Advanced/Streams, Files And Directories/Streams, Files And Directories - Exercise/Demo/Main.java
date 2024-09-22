package exercise.Demo;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        /*
        FileInputStream, FileOutputStream -> read and write byte by byte
        FileReader, FileWriter -> read and write character by character
        Scanner(InputStream) -> read from the console
        PrintWriter -> uses writer
        BufferedReader, BufferedWriter -> uses Reader and Writer
         */

        String path = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\input.txt";

        // When we have try-catch the code continue | Otherwise the programm will close when we catch the exception
        /*try(FileInputStream fis = new FileInputStream(path))
        {
           int oneByte = fis.read();
           while (oneByte != -1)
           {
               //System.out.print(Integer.toBinaryString(oneByte) + " \n");
               System.out.print((char) oneByte);
               oneByte = fis.read();
           }
        } catch (IOException e) {
            e.printStackTrace();
        }
         */

        try(FileReader fr = new FileReader(path))
        {
            int oneByte = fr.read();

            while (oneByte != -1)
            {
                System.out.print((char) oneByte);
                oneByte = fr.read();
            }
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }

    }
}
