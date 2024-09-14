package _08_Wrong_Measurements;

import java.util.Arrays;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);

        int rows = Integer.parseInt(scanner.nextLine());


        int[][] matrix = new int[rows][];
        fillMatrix(matrix, scanner);

        int[][] unchangeableMatrix = deepCopy(matrix);

        int row = scanner.nextInt();
        int col = scanner.nextInt();

        int wrongValue = matrix[row][col];

        int positionRow = 0;
        int positionCol = 0;

        for (int rowMatrix = 0; rowMatrix < matrix.length; rowMatrix++)
        {
            for (int colMatrix = 0; colMatrix < matrix[rowMatrix].length; colMatrix++)
            {
                if(matrix[rowMatrix][colMatrix] == wrongValue)
                {
                    positionRow = rowMatrix;
                    positionCol = colMatrix;

                    int sum = neighborsValuesSum(unchangeableMatrix, positionRow, positionCol, wrongValue);

                    matrix[rowMatrix][colMatrix] = sum;
                }
            }
        }
        printMatrix(matrix);
    }

    private static int[][] deepCopy(int[][] matrix) {
        int[][] copy = new int[matrix.length][];
        for (int row = 0; row < matrix.length; row++) {
            copy[row] = Arrays.copyOf(matrix[row], matrix[row].length);
        }
        return copy;
    }

    private static void printMatrix(int[][] matrix)
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

    private static int neighborsValuesSum(int[][] matrix, int positionRow, int positionCol, int wrongValue)
    {
        int sum = 0;

        if(isValid(matrix, positionRow - 1, positionCol)) // up
        {
            if(matrix[positionRow - 1][positionCol] != wrongValue)
            {
                sum += matrix[positionRow - 1][positionCol];
            }
        }
        if(isValid(matrix, positionRow + 1, positionCol)) // down
        {
            if(matrix[positionRow + 1][positionCol] != wrongValue)
            {
                sum += matrix[positionRow + 1][positionCol];
            }
        }
        if(isValid(matrix, positionRow, positionCol - 1)) // left
        {
            if(matrix[positionRow][positionCol - 1] != wrongValue)
            {
                sum += matrix[positionRow][positionCol - 1];
            }
        }
        if(isValid(matrix, positionRow, positionCol + 1)) // right
        {
            if(matrix[positionRow][positionCol + 1] != wrongValue)
            {
                sum += matrix[positionRow][positionCol + 1];
            }
        }

        return sum;
    }
    private static boolean isValid(int[][] matrix, int row1, int col1)
    {
        return row1 >= 0 &&
                row1 < matrix.length &&
                col1 >= 0 &&
                col1 < matrix[row1].length;

    }

    private static void fillMatrix(int[][] matrix, Scanner scanner)
    {
        for (int row = 0; row < matrix.length; row++)
        {
            int[] currentRow = Arrays.stream(scanner.nextLine().split(" "))
                    .mapToInt(Integer::parseInt).toArray();

            matrix[row] = currentRow;
        }
    }
}
