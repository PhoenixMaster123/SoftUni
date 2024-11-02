package _06_Military_Elite.general.impl;

import _06_Military_Elite.general.LieutenantGeneral;
import _06_Military_Elite.privvate.Private;
import _06_Military_Elite.privvate.impl.PrivateImpl;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.List;

public class LieutenantGeneralImpl extends PrivateImpl implements LieutenantGeneral {
    private Collection<Private> privates;

    public LieutenantGeneralImpl(int id, String firstName, String lastName, double salary) {
        super(id, firstName, lastName, salary);
        privates = new ArrayList<>();
    }

    @Override
    public void addPrivate(Private priv) {
        privates.add(priv);
    }

    @Override
    public Collection<Private> getPrivates() {
        return Collections.unmodifiableCollection(this.privates);
    }
    @Override
    public String toString() {
        StringBuilder result = new StringBuilder();
        result.append(String.format("Name: %s %s Id: %d Salary: %.2f", getFirstName(), getLastName(), getId(), getSalary()));
        result.append(System.lineSeparator());
        result.append("Privates: ");
        getPrivates().forEach(priv -> result.append(System.lineSeparator()).append("  ").append(priv));
        return result.toString();
    }

}
