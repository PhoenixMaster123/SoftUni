package _04_Sum_Matrix_Elements;

import java.util.Arrays;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int[] input = Arrays.stream(scanner.nextLine().split(", "))
                .mapToInt(Integer::parseInt).toArray();
        int rows = input[0];
        int cols = input[1];

        System.out.println(rows);
        System.out.println(cols);
        int[][] matrix = new int[rows][cols];


        fillMatrix(matrix, scanner);
        System.out.println(sum(matrix));
        //System.out.print(findSumWithoutFillTheMatrix(matrix, scanner));
    }

    private static void fillMatrix(int[][] matrix, Scanner scanner)
    {
        for (int rows = 0; rows < matrix.length; rows++)
        {
            int[] currentRow = Arrays.stream(scanner.nextLine().split(", "))
                    .mapToInt(Integer::parseInt).toArray();
                matrix[rows] = currentRow;
            
        }
    }
    private static int sum(int[][] matrix)
    {
        int sum = 0;
        for (int rows = 0; rows < matrix.length; rows++)
        {
            for (int cols = 0; cols < matrix[rows].length; cols++)
            {
                sum += matrix[rows][cols];
            }
        }
        return sum;
    }

    private static int findSumWithoutFillTheMatrix(int[][] matrix, Scanner scanner)
    {
        int sum = 0;
        for (int rows = 0; rows < matrix.length; rows++)
        {
            int currentRow = Arrays.stream(scanner.nextLine().split(", "))
                    .mapToInt(Integer::parseInt).sum();
            sum += currentRow;

        }
        return sum;
    }
}
