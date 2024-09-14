package _03_Diagonal_Difference;

import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int rows = scanner.nextInt();

        int[][] matrix = new int[rows][rows];

        fillMatrix(matrix, scanner);

        int sumPrimaryDiagonal = sumPrimaryDiagonal(matrix);
        int sumSecondaryDiagonal = sumSecondaryDiagonal(matrix);

        System.out.println(Math.abs(sumPrimaryDiagonal - sumSecondaryDiagonal));
    }

    private static int sumPrimaryDiagonal(int[][] matrix)
    {
        int sumPrimary = 0;
        for (int row = 0; row < matrix.length; row++)
        {
            sumPrimary += matrix[row][row];
        }
        return sumPrimary;
    }

    private static int sumSecondaryDiagonal(int[][] matrix)
    {
        int sumSecondary = 0;
        int cols = 0;
        for (int row = matrix.length - 1; row >= 0; row--)
        {
            sumSecondary += matrix[row][cols];
            cols++;
        }
        return sumSecondary;
    }



    private static void fillMatrix(int[][] matrix, Scanner scanner) {
        for (int rows = 0; rows < matrix.length; rows++) {
            //String[] currentRow = scanner.nextLine().split(" ");

            for (int j = 0; j < matrix[rows].length; j++) {
                //matrix[rows][j] = Integer.parseInt(currentRow[j]);
                matrix[rows][j] = scanner.nextInt();
            }
        }
    }

    private static void fillMatrixStreamAPI(int[][] matrix, Scanner scanner)
    {

        for (int row = 0; row < matrix.length; row++)
        {
            matrix[row] = Arrays.stream(scanner.nextLine().split(" "))
                    .mapToInt(Integer::parseInt).toArray();
        }
    }

}
