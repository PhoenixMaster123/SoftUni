package _02_Point_in_Rectangle;

import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] arrCoordRect = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int n = Integer.parseInt(scanner.nextLine());

        Point bottomLeft = new Point(arrCoordRect[0], arrCoordRect[1]);
        Point topRight = new Point(arrCoordRect[2], arrCoordRect[3]);
        Rectangle rectangle = new Rectangle(bottomLeft, topRight);

        for (int i = 0; i < n; i++) {

            int[] pointCoord = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
            Point point = new Point(pointCoord[0], pointCoord[1]);
            System.out.println(rectangle.contains(point));
        }
    }
}
