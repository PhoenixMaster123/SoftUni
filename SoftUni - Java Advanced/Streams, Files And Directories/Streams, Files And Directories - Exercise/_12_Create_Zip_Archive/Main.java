package exercise._12_Create_Zip_Archive;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.List;
import java.util.zip.ZipEntry;
import java.util.zip.ZipOutputStream;

public class Main
{
    public static void main(String[] args) {

        String inputPath1 = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\input.txt";
        String inputPath2 = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\inputOne.txt";
        String inputPath3 = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\inputTwo.txt";
        String outputFileZip = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\files.zip";

        List<String> inputPaths = List.of(inputPath1, inputPath2, inputPath3);
        try(FileOutputStream fos = new FileOutputStream(outputFileZip);
            ZipOutputStream zip = new ZipOutputStream(fos);
            FileInputStream read1 = new FileInputStream(inputPath1))
        {
            for (String path : inputPaths)
            {
                File fileToZip = new File(path);
                FileInputStream fileInputStream = new FileInputStream(fileToZip);
                ZipEntry zipEntry = new ZipEntry(fileToZip.getName());
                zip.putNextEntry(zipEntry);

                int read = fileInputStream.read();

                while (read != -1)
                {
                    zip.write(read);
                    read = fileInputStream.read();
                }
                fileInputStream.close();
            }
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
    }
}
