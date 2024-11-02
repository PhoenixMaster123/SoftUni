package _06_Military_Elite.general;

import _06_Military_Elite.privvate.Private;

import java.util.Collection;

public interface LieutenantGeneral {
    void addPrivate(Private priv);
    public Collection<Private> getPrivates();
}
