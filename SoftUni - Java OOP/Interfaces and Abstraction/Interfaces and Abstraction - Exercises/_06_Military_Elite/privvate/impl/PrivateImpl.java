package _06_Military_Elite.privvate.impl;

import _06_Military_Elite.privvate.Private;
import _06_Military_Elite.soldier.impl.SoldierImpl;

public class PrivateImpl extends SoldierImpl implements Private {
    private double salary;

    public PrivateImpl(int id, String firstName, String lastName, double salary) {
        super(id, firstName, lastName);
        this.salary = salary;
    }

    @Override
    public double getSalary() {
        return this.salary;
    }
    @Override
    public int getId() {
        return super.getId();
    }

    @Override
    public String toString() {
        return String.format("Name: %s %s Id: %d Salary: %.2f".trim(), getFirstName(),
                getLastName(), getId(), getSalary());
    }
}
