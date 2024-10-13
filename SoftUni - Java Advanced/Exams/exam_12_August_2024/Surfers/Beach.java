package surfers;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;

public class Beach {
    private String name;
    private int surfboardsForRent;
    private List<Surfer> surfers;

    public Beach(String name, int surfboardsForRent) {
        this.name = name;
        this.surfboardsForRent = surfboardsForRent;
        this.surfers = new ArrayList<>();
    }

    public String addSurfer(Surfer surfer) {
        if (surfer.getMoney() < 50) {
            return surfer.getName() + " has not enough money to rent a surfboard.";
        }
        if (surfer.getOwnsASurfBoard()) {
            surfers.add(surfer);
            return "Surfer " + surfer.getName() + " added.";
        }
        if (surfer.getMoney() >= 50 && this.surfboardsForRent > 0) {
            surfboardsForRent--;
            surfers.add(surfer);
            return "Surfer " + surfer.getName() + " added.";
        }
        return "There are no free surfboards.";
    }

    public boolean removeSurfer(String name) {
        return surfers.removeIf(surfer -> surfer.getName().equals(name));
    }

    public String getMostExperiencedSurfer() {
        Surfer surfer = surfers.stream()
                .max(Comparator.comparing(Surfer::getExperience))
                .orElse(null);
        if (surfer != null) {
            return surfer.getName() + " is most experienced surfer with " + surfer.getExperience() + " years experience.";
        }
        return "There are no surfers.";
    }

    public Surfer getSurfer(String name) {
        return surfers.stream()
                .filter(surf -> surf.getName().equals(name))
                .findFirst()
                .orElse(null);
    }

    public int getCount() {
        return surfers.size();
    }

    public String getSurfersWithPersonalSurfboards() {
        if (surfers.isEmpty()) {
            return "There are no surfers.";
        }
        String s = surfers.stream()
                .filter(Surfer::getOwnsASurfBoard)
                .map(Surfer::getName)
                .collect(Collectors.joining(", "));
        return "Surfers who have their own surfboards: " + s.trim();
    }

    public String getReport() {
        if (surfers.isEmpty()) {
            return "There are no surfers on " + this.name + " beach.";
        }
        StringBuilder builder = new StringBuilder();
        builder.append("Beach ").append(this.name).append(" was visited by the following surfers:\n");

        int counter = 1;
        for (Surfer surfer : surfers) {
            if (surfer.getExperience() != 0) {
                builder.append(counter++).append(". ")
                        .append(surfer.getName()).append(" with ")
                        .append(surfer.getExperience()).append(" years experience.\n");
            } else {
                builder.append(counter++).append(". ")
                        .append(surfer.getName()).append(" with no experience.\n");
            }
        }
        return builder.toString().trim();
    }
}
