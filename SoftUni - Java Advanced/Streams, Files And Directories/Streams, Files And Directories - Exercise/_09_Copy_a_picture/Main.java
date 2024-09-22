package exercise._09_Copy_a_picture;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;

public class Main
{
    public static void main(String[] args) {

        String pathPicture = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\FireSummer.jpg";
        String pathToCopyThePicture = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\copy-picture.jpg";

        try(FileInputStream fis = new FileInputStream(pathPicture);
            FileOutputStream fos = new FileOutputStream(pathToCopyThePicture))
        {
            byte[] inputBytes = fis.readAllBytes();
            fos.write(inputBytes);
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
    }
}
