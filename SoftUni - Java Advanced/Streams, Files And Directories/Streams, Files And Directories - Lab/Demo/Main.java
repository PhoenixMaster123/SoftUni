package lab.Demo;

import java.io.*;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args) throws IOException {

        // Streams are used to transfer data

        // Two types of Streams:

        // 1. InputStream  (read information) (we open source of data)
        // 2. OutputStream (write information)

        // FileInputStream => only read symbols from ASCII Table

        // FileReader  => read so many symbols not only from ASCII Table but from UTF-8/16

        // => flush()  => make the changes until now but not closing

        String path = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\resources\\demo";
        FileInputStream fileInputStream = new FileInputStream(path);

        /*FileReader fileReader = new FileReader(path); // read bytes (images)

        //System.out.print((char) fileReader.read());
        FileWriter fileWriter = new FileWriter(path);
        fileWriter.write("123");

        fileWriter.flush();
        fileWriter.close();
         */
        String txtFile = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\resources\\input.txt";
        Scanner scanner = new Scanner(fileInputStream); // read from a file
        Scanner scanner1 = new Scanner(System.in);

        // String firstLine = scanner.nextLine();
        //String secondLine = scanner.nextLine();
        String line = scanner1.nextLine();

        fileInputStream.close();

        String pathToWrite = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\resources\\demo";
        FileOutputStream fileOutputStream = new FileOutputStream(pathToWrite);
        PrintWriter printWriter = new PrintWriter(fileOutputStream); // write from a file
        printWriter.println("Java Advanced");
        printWriter.println("SoftUni");
        printWriter.println("2024");
        printWriter.println(line);
        printWriter.flush();
        printWriter.close();
    }
}
