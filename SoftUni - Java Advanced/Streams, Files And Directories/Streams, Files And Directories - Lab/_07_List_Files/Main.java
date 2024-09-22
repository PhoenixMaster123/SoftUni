package lab._07_List_Files;

import java.io.File;

public class Main
{
    public static void main(String[] args)
    {
        File folder = new File("C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\resources\\Files-and-Streams");

       File[] files = folder.listFiles();

        for (File file : files)
        {
            if(!file.isDirectory())
            {
                System.out.printf("%s: [%d]\n", file.getName(), file.length());
            }
        }
    }
}
