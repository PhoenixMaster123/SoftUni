package _05_Maximum_Sum_of_2x2_Submatrix_2;

import java.util.Arrays;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int[] input = Arrays.stream(scanner.nextLine().split(", "))
                .mapToInt(Integer::parseInt).toArray();

        int rows = input[0];
        int cols = input[1];

        int[][] matrix = new int[rows][cols];

        fillMatrix(matrix, scanner);

        int[] maxRows = new int[2];
        int[] maxCols = new int[2];

       int bestSumSubMatrix = 0;

        for (int row = 0; row < matrix.length - 1; row++)
        {
            for (int col = 0; col < matrix[row].length - 1; col++)
            {
                int currentMatrixSum = matrix[row][col] + matrix[row][col + 1]
                        + matrix[row + 1][col] + matrix[row + 1][col + 1];

                if(currentMatrixSum > bestSumSubMatrix)
                {
                    bestSumSubMatrix = currentMatrixSum;
                    maxRows = new int[] {matrix[row][col], matrix[row][col + 1]};
                    maxCols = new int[] {matrix[row + 1][col], matrix[row + 1][col + 1]};
                }
            }
        }

       //System.out.println(Arrays.toString(maxRows));
       //System.out.println(Arrays.toString(maxCols));
        printMatrix(maxRows);
        printMatrix(maxCols);
        System.out.println(bestSumSubMatrix);
    }
    private static void printMatrix(int[] elements)
    {
        for (int i = 0; i < elements.length; i++)
        {
            System.out.print(elements[i] + " ");
        }
        System.out.println();
    }

    private static void fillMatrix(int[][] matrix, Scanner scanner)
    {
        for (int row = 0; row < matrix.length; row++)
        {
            int[] currentRow = Arrays.stream(scanner.nextLine().split(", "))
                    .mapToInt(Integer::parseInt).toArray();

            matrix[row] = currentRow;
        }
    }
}
