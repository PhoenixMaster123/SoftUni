package _02_Positions_Of;

import java.util.Scanner;
import java.util.stream.Stream;

public class Main
{
    public static void main(String[] args)
    {

        Scanner scanner = new Scanner(System.in);

        // input: 2 X 3
        int rows = scanner.nextInt();
        int cols = scanner.nextInt();
        scanner.nextLine();
       // int[][] matrix = new int[rows][cols];

        // Fill the matrix:
        //fillMatrix(matrix, scanner);
        int[][] matrix = Stream.generate(scanner::nextLine)
                .limit(rows)
                .map(line -> Stream.of(line.trim().split("\\s+"))
                        .mapToInt(Integer::parseInt)
                        .toArray())
                .toArray(int[][]::new);

        int searchNumber = scanner.nextInt();

        boolean isFound = false;

        for (int row = 0; row < matrix.length; row++)
        {
            for (int col = 0; col < matrix[row].length; col++)
            {
               if(matrix[row][col] == searchNumber)
               {
                   System.out.println(row + " " + col);
                   isFound = true;
               }
            }
        }
        if(!isFound)
        {
            System.out.println("not found");
        }
    }

    private static void fillMatrix(int[][] matrix, Scanner scanner)
    {
        for (int row = 0; row < matrix.length; row++)
        {
            for (int col = 0; col < matrix[row].length; col++)
            {
                matrix[row][col] = scanner.nextInt();
            }
        }
    }
}
