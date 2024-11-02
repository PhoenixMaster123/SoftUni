package _06_Military_Elite.mission;

import _06_Military_Elite.enumm.State;

public interface Mission {
    String getCodeName();
    State getState();
    void completeMission();

}
