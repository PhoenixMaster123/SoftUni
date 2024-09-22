package lab._06_Sort_Lines;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.Collections;
import java.util.List;

public class Main
{
    public static void main(String[] args) throws IOException {

        Path path = Path.of("C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\resources\\input.txt");
        List<String> lines = Files.readAllLines(path);

        Collections.sort(lines);

        lines.forEach(System.out::println);
    }
}
