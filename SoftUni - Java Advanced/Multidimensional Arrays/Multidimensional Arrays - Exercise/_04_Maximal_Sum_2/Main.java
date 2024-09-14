package _04_Maximal_Sum_2;

import java.util.Arrays;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int rows = scanner.nextInt();
        int cols = scanner.nextInt();
        scanner.nextLine();

        int[][] matrix = new int[rows][cols];

        fillMatrix(matrix, scanner);

        int maxSum = Integer.MIN_VALUE;
        int[][] maxSubMatrix = new int[3][3];

        for (int row = 0; row < matrix.length - 2; row++)
        {
            for (int col = 0; col < matrix[row].length - 2; col++)
            {
                int currentSum =
                        matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                        matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2] +
                        matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                if(currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSubMatrix = new int[][]
                            {
                                    {matrix[row][col], matrix[row][col + 1],  matrix[row][col + 2]},
                                    {matrix[row + 1][col], matrix[row + 1][col + 1], matrix[row + 1][col + 2]},
                                    {matrix[row + 2][col], matrix[row + 2][col + 1], matrix[row + 2][col + 2]}
                            };
                }
            }
        }
        System.out.println("Sum = " + maxSum);

        printMatrix(maxSubMatrix);
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

    private static void printMatrix(int[][] matrix)
    {
        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[row].length; col++) {
                System.out.print(matrix[row][col] + " ");
            }
            System.out.println();
        }
    }
}
