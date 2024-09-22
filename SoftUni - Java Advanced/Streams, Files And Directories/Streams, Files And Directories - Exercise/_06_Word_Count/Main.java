package exercise._06_Word_Count;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.PrintWriter;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.*;

public class Main
{
    public static void main(String[] args)
    {
        Map<String, Integer> wordCounter = new HashMap<>();

        String pathToReadWords = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\words.txt";
        String pathToReadWordsContains = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\text.txt";
        String pathToWrite = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\result.txt";


        try(BufferedReader wordsReader = Files.newBufferedReader(Path.of(pathToReadWords));
            BufferedReader containsReader = Files.newBufferedReader(Path.of(pathToReadWordsContains));
            PrintWriter writer = new PrintWriter(pathToWrite))
            {
                Set<String> words = addToSet(wordsReader);

                addToMap(wordCounter, words);

                String line;
                while ((line = containsReader.readLine()) != null)
                {
                    List<String> currentLine = Arrays.stream(line.split(" ")).toList();

                    for (String searchCurrentWord : currentLine) {
                        for (String originalWord : wordCounter.keySet()) {
                            // If the original word starts with an uppercase letter
                            if (Character.isUpperCase(originalWord.charAt(0))) {
                                // Match only if the search word also starts with an uppercase letter (case-sensitive)
                                if (originalWord.equals(searchCurrentWord)) {
                                    wordCounter.put(originalWord, wordCounter.get(originalWord) + 1);
                                    break;
                                }
                            } else {
                                // Match in a case-insensitive way for non-uppercase words
                                if (originalWord.equalsIgnoreCase(searchCurrentWord)) {
                                    wordCounter.put(originalWord, wordCounter.get(originalWord) + 1);
                                    break;
                                }
                            }
                        }
                    }
                }

                wordCounter.entrySet().stream()
                        .sorted((n1, n2) -> n2.getValue().compareTo(n1.getValue()))
                        .forEach(word -> writer.write(word.getKey() + " - " + word.getValue() + "\n"));

            }
        catch (IOException e)
        {
            e.printStackTrace();
        }


    }

    private static void addToMap(Map<String, Integer> wordCounter, Set<String> words)
    {
        for (String word : words) {
            wordCounter.putIfAbsent(word, 0);
        }
    }

    private static Set<String> addToSet(BufferedReader wordsReader) throws IOException
    {
        Set<String> set = new HashSet<>();

        String line;
        while ((line = wordsReader.readLine()) != null)
        {
            String[] words = line.split(" ");

            set.addAll(List.of(words));
        }
        return set;
    }

}
