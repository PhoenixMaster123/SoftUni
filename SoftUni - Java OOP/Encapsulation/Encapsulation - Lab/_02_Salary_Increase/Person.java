package _02_Salary_Increase;

public class Person {
    private String firstName;
    private String lastName;
    private int age;
    private double salary;

    public Person(String firstName, String lastName, int age, double salary) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.salary = salary;
    }
    public String toString() {
        return String.format("%s %s gets %f leva.", this.firstName, this.lastName, this.salary);
    }

    public void increaseSalary(double bonus) {
        if(this.age < 30) {
            this.salary += this.salary  * (bonus / 200);
        } else {
            this.salary += this.salary  * (bonus / 100);
        }
    }

    public String getFirstName() {
        return this.firstName;
    }

    public String getLastName() {
        return this.lastName;
    }

    public int getAge() {
        return this.age;
    }

    public double getSalary() {
        return salary;
    }

    public void setSalary(double salary) {
        this.salary = salary;
    }
}
