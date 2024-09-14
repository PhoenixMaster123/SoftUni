package _06_Print_Diagonals_of_Square_Matrix;

import java.util.Scanner;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int n = scanner.nextInt();

        int[][] matrix = new int[n][n];

        fillMatrix(matrix, scanner);

        printPrimaryDiagonal(matrix);
        System.out.println();
        printSecondaryDiagonal(matrix);
    }

    private static void printPrimaryDiagonal(int[][] matrix)
    {
        for (int row = 0; row < matrix.length; row++)
        {
            System.out.print(matrix[row][row] + " ");
        }
    }

    private static void printSecondaryDiagonal(int[][] matrix)
    {
       /* for (int row = 0; row < matrix.length; row++)
        {
            System.out.print(matrix[matrix.length - 1 - row][row] + " ");
        }
        */
        int col = 0;
        for (int row = matrix.length - 1; row >= 0; row--)
        {
            System.out.print(matrix[row][col] + " ");
            col++;
        }
    }

    private static void fillMatrix(int[][] matrix, Scanner scanner)
    {
        for (int rows = 0; rows < matrix.length; rows++)
        {
            for (int j = 0; j < matrix[rows].length; j++)
            {
                matrix[rows][j] = scanner.nextInt();
            }
        }
    }
}
