package exercise._04_Count_Character_Types;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.LinkedHashMap;
import java.util.Map;

public class Main
{
    public static void main(String[] args)
    {
        String pathToRead = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\input.txt";
        String pathToWrite = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\outputCountCharacters.txt";

        Map<String, Integer> map = new LinkedHashMap<>();
        map.putIfAbsent("Vowels:", 0);
        map.putIfAbsent("Other symbols:", 0);
        map.putIfAbsent("Punctuation:", 0);

        try(FileReader reader = new FileReader(pathToRead);
            PrintWriter writer = new PrintWriter(pathToWrite))
        {
            int b;
            while ((b = reader.read()) != -1)
            {
                if(Character.isWhitespace((char) b))
                {
                    continue;
                }
                else if(isVowel((char) b))
                {
                    map.put("Vowels:", map.get("Vowels:") + 1);
                }
                else if(isPunctuation((char) b))
                {
                    map.put("Punctuation:", map.get("Punctuation:") + 1);
                }
                else
                {
                    map.put("Other symbols:", map.get("Other symbols:") + 1);
                }
            }
            for (Map.Entry<String, Integer> integerEntry : map.entrySet())
            {
                writer.write(integerEntry.getKey() + " " + integerEntry.getValue() + "\n");
            }
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }

    }

    private static boolean isPunctuation(char c)
    {
        return c == '?' || c == ',' || c == '.' || c == '!';
    }

    private static boolean isVowel(char c)
    {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}
