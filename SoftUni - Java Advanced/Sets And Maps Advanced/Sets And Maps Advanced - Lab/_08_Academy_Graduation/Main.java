package lab._08_Academy_Graduation;

import java.util.*;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());

        Map<String, List<Double>> studentInfos = new TreeMap<>();

        for (int i = 0; i < n; i++)
        {
            String studentName = scanner.nextLine();
            List<Double> grade = Arrays.stream(scanner.nextLine().split(" "))
                    .map(Double::parseDouble).toList();

            studentInfos.putIfAbsent(studentName, grade);
        }

        for(Map.Entry<String, List<Double>> entry : studentInfos.entrySet())
        {
            System.out.println(entry.getKey() + " is graduated with " + findAverage(entry.getValue()));
        }
    }

    private static double findAverage(List<Double> value)
    {
        double sum = 0;

        for (Double grade : value)
        {
            sum += grade;
        }
        return sum / value.size();
    }
}
