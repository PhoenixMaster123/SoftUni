package _02_Animal_Farm;

public class Chicken {
    private String name;
    private int age;

    public Chicken(String name, int age) {
        setName(name);
        setAge(age);
    }
    public String toString() {
        return String.format("Chicken %s (age %d) can produce %.2f eggs per day.", this.name, this.age, this.productPerDay());
    }
    private void setName(String name) {
        if((name == null || name.isEmpty() || name.isBlank() || Character.isWhitespace(name.charAt(0))) ) {
            throw new IllegalArgumentException("Name cannot be empty.");
        }
        this.name = name;
    }
    private void setAge(int age) {
        if(age < 0 || age > 15) {
            throw new IllegalArgumentException("Age should be between 0 and 15.");
        }
        this.age = age;
    }
    public double productPerDay() {
        return calculateProductPerDay();
    }

    private double calculateProductPerDay() {
        if(this.age < 6) {
            return 2;
        } else if (this.age < 12) {
            return 1;
        } else {
            return 0.75;
        }
    }
}
