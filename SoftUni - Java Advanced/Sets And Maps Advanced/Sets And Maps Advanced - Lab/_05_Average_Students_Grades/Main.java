package lab._05_Average_Students_Grades;

import java.util.*;

public class Main
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);

        Map<String, List<Double>> studentsGrades = new TreeMap<>();

        int n = Integer.parseInt(scanner.nextLine());

        for (int students = 0; students < n; students++)
        {
            String[] studentInformation = scanner.nextLine().split(" ");

            String studentName = studentInformation[0];
            double studentGrade = Double.parseDouble(studentInformation[1]);

            // Variant 1 -> four line code:
           /* studentsGrades.putIfAbsent(studentName, new ArrayList<>());

            List<Double> grades = studentsGrades.get(studentName);
            grades.add(studentGrade);

            studentsGrades.put(studentName, grades);
            */

            // Variant 2 -> one line code: I need computeIfAbsent otherwise is not working
            studentsGrades.computeIfAbsent(studentName, k -> new ArrayList<>()).add(studentGrade);
        }
        System.out.println();
        for (Map.Entry<String, List<Double>> entry : studentsGrades.entrySet())
        {
            // Stream API: has difference between the method findAverage and with Stream API
            //double average = entry.getValue().stream().mapToDouble(Double::doubleValue).average().orElse(0.0);

            System.out.print(entry.getKey() + " -> ");
            entry.getValue().forEach(grade -> System.out.printf("%.2f ", grade));
            System.out.printf("(avg: %.2f)\n", findAverage(entry.getValue()));
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
