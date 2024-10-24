package _05_Jedi_Galaxy;

import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] dimensions = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int rows = dimensions[0];
        int cols = dimensions[1];

        int[][] matrix = new int[rows][cols];
        fillMatrix(matrix);

        long totalSum = 0;
        String command = scanner.nextLine();

        while (!"Let the Force be with you".equals(command)) {
            int[] jediStartPos = Arrays.stream(command.split(" ")).mapToInt(Integer::parseInt).toArray();
            int[] evilStartPos = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

            applyEvilPath(evilStartPos[0], evilStartPos[1], matrix);
            totalSum += collectJediPathSum(jediStartPos[0], jediStartPos[1], matrix);

            command = scanner.nextLine();
        }

        System.out.println(totalSum);
    }

    private static void applyEvilPath(int evilRow, int evilCol, int[][] matrix) {
        while (evilRow >= 0 && evilCol >= 0) {
            if (isWithinBounds(matrix, evilRow, evilCol)) {
                matrix[evilRow][evilCol] = 0;  // The Evil "destroys" the stars in the galaxy
            }
            evilRow--;
            evilCol--;
        }
    }

    private static long collectJediPathSum(int jediRow, int jediCol, int[][] matrix) {
        long sum = 0;
        while (jediRow >= 0 && jediCol < matrix[0].length) {
            if (isWithinBounds(matrix, jediRow, jediCol)) {
                sum += matrix[jediRow][jediCol];  // Collect stars along the Jedi's path
            }
            jediCol++;
            jediRow--;
        }
        return sum;
    }

    private static void fillMatrix(int[][] matrix) {
        int value = 0;
        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[0].length; col++) {
                matrix[row][col] = value++;  // Incrementing value for each position
            }
        }
    }

    private static boolean isWithinBounds(int[][] matrix, int row, int col) {
        return row >= 0 && row < matrix.length && col >= 0 && col < matrix[0].length;
    }
}
