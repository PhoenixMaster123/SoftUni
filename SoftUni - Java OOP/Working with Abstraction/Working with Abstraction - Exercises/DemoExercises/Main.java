package DemoExercises;

public class Main {
    public static void main(String[] args) {

        //System.out.println(Calendar.JANUARY); // give me JANUARY
        //Arrays.stream(Calendar.values()).forEach(System.out::println); // take like an array
        //System.out.println(Calendar.valueOf("JANUARY")); // give me JANUARY
        //System.out.println(Calendar.MARCH.ordinal()); // print the index (2 index)

        // Every element in enum is unique!!!

        //EnumMap<Calendar, String> calendarStringEnumMap = new EnumMap<Calendar,  String>(); -> better performance

        // We need to add equals and hashcode, because we can cohesion.

        //Arrays.stream(Calendar.values()).forEach(System.out::println);
        System.out.println(Month.JANUARY.calculateMonthSalary(56));
        Month.printMonths();
    }
}
