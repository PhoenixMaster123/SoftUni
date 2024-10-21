package Demo;

// Give an opportunity to define a sequence of values
public enum Month {
    // Constant values | They are ordered like an array
    JANUARY(5),
    FEBRUARY(7),
    MARCH(10),
    APRIL(12),
    MAY(15),
    JUNE(22),
    JULY(28),
    AUGUST(32),
    SEPTEMBER(28),
    OCTOBER(19),
    NOVEMBER(16),
    DECEMBER(3);

    // Fields:
    private int averageTemperature;

    // They can have a constructor → it cannot be a public

    // Constructor:
    Month(int averageTemperature) {
        this.averageTemperature = averageTemperature;
    }

    public int getAverageTemperature() {
        return this.averageTemperature;
    }

    public void setAverageTemperature(int averageTemperature) {
        this.averageTemperature = averageTemperature;
    }
}
