package exam_14_December_2022.Navy_Battle;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        char[][] matrix = new char[n][n];

       // fillMatrix(matrix, scanner);
        int submarineRow = 0;
        int submarineCol = 0;
        for (int row = 0; row < matrix.length; row++) {
            char[] currentRow = scanner.nextLine().toCharArray();
            for (int col = 0; col < n; col++) {
                if(currentRow[col] == 'S') {
                    submarineRow = row;
                    submarineCol = col;
                }
                matrix[row][col] = currentRow[col];
            }
        }
        int submarineHits = 0;
        int cruiserHits = 0;

        while (submarineHits < 3 && cruiserHits < 3) {

            String commands = scanner.nextLine();
            matrix[submarineRow][submarineCol] = '-';

            switch (commands) {
                case "up" -> // row--
                        submarineRow--;
                case "down" -> // row++
                        submarineRow++;
                case "left" -> // col--
                        submarineCol--;
                case "right" -> // col++
                        submarineCol++;
            }

             if (matrix[submarineRow][submarineCol] == '*') {
                submarineHits++;
            } else if (matrix[submarineRow][submarineCol] == 'C') {
                cruiserHits++;
            }
            matrix[submarineRow][submarineCol] = 'S';
        }

        if(cruiserHits == 3) {
            System.out.println("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
        }
        else {
            System.out.printf("Mission failed, U-9 disappeared! Last known coordinates [%d, %d]!\n", submarineRow, submarineCol);
        }
        printMatrix(matrix);
    }

    private static void printMatrix(char[][] matrix) {
        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[row].length; col++) {
                System.out.print(matrix[row][col]);
            }
            System.out.println();
        }
    }

   /* private static void fillMatrix(char[][] matrix, Scanner scanner) {
        for (int row = 0; row < matrix.length; row++) {
            char[] current = scanner.nextLine().toCharArray();
            matrix[row] = current;
        }
    }
    */
}
