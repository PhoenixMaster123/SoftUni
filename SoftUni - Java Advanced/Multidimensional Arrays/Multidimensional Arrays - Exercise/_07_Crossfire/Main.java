package _07_Crossfire;

import java.util.ArrayList;
import java.util.List;
import java.util.Objects;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int rows = scanner.nextInt();
        int cols = scanner.nextInt();
        scanner.nextLine(); // Consume the newline

        // Step 1: Create the matrix using List of Lists (more flexible for deletion)
        List<List<Integer>> matrix = new ArrayList<>();
        fillMatrix(matrix, rows, cols);

        String command = scanner.nextLine();

        // Step 2: Process commands until "Nuke it from orbit"
        while (!command.equals("Nuke it from orbit")) {
            int[] bombs = parseCommand(command);

            int targetRow = bombs[0];
            int targetCol = bombs[1];
            int radius = bombs[2];

            // Step 3: Destroy cells in cross pattern
            destroyCells(matrix, targetRow, targetCol, radius);

            command = scanner.nextLine();
        }

        // Step 4: Print remaining matrix
        printMatrix(matrix);
    }

    private static void fillMatrix(List<List<Integer>> matrix, int rows, int cols) {
        int number = 1;
        for (int i = 0; i < rows; i++) {
            List<Integer> row = new ArrayList<>();
            for (int j = 0; j < cols; j++) {
                row.add(number++);
            }
            matrix.add(row);
        }
    }

    private static int[] parseCommand(String command) {
        String[] tokens = command.split(" ");
        return new int[]{Integer.parseInt(tokens[0]), Integer.parseInt(tokens[1]), Integer.parseInt(tokens[2])};
    }

    private static void destroyCells(List<List<Integer>> matrix, int targetRow, int targetCol, int radius) {
        // Step 1: Destroy vertically (column cross) within radius
        for (int row = Math.max(0, targetRow - radius); row <= Math.min(matrix.size() - 1, targetRow + radius); row++) {
            if (targetCol >= 0 && targetCol < matrix.get(row).size()) {
                matrix.get(row).set(targetCol, null); // Mark as destroyed
            }
        }

        // Step 2: Destroy horizontally (row cross) within radius
        if (targetRow >= 0 && targetRow < matrix.size()) {
            List<Integer> currentRow = matrix.get(targetRow);
            for (int col = Math.max(0, targetCol - radius); col <= Math.min(currentRow.size() - 1, targetCol + radius); col++) {
                currentRow.set(col, null); // Mark as destroyed
            }
        }

        // Step 3: Remove null (destroyed) elements and clean up empty rows
        for (int i = 0; i < matrix.size(); i++) {
            matrix.get(i).removeIf(Objects::isNull); // Remove destroyed cells (null values)
            if (matrix.get(i).isEmpty()) {
                matrix.remove(i); // Remove empty rows
                i--; // Adjust index after removal
            }
        }
    }

    private static void printMatrix(List<List<Integer>> matrix) {
        for (List<Integer> row : matrix) {
            if (!row.isEmpty()) {
                for (int i = 0; i < row.size(); i++) {
                    if (i > 0) {
                        System.out.print(" ");
                    }
                    System.out.print(row.get(i));
                }
                System.out.println(); // Move to the next line after each row
            }
        }
    }
}
