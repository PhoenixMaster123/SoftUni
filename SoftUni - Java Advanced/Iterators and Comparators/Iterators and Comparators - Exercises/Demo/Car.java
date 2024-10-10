package Demo;

public class Car implements Comparable<Car>{
    private String model;
    private int horsePower;
    private String makeYear;
    private String vin;

    public Car(String model, int horsePower, String...args) {
        this.model = model;
        this.horsePower = horsePower;

        if(args.length == 1) {
            if(args[0].length() == 4) {
                this.makeYear = args[0];
            }
            else {
                this.vin = args[0];
            }
        } else if(args.length == 2) {
            if(args[0].length() == 4) {
                this.makeYear = args[0];
                this.vin = args[1];
            }
            else {
                this.vin = args[0];
                this.makeYear = args[1];
            }
        }
    }
    public int getHorsePower() {
        return this.horsePower;
    }
    public String getModel() {
        return this.model;
    }

    // When is interface we need to implement the interfaces from this interface
    @Override
    public int compareTo(Car car) {
        return Integer.compare(this.horsePower, car.horsePower);
    }
    public String toString() {
        return this.model + " " + this.horsePower + " " + this.makeYear + " " + this.vin;
    }


}
