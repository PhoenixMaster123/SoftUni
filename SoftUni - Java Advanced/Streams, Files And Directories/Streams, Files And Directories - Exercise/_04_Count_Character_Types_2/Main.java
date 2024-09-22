package exercise._04_Count_Character_Types_2;

import java.io.*;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.HashSet;
import java.util.Set;

public class Main
{
    public static void main(String[] args) {

        String pathToRead = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\input.txt";
        String pathToWrite = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\outputCountCharacters.txt";

        int vowels = 0;
        int otherSymbols = 0;
        int punctuation = 0;

        Set<Character> vowelsSet = Set.of('a', 'e', 'i','o', 'u');
        Set<Character> punctuationSet = Set.of('!', ',', '.','?');


        try(FileReader fileReader = new FileReader(pathToRead);
            PrintStream print = new PrintStream(Files.newOutputStream(Path.of(pathToWrite))))
        {
            int read = fileReader.read();

            while (read != -1)
            {
                char symbol = (char) read;
                // If I read with BufferedReader every line I can replaceAll whiteSpaces (Variant 2)
                if(Character.isWhitespace(symbol))
                {
                    read = fileReader.read();
                    continue;
                }
                else if(vowelsSet.contains(symbol))
                {
                    vowels++;
                }
                else if(punctuationSet.contains(symbol))
                {
                    punctuation++;
                }
                else
                {
                    otherSymbols++;
                }
                read = fileReader.read();
            }
            print.printf("Vowels: %d\n", vowels);
            print.printf("Other symbols: %d\n", otherSymbols);
            print.printf("Punctuations: %d", punctuation);
        }
        catch (IOException e)
        {
            e.printStackTrace();
        }
    }
}
