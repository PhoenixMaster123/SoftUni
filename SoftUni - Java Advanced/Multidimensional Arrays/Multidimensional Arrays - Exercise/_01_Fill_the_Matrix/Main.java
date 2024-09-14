package _01_Fill_the_Matrix;

import java.util.Scanner;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String[] input = scanner.nextLine().split(", ");
        int rows = Integer.parseInt(input[0]);
        String method = input[1];
        int[][] matrix = new int[rows][rows];

        switch (method)
        {
            case "A": fillMatrixColMajorOrderA(matrix); break;
            case "B": fillMatrixColMajorOrderB(matrix); break;
        }
        printMatrix(matrix);
    }

    private static void fillMatrixColMajorOrderB(int[][] matrix)
    {
        // top to bottom then to left top again then to right and to bottom again

        //Example:
       /*
       [1][8][9][16]
       [2][7][10][15]
       [3][6][11][14]
       [4][5][12][13]
        */

        int count = 1;
        for (int col = 0; col < matrix.length; col++)
        {
            if(col % 2 == 0)
            {
                for (int row = 0; row < matrix.length; row++)
                {
                    matrix[row][col] = count++;
                }
            }
            else {
                for (int row = matrix.length - 1; row >= 0; row--)
                {
                    matrix[row][col] = count++;
                }
            }
        }
    }

    private static void fillMatrixColMajorOrderA(int[][] matrix)
    {
        // top to bottom then again top to bottom

        //Example:
       /*
       [1][5][9][13]
       [2][6][10][14]
       [3][7][11][15]
       [4][8][12][16]
        */

        int count = 1;
        for (int col = 0; col < matrix.length; col++)
        {
            for (int row = 0; row < matrix.length; row++)
            {
                matrix[row][col] = count++;
            }
        }

    }
    private static void printMatrix(int[][] matrix)
    {
        for (int rows = 0; rows < matrix.length; rows++)
        {
            for (int cols = 0; cols < matrix[rows].length; cols++)
            {
                System.out.print(matrix[rows][cols] + " ");
            }
            System.out.println();
        }
    }
}
