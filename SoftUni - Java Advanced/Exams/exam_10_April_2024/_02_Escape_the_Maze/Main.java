package exam_10_April_2024._02_Escape_the_Maze;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        char[][] maze = new char[n][n];

        int health = 100;

        int startpositionRow = 0;
        int startpositionCol = 0;

        for (int row = 0; row < n; row++) {
            char[] line = scanner.nextLine().toCharArray();

            for (int col = 0; col < n; col++) {
                if(line[col] == 'P') {
                    startpositionRow = row;
                    startpositionCol = col;
                }
                maze[row][col] = line[col];
            }
        }

       while (true) {
           String direction = scanner.nextLine();

           int currentPosRow = startpositionRow;
           int currentPosCol = startpositionCol;

           maze[startpositionRow][startpositionCol] = '-';

          switch (direction) {
              case "up":
                  startpositionRow--;
                  break;
              case "down":
                  startpositionRow++;
                  break;
              case "left":
                  startpositionCol--;
                  break;
              case "right":
                  startpositionCol++;
                  break;
          }

          if(!isValid(maze, startpositionRow, startpositionCol)) {
              startpositionRow = currentPosRow;
              startpositionCol = currentPosCol;
              maze[startpositionRow][startpositionCol] = 'P';
              continue;
          }

          if(maze[startpositionRow][startpositionCol] == 'M') {
              maze[startpositionRow][startpositionCol] = 'P';
              health -= 40;
              if(health <= 0) {
                  health = 0;
                  System.out.println("Player is dead. Maze over!");
                  break;
              }

          }
          else if(maze[startpositionRow][startpositionCol] == 'H') {
              health += 15;
              if(health > 100) {
                  health = 100;
              }
              maze[startpositionRow][startpositionCol] = 'P';
          }
          else if(maze[startpositionRow][startpositionCol] == 'X') {
              maze[startpositionRow][startpositionCol] = 'P';
              System.out.println("Player escaped the maze. Danger passed!");
              break;
          }
      }
        System.out.println("Player's health: " + health + " units");
        printMatrix(maze);
    }

    private static boolean isValid(char[][] maze, int row, int col) {
        return row >= 0 && row < maze.length && col >= 0 && col < maze[0].length;
    }
    private static void printMatrix(char[][] matrix) {
        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[row].length; col++) {
                System.out.print(matrix[row][col]);
            }
            System.out.println();
        }
    }
}
