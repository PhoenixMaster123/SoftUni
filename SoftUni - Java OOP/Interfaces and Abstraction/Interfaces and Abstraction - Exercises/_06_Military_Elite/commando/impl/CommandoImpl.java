package _06_Military_Elite.commando.impl;

import _06_Military_Elite.commando.Commando;
import _06_Military_Elite.mission.Mission;
import _06_Military_Elite.soldier.impl.SpecialisedSoldierImpl;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;

public class CommandoImpl extends SpecialisedSoldierImpl implements Commando {
    private Collection<Mission> missions;

    public CommandoImpl(int id, String firstName, String lastName, double salary, String corp) {
        super(id, firstName, lastName, salary, corp);
        this.missions = new ArrayList<>();
    }

    @Override
    public Collection<Mission> getMission() {
        return Collections.unmodifiableCollection(this.missions);
    }

    @Override
    public void addMission(Mission mission) {
        this.missions.add(mission);
    }
    @Override
    public String toString() {
        StringBuilder result = new StringBuilder();
        result.append(String.format("Name: %s %s Id: %d Salary: %.2f", getFirstName(), getLastName(), getId(), getSalary()));
        result.append(System.lineSeparator());
        result.append(String.format("Corps: %s", getCorp()));
        result.append(System.lineSeparator());
        result.append("Missions: ");
        this.missions.forEach(mission -> result.append(System.lineSeparator()).append("  ").append(mission));
        return result.toString();
    }
}
