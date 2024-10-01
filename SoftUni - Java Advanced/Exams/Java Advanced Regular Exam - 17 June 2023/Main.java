package exam_17_Juni_2023.Mouse_In_The_Kitchen;

import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] input = Arrays.stream(scanner.nextLine().split(","))
                .mapToInt(Integer::parseInt).toArray();

        int row = input[0];
        int col = input[1];

        // create matrix
        char[][] matrix = new char[row][col];
        // fill the matrix
        //fillMatrix(matrix, scanner);

        int[] result = fillMatrix(matrix, scanner);
        int myRow = result[0];
        int myCol = result[1];
        int cheeseCount = result[2];


        String commands = scanner.nextLine();

        while (!"danger".equals(commands)) {

            int newRow = myRow;
            int newCol = myCol;

            switch (commands) {
                case "up": // row--
                    newRow--;
                    break;
                case "down": // row++
                    newRow++;
                    break;
                case "left": // col--
                    newCol--;
                    break;
                case "right": // col++
                    newCol++;
                    break;
            }
            if(!isValid(matrix, newRow, newCol)) {
                System.out.println("No more cheese for tonight!");
                printMatrix(matrix);
                return;
            }
            char symbol = matrix[newRow][newCol];

            if(symbol != '@') {
                matrix[newRow][newCol] = 'M';
                matrix[myRow][myCol] = '*';

                myRow = newRow;
                myCol = newCol;
            }

            switch (symbol) {
                case 'C': // cheese
                    cheeseCount--;
                    if(cheeseCount == 0) {
                        System.out.println("Happy mouse! All the cheese is eaten, good night!");
                        printMatrix(matrix);
                        return;
                    }
                    break;
                case 'T': // trap
                    System.out.println("Mouse is trapped!");
                    printMatrix(matrix);
                    return;
            }
            commands = scanner.nextLine();
        }
        System.out.println("Mouse will come back later!");
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
    private static int[] fillMatrix(char[][] matrix, Scanner scanner) {
       // int[] elementsToReturn = new int[3];
        int mouseRow = 0;
        int mouseCol = 0;
        int cheeseCount = 0;

        for (int row = 0; row < matrix.length; row++) {

            char[] line = scanner.nextLine().toCharArray();

            for (int col = 0; col < line.length; col++) {
                if (line[col] == 'M') {
                    mouseRow = row;
                    mouseCol = col;
                   // elementsToReturn[0] = mouseRow;
                   // elementsToReturn[1] = mouseCol;
                } else if (line[col] == 'C') {
                    cheeseCount++;
                }
                matrix[row][col] = line[col];
            }
            //elementsToReturn[2] = cheeseCount;
        }
        //return elementsToReturn;
        return new int[]{mouseRow,mouseCol, cheeseCount};
    }
    public static boolean isValid(char[][] matrix, int row, int col) {
        return row >= 0 &&
               row < matrix.length &&
               col >= 0 &&
               col < matrix[0].length;
    }
}