package _05_Matrix_Shuffling;

import java.util.Arrays;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);

        int rows = scanner.nextInt();
        int cols = scanner.nextInt();
        scanner.nextLine();

        String[][] matrix = new String[rows][cols];
        fillMatrix(matrix, scanner);



        while (true)
        {
            String[] tokens = scanner.nextLine().split(" ");

            if(tokens[0].equals("END"))
            {
                break;
            }

            if(tokens[0].equals("swap") && tokens.length == 5)
            {
                int row1 = Integer.parseInt(tokens[1]);
                int col1 = Integer.parseInt(tokens[2]);
                int row2 = Integer.parseInt(tokens[3]);
                int col2 = Integer.parseInt(tokens[4]);

                if(isValid(matrix,row1,col1,row2,col2))
                {
                    String temp = matrix[row1][col1];
                    matrix[row1][col1] = matrix[row2][col2];
                    matrix[row2][col2] = temp;

                    printMatrix(matrix);
                }
                else
                {
                    System.out.println("Invalid input!");
                }
            }
            else
            {
                System.out.println("Invalid input!");
            }

        }


    }

    private static boolean isValid(String[][] matrix, int row1, int col1, int row2, int col2)
    {
        return row1 >= 0 &&
                row1 < matrix.length &&
                col1 >= 0 &&
                col1 < matrix[row1].length &&
                row2 >= 0 &&
                row2 < matrix.length &&
                col2 >= 0 &&
                col2 < matrix[row2].length;
    }

    private static void printMatrix(String[][] matrix)
    {
        for (int row = 0; row < matrix.length; row++)
        {
            for (int col = 0; col < matrix[row].length; col++)
            {
                System.out.print(matrix[row][col] + " ");
            }
            System.out.println();
        }
    }

    private static void fillMatrix(String[][] matrix, Scanner scanner)
    {
        for (int rows = 0; rows < matrix.length; rows++)
        {
            String[] currentRow = scanner.nextLine().split(" ");

            matrix[rows] = currentRow;
        }
    }
}
