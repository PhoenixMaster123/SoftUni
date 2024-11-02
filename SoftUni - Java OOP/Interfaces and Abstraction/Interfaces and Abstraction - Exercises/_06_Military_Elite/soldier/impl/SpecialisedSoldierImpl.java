package _06_Military_Elite.soldier.impl;

import _06_Military_Elite.enumm.Corp;
import _06_Military_Elite.privvate.impl.PrivateImpl;
import _06_Military_Elite.soldier.SpecialisedSoldier;

public class SpecialisedSoldierImpl extends PrivateImpl implements SpecialisedSoldier {

    private Corp corp;

    public SpecialisedSoldierImpl(int id, String firstName, String lastName, double salary, String corp) {
        super(id, firstName, lastName, salary);
        this.setCorp(corp);
    }

    @Override
    public Corp getCorps() {
        return null;
    }

    public Corp getCorp() {
        return corp;
    }

    public void setCorp(String corp) {
        this.corp = Corp.valueOf(corp);
    }
}
