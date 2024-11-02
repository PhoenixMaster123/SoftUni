package _06_Military_Elite.mission.impl;

import _06_Military_Elite.enumm.State;
import _06_Military_Elite.mission.Mission;

public class MissionImpl implements Mission {
    private String codeName;
    private State state;

    public MissionImpl(String codeName, String state) {
        this.codeName = codeName;
        setState(state);
    }
    @Override
    public String getCodeName() {
        return this.codeName;
    }

    @Override
    public State getState() {
        return this.state;
    }

    @Override
    public void completeMission() {
        this.state = State.finished;
    }

    public void setState(String state) {
        this.state = State.valueOf(state);
    }
    @Override
    public String toString() {
        return String.format("Code Name: %s State: %s", codeName, state);
    }
}
