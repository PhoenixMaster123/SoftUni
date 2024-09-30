package exercise._04_Raw_Data;

import java.util.List;

public class Cargo {
    private int cargoWeight;

    private String cargoType;

    public Cargo(int cargoWeight, String cargoType) {
        this.cargoWeight = cargoWeight;
        this.cargoType = cargoType;
    }

    public String getCargoType() {
        return cargoType;
    }

}
