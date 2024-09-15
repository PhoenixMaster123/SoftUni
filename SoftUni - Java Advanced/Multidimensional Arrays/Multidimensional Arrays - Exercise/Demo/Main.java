package Demo;

import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        int[][] matrix = new int[6][6];

        // How to move:

        // up -> row--
        // down -> row++
        // left -> col--
        // right -> coll++

        int row = 0;
        int col = 0;

        // Col-major order:

        /*for (int col = 0; col < matrix[0].length; col++) // this works if the matrix is not jagged array
        {
            for (int row = 0; row < matrix.length; row++)
            {
                System.out.print(matrix[col][row] + " ");
            }
            System.out.println();
        }
         */

    }
    private static boolean isValid(int[][] matrix, int row, int col) // Is inside the matrix
    {
        // Check the row and col when we moved are inside the matrix:

        return row >= 0 &&
               row < matrix.length &&
               col >= 0 &&
               col < matrix[row].length;

    }
    private static boolean isInvalid(int[][] matrix, int row, int col) // Is outside the matrix
    {
        // Check the row and col when we moved are outside the matrix:
        // Todo ->
        return false;
    }

    // Row-major order
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
