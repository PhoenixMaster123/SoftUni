package _04_Maximal_Sum;

import java.util.Arrays;
import java.util.Scanner;

public class Main
{
    public static void main(String[] args) {

        Scanner  scanner = new Scanner(System.in);

        int n = scanner.nextInt();
        int m = scanner.nextInt();
        scanner.nextLine();

        int[][] matrix = new int[n][m];

        fillMatrix(matrix, scanner);

        int[][] maxSumInSubmatrix = new int[3][3];
        int maxSum = Integer.MIN_VALUE;
        int startRowIndex = 0;
        int startColIndex = 0;

        for (int row = 0; row < matrix.length - 2; row++)
        {
            for (int col = 0; col < matrix[row].length - 2; col++)
            {
                /*int currentSum = matrix[row][col] + matrix[row][col++] + matrix[row][col + 2] +
                                 matrix[row + 1 ][col] + matrix[row++][col++] + matrix[row++][col + 2] +
                                 matrix[row + 2][col] + matrix[row + 2][col++] + matrix[row + 2][col + 2]         
                 */
                int sum = 0;
                for (int currentRow = row; currentRow < row + 3; currentRow++)
                {
                    for (int currentCol = col; currentCol < col + 3; currentCol++)
                    {
                        sum += matrix[currentRow][currentCol];
                    }
                }
                if(sum > maxSum)
                {
                    maxSum = sum;
                    startRowIndex = row;
                    startColIndex = col;
                }

            }
        }
        System.out.printf("Sum = %d", maxSum);
        System.out.println();
        printMatrix(matrix, startRowIndex, startColIndex);
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
    private static void printMatrix(int[][] matrix, int startRowIndex, int startColIndex)
    {
        for (int rows = startRowIndex; rows < startRowIndex + 3; rows++)
        {
            for (int cols = startColIndex; cols < startColIndex + 3; cols++)
            {
                System.out.print(matrix[rows][cols] + " ");
            }
            System.out.println();
        }
    }
}
