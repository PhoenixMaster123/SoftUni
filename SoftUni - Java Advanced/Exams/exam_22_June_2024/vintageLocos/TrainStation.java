package vintageLocos;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
public class TrainStation {
    private String name;
	private int capacity;
	private int railGauge;
	private List<Locomotive> locomotives;

    public TrainStation(String name, int capacity, int railGauge) {
        this.name = name;
        this.capacity = capacity;
        this.railGauge = railGauge;
        locomotives = new ArrayList<>();
    }
    public void addLocomotive(Locomotive locomotive) {

        if(railGauge != locomotive.getGauge()) {
            System.out.printf("The rail gauge of this station does not match the " +
                    "locomotive gauge! Difference: %d mm.\n", Math.abs(railGauge - locomotive.getGauge()));
            return;
        }
        if(locomotives.size() <= capacity && railGauge == locomotive.getGauge()) // <=
        {
            locomotives.add(locomotive);
        }
        else {
            System.out.println("This train station is full!");
        }
    }
    public boolean removeLocomotive(String name) {
        for (Locomotive loc : locomotives) {
            if(loc.getName().equals(name)) {
                locomotives.remove(loc);
                return true;
            }
        }
        return false;
    }
    public String getFastestLocomotive() {
        if(locomotives.isEmpty()) {
            return "There are no locomotives.";
        }
        // Variant 1:

        /*locomotives = locomotives.stream().sorted((l1,l2)
                -> Integer.compare(l2.getMaxSpeed(), l1.getMaxSpeed())).collect(Collectors.toList());
         */
        // Variant 2:
        Locomotive fastestLocomotive = locomotives.stream()
                .max(Comparator.comparingInt(Locomotive::getMaxSpeed))
                .orElse(null);

        // Variant 1:
        /*return locomotives.getFirst().getName() +
                " is the fastest locomotive with a maximum speed of "
                + locomotives.getFirst().getMaxSpeed() + " km/h.";
         */
        // Variant 2:
        return fastestLocomotive.getName() +
                " is the fastest locomotive with a maximum speed of "
                + fastestLocomotive.getMaxSpeed() + " km/h.";
    }
    public Locomotive getLocomotive(String name) {

        // Variant 1:
        /*for (Locomotive loc : locomotives) {
            if(loc.getName().equals(name)) {
                return loc;
            }
        }
       return null;
         */

        // Variant 2:
        return locomotives.stream()
                .filter(loc -> loc.getName().equals(name))
                .findFirst()
                .orElse(null);
    }
    public int getCount() {
        return locomotives.size();
    }
    public String getOldestLocomotive() {
        if(locomotives.isEmpty()) {
            return "There are no locomotives.";
        }
        // Variant 1:

        //locomotives = locomotives.stream().sorted((l1, l2) -> l1.getBuildDate().compareTo(l2.getBuildDate())).collect(Collectors.toList());
       // return locomotives.getFirst().getName();

        // Variant 2:
        Locomotive oldestLocomotive = locomotives.stream()
                .min(Comparator.comparing(Locomotive::getBuildDate))
                .orElse(null);

        return oldestLocomotive.getName();
    }
    public String getStatistics() {
        if (locomotives.isEmpty()) {
            return "There are no locomotives departing from " + this.name + " station.";
        }

        StringBuilder builder = new StringBuilder();
        builder.append("Locomotives departed from ").append(this.name).append(":\n");

        for (int i = 0; i < locomotives.size(); i++) {
            Locomotive loc = locomotives.get(i);
            builder.append(i + 1).append(". ").append(loc.getName());

            if (i < locomotives.size() - 1) {
                builder.append("\n");
            }
        }

        return builder.toString();
    }

}
