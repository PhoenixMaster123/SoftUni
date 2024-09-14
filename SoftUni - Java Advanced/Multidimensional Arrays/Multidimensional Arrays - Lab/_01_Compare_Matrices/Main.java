package _01_Compare_Matrices;

import java.util.Arrays;
import java.util.Comparator;
import java.util.Scanner;
import java.util.stream.Stream;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int rowsA = scanner.nextInt();
        int colsA = scanner.nextInt();

        int[][] matrixA = new int[rowsA][colsA];

        fillMatrix(matrixA, scanner);

        int rowsB = scanner.nextInt();
        int colsB = scanner.nextInt();
        int[][] matrixB = new int[rowsB][colsB];

        fillMatrix(matrixB, scanner);

        boolean compareMatrix = areEqual(matrixA, matrixB);

        if(compareMatrix)
        {
            System.out.println("equal");
        }
        else
        {
            System.out.println("not equal");
        }
    }

    private static boolean areEqual(int[][] matrixA, int[][] matrixB)
    {
        // rows                                 cols
        if(matrixA.length != matrixB.length  || matrixA[0].length != matrixB[0].length)
        {
            return false;
        }
        for (int row = 0; row < matrixA.length; row++) {
            for (int col = 0; col < matrixA[row].length; col++)
            {
                if(matrixA[row][col] != matrixB[row][col])
                {
                    return false;
                }
            }
        }
        return true;
        /*
          return IntStream.range(0, matrix1.length)
                   .allMatch(i -> IntStream.range(0, matrix1[i].length)
                         .allMatch(j -> matrix1[i][j] == matrix2[i][j]));
         */
    }

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
    private static int[][] fillMatrixWithStream(int[][] matrix, int rows, Scanner scanner)
    {
        matrix = Stream.generate(scanner::nextLine)
                .limit(rows)
                .map(line -> Stream.of(line.trim().split("\\s+"))
                        .mapToInt(Integer::parseInt)
                        .toArray())
                .toArray(int[][]::new);
        return matrix;
    }
}
