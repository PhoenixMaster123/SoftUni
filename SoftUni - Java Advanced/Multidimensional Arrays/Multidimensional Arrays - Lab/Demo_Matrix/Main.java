package Demo_Matrix;

import java.util.Arrays;

public class Main
{
    public static void main(String[] args)
    {
        //  Create a matrix:
        int[][] matrix = new int[3][4]; // rows = 3 x cols = 4

        System.out.println(Arrays.deepToString(matrix));

        // Access Elements:
        matrix[0][1] = 5; // row = 0, col = 1 -> 5
        // Change the whole row: Like that we can access a matrix row
        // (we can add more elements, the length is not necessary to be the same)
        matrix[1] = new int[] {8, 7, 6 ,5};

        System.out.println();
        // Matrix Iterate:

        // Row-major order:
        for (int row = 0; row < matrix.length; row++)
        {
            for (int col = 0; col < matrix[row].length; col++)
            {
                System.out.print(matrix[row][col] + " ");
            }
            System.out.println();
        }

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

        System.out.println();

        // Print Matrix with method:
        for (int[] row : matrix) {
            System.out.println(Arrays.toString(row));
        }
        System.out.println();

        // Print Matrix with Stream API:
        Arrays.stream(matrix)
                .map(row -> Arrays.toString(row))
                .forEach(System.out::println);
    }
}
