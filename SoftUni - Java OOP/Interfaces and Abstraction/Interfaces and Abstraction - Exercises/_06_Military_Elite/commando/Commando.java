package _06_Military_Elite.commando;

import _06_Military_Elite.mission.Mission;

import java.util.Collection;

public interface Commando {
    Collection<Mission> getMission();
    void addMission(Mission mission);

}
