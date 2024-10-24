package DemoExercises;

import java.util.Arrays;

public enum Month {
    JANUARY(31, 8, 23), // days, free days, works days
    FEBRUARY(28, 7, 19), // only one instance
    MARCH(31,8,23), // only one instance
    APRIL(30,8,22);//,
    //MAI,
    //JUNE,
    //JULY,
    //AUGUST,
    //SEPTEMBER,
    // OCTOBER,
    //NOVEMBER,
    //DECEMBER;

    // It cannot be null.
    // It cannot be duplicated when we compile the code they are automated created
    private final int days; // It's good to be final, because we don't want to change the values
    private final int nonWorkingDays;
    private final int workingDays;

    Month(int days, int nonWorkingDays, int workingDays) {
        this.days = days;
        this.nonWorkingDays = nonWorkingDays;
        this.workingDays = workingDays;
    }

    public String toString() {
        return String.format("%s -> days = %d, non working days = %d, working days = %d",
                this.name(), this.days, this.nonWorkingDays, this.workingDays);
        // name → give the enum name | Example JANUARY
    }
    public double calculateMonthSalary(double dailyWage) {
        return this.workingDays * dailyWage;
    }
    public static void printMonths() {
        Arrays.stream(Month.values()).forEach(System.out::println);
    }

    public int getDays() {
        return days;
    }

    public int getNonWorkingDays() {
        return nonWorkingDays;
    }

    public int getWorkingDays() {
        return workingDays;
    }
}
