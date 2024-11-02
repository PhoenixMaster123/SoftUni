package _06_Military_Elite.engineer;

import _06_Military_Elite.repair.Repair;

import java.util.Collection;

public interface Engineer {
    Collection<Repair> getRepairs();
    void addRepair(Repair repair);
}
