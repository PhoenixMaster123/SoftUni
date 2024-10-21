package Demo;

public class Main {
    public static void main(String[] args) {
        System.out.println(Month.JANUARY);

        printMonth(Month.OCTOBER);

        // Get all enums values
        Month[] months = Month.values();

        for (Month month : months) {
            printMonth(month);
            System.out.println(month.ordinal() + " -> " + month + "Average temperature " + month.getAverageTemperature());
        }
        // ordinal() -> the position in the enum
        printMonth(months);

    }
    public static void printMonth(Month month) {
        System.out.println("This month is " + month);
    }
    public static void printMonth(Month... month) {
        for (Month month1 : month) {
            System.out.println("This month is " + month1);
        }
    }
}
