package exercise._04_Raw_Data_02;

class Tire {
    private double[] pressures;
    private int[] ages;

    public Tire(double[] pressures, int[] ages) {
        this.pressures = pressures;
        this.ages = ages;
    }

    public boolean hasLowPressure() {
        for (double pressure : pressures) {
            if (pressure < 1) {
                return true;
            }
        }
        return false;
    }
}
