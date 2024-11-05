package _02_Vehicles_Extension;

public class Bus extends VehicleImpl{

    private static final boolean DEFAULT_IS_EMPTY = true;
    private static final boolean DEFAULT_IS_AC_ON = false;
    private boolean isEmpty;
    private boolean isAcOn;
    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) {
        super(fuelQuantity, fuelConsumption, tankCapacity);
        this.isEmpty = DEFAULT_IS_EMPTY;
        isAcOn = DEFAULT_IS_AC_ON;
    }

    @Override
    public String drive(double distance) {
        if(isAcOn) {
            super.setFuelConsumption(getFuelConsumption() - 1.4);
            isAcOn = false;
        }
        if(!isEmpty) {
            super.setFuelConsumption(getFuelConsumption() + 1.4);
            isEmpty = true;
        }
        return super.drive(distance);
    }

    public boolean isEmpty() {
        return isEmpty;
    }

    public void setEmpty(boolean empty) {
        isEmpty = empty;
    }
}
