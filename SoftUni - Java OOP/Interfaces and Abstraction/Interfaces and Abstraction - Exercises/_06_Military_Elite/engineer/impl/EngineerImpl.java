package _06_Military_Elite.engineer.impl;

import _06_Military_Elite.engineer.Engineer;
import _06_Military_Elite.repair.Repair;
import _06_Military_Elite.soldier.impl.SpecialisedSoldierImpl;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;

public class EngineerImpl extends SpecialisedSoldierImpl implements Engineer {
    private Collection<Repair> repairs;
    public EngineerImpl(int id, String firstName, String lastName, double salary, String corp) {
        super(id, firstName, lastName, salary, corp);
        this.repairs = new ArrayList<>();
    }

    @Override
    public Collection<Repair> getRepairs() {
        return Collections.unmodifiableCollection(repairs);
    }

    @Override
    public void addRepair(Repair repair) {
        this.repairs.add(repair);
    }
    @Override
    public String toString() {
        StringBuilder result = new StringBuilder();
        result.append(String.format("Name: %s %s Id: %d Salary: %.2f", getFirstName(), getLastName(), getId(), getSalary()));
        result.append(System.lineSeparator());
        result.append(String.format("Corps: %s", getCorp()));
        result.append(System.lineSeparator());
        result.append("Repairs: ");
        this.repairs.forEach(repair -> result.append(System.lineSeparator()).append("  ").append(repair));
        return result.toString();
    }
}
