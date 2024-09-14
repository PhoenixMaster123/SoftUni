package _05_Maximum_Sum_of_2x2_Submatrix;

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


        int[][] maxSumSubmatrix  = findMaxSumSubmatrix(matrix);

        printMatrix(maxSumSubmatrix);
        System.out.println(sumMatrix(maxSumSubmatrix));

    }

    private static void printMatrix(int[][] maxSumSubmatrix)
    {
        for (int rows = 0; rows < maxSumSubmatrix.length; rows++)
        {
            for (int cols = 0; cols < maxSumSubmatrix[rows].length; cols++)
            {
                System.out.print(maxSumSubmatrix[rows][cols] + " ");
            }
            System.out.println();
        }
    }

    private static int[][] findMaxSumSubmatrix(int[][] matrix)
    {
        int[][] bestTwoDMatrix = new int[2][2];
        int maxValue = Integer.MIN_VALUE;
        for (int rows = 0; rows < matrix.length - 1; rows++)
        {
            for (int cols = 0; cols < matrix[rows].length - 1; cols++) {
                int[][] currentSubmatrix = new int[][]
                        {
                                {matrix[rows][cols], matrix[rows][cols + 1]},         // 7 1
                                {matrix[rows + 1][cols], matrix[rows + 1][cols + 1]}  // 1 3

                        };
                int currentSum = sumMatrix(currentSubmatrix);

                if (currentSum > maxValue)
                {
                    maxValue = currentSum;
                    bestTwoDMatrix = currentSubmatrix;
                }
            }
        }
        return bestTwoDMatrix;
    }
    private static int sumMatrix(int[][] twoDMatrix)
    {
        int sum = 0;
        for (int rows = 0; rows < twoDMatrix.length; rows++)
        {
            for (int cols = 0; cols < twoDMatrix[rows].length; cols++)
            {
                sum += twoDMatrix[rows][cols];
            }
        }
        return sum;
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


