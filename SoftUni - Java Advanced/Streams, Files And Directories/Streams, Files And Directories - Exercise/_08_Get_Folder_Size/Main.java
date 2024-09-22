package exercise._08_Get_Folder_Size;

import java.io.File;

public class Main
{
    public static void main(String[] args){
        String path = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\Exercises Resources";

        File directory = new File(path);
        long size = 0;
        if(directory.isDirectory())
        {
            File[] files = directory.listFiles();

            for (File file : files)
            {
                if(!file.isDirectory())
                {
                    size += file.length();
                }
            }
        }
        System.out.printf("Folder size: %d", size);
    }
}
