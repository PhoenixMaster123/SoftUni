package _06_String_Matrix_Rotation;

import java.util.*;

import static java.util.Collections.replaceAll;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);

        int rotationGrads = Integer.parseInt(scanner.nextLine()
                .split("\\(")[1]
                .replaceAll("\\)", ""));

        int rotationAngle = rotationGrads % 360;

        List<String> lines = new ArrayList<>();
        String command = scanner.nextLine();
        while (!command.equals("END"))
        {
            lines.add(command);

            command = scanner.nextLine();
        }
       // int maxSize = Collections.max(lines).length();
        int maxSize = lines.stream().mapToInt(String::length).max().orElse(0);

        int rows = lines.size();
        int cols = maxSize;

        char[][] matrix = new char[rows][cols];

        fillMatrix(matrix, lines);

        switch (rotationAngle)
        {
            case 90:
               matrix = rotate90(matrix, rows, cols);
                break;
            case 180:
                matrix = rotate90(matrix, rows, cols);
                matrix = rotate90(matrix, cols, rows);
                break;
            case 270:
                matrix = rotate90(matrix, rows, cols);
                matrix = rotate90(matrix, cols, rows);
                matrix = rotate90(matrix, rows, cols);
                break;
            default:
                break;
        }
        printMatrix(matrix);
    }

    private static void printMatrix(char[][] matrix)
    {
        for (int row = 0; row < matrix.length; row++)
        {
            for (int col = 0; col < matrix[row].length; col++)
            {
                System.out.print(matrix[row][col]);
            }
            System.out.println();
        }
    }

    private static char[][] rotate90(char[][] matrix, int rows, int cols)
    {
        char[][] rotatedMatrix = new char[cols][rows];

        for (int col = 0; col < cols; col++)
        {
            //int colCounter = 0;
            for (int row = rows - 1; row >= 0; row--)
            {
                //rotatedMatrix[col][colCounter++] = matrix[row][col];
                rotatedMatrix[col][rows - row - 1] = matrix[row][col];
            }
        }
        return rotatedMatrix;
    }

    private static void fillMatrix(char[][] matrix, List<String> lines)
    {
        for (int row = 0; row < matrix.length; row++)
        {
            String currentLine = lines.get(row);
            for (int col = 0; col < matrix[row].length; col++)
            {
                if(col < currentLine.length())
                {
                    matrix[row][col] = currentLine.charAt(col);
                }
                else
                {
                    matrix[row][col] = ' ';
                }
            }
        }
    }
}
