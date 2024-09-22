package lab._05_Write_Every_Third_Line;

import java.io.*;

public class Main
{
    public static void main(String[] args)
    {
        String path = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\resources\\input.txt";
        String pathToWrite = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\resources\\05.WriteEveryThirdLineOutput.txt";

        int counter = 1;
        try(BufferedReader reader = new BufferedReader(new FileReader(path));
            BufferedWriter writer = new BufferedWriter(new FileWriter(pathToWrite)))
        {
            String line;
            while ((line = reader.readLine()) != null)
            {
                if(counter % 3 == 0)
                {
                    writer.write(line);
                    writer.flush();
                    writer.newLine();
                }
                counter++;
            }
        }
        catch (IOException e)
        {
            e.getStackTrace();
        }
    }
}
