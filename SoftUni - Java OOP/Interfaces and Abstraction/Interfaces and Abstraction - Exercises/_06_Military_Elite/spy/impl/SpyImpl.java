package _06_Military_Elite.spy.impl;

import _06_Military_Elite.soldier.impl.SoldierImpl;
import _06_Military_Elite.spy.Spy;

public class SpyImpl extends SoldierImpl implements Spy {
    private String codeNumber;
    public SpyImpl(int id, String firstName, String lastName, String codeNumber) {
        super(id, firstName, lastName);
        this.codeNumber = codeNumber;
    }

    @Override
    public String getCodeNumber() {
        return this.codeNumber;
    }
    @Override
    public String toString() {
        return  String.format("Name: %s %s Id: %d", getFirstName(), getLastName(), getId()) +
                System.lineSeparator() + String.format("Code Number: %s", codeNumber);
    }
}
