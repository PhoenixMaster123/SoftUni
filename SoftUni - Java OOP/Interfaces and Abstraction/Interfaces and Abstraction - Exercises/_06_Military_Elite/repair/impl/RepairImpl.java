package _06_Military_Elite.repair.impl;

import _06_Military_Elite.repair.Repair;

public class RepairImpl implements Repair {

    private String partName;
    private int hoursWork;

    public RepairImpl(String partName, int hoursWork) {
        this.partName = partName;
        this.hoursWork = hoursWork;
    }

    @Override
    public String getPartName() {
        return partName;
    }

    @Override
    public int getHoursWork() {
        return hoursWork;
    }
    @Override
    public String toString() {
        return String.format("Part Name: %s Hours Worked: %d", partName, getHoursWork());
    }
}
