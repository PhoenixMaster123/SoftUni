package exam_22_June_2024.Beesy;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        char[][] field = new char[n][n];

        int beeRow = 0;
        int beeCol = 0;

        for (int row = 0; row < n; row++) {
            char[] line = scanner.nextLine().toCharArray();

            for (int col = 0; col < n; col++) {
                if(line[col] == 'B'){
                    beeRow = row;
                    beeCol = col;
                }
                field[row][col] = line[col];
            }
        }
        // flowers nectar = digits
        // hive = 'H'

        int energy = 15;
        int nectar = 0;
        int oneTimeSafe = 0;
        boolean energyRestored = false;
        boolean hiveReached = false;

        while (true) {
            String command = scanner.nextLine();
            int lastBeePosRow = beeRow;
            int lastBeePosCol = beeCol;
            field[beeRow][beeCol] = '-';

            switch (command) {
                case "up":
                    beeRow = (beeRow - 1 + n) % n;  // wrap around top
                    break;
                case "down":
                    beeRow = (beeRow + 1) % n;  // wrap around bottom
                    break;
                case "left":
                    beeCol = (beeCol - 1 + n) % n;  // wrap around left
                    break;
                case "right":
                    beeCol = (beeCol + 1) % n;  // wrap around right
                    break;
            }

            /*if(!isRowValid(field, beeRow) && beeRow >= field.length) {
                beeRow = lastBeePosRow - (n - 1);
            }
            if(!isColValid(field, beeCol) && beeCol >= field[0].length) {
                beeCol = lastBeePosCol - (n - 1);
            }
            if(!isRowValid(field, beeRow) && beeRow < 0) {
                beeRow = lastBeePosRow + (n - 1);
            }
            if(!isColValid(field, beeCol) && beeCol < 0) {
                beeCol = lastBeePosCol + (n - 1);
            }
             */
            energy--;

            if(Character.isDigit(field[beeRow][beeCol])) {
                nectar += Integer.parseInt(String.valueOf(field[beeRow][beeCol]));
            }
            else if(field[beeRow][beeCol] == 'H') {
                field[beeRow][beeCol] = 'B';
                hiveReached = true;
                break;
            }

            field[beeRow][beeCol] = 'B';

            if (energy == 0 && nectar >= 30 && !energyRestored) {
                energy = nectar - 30;  // restore energy by the difference
                nectar = 30;  // set nectar to 30
                energyRestored = true;  // ensure energy is restored only once
            }
            if(energy == 0 && nectar < 30) {
                break;
            }
            if(energy == 0) {
                break;
            }
        }

        if(nectar >= 30 && hiveReached) {
            System.out.println("Great job, Beesy! The hive is full. Energy left: " + energy);
        }
        else if(nectar < 30 && hiveReached) {
            System.out.println("Beesy did not manage to collect enough nectar.");
        }
        else {
            System.out.println("This is the end! Beesy ran out of energy.");
        }

        printMatrix(field);

    }
    private static void printMatrix(char[][] matrix) {
        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[row].length; col++) {
                System.out.print(matrix[row][col]);
            }
            System.out.println();
        }
    }
    /*private static boolean isValid(char[][] field, int beeRow, int beeCol) {
        return beeRow < field.length &&
                beeRow >= 0 &&
                beeCol >= 0 &&
                beeCol < field[0].length;
    }
     */
    private static boolean isRowValid(char[][] field, int beeRow) {
        return beeRow < field.length && beeRow >= 0;
    }
    private static boolean isColValid(char[][] field, int beeCol) {
        return beeCol < field[0].length && beeCol >= 0;
    }
}
