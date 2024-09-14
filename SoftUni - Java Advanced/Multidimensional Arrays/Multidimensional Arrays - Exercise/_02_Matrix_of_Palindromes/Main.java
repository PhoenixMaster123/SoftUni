package _02_Matrix_of_Palindromes;

import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);

        int rows = scanner.nextInt();
        int cols = scanner.nextInt();

        String[][] matrix = new String[rows][cols];

        fillPalindromMatrix(matrix);
        printMatrix(matrix);
    }

    private static void fillPalindromMatrix(String[][] matrix)
    {
        for (int row = 0; row < matrix.length; row++)
        {
            for (int col = 0; col < matrix[row].length; col++)
            {
                char outsideSymbol = (char) ('a' + row);
                char middleSymbol = (char)  (outsideSymbol + col);
                matrix[row][col] = String.valueOf(outsideSymbol) +
                           middleSymbol + outsideSymbol;
            }
        }
    }
    private static void printMatrix(String[][] matrix)
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
