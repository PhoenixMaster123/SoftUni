package exercise._07_Google;

import java.util.ArrayList;
import java.util.List;

public class Parent {
    private String parentName;
    private String dateOfBirthday;

    public Parent(String parentName, String dateOfBirthday) {
        this.parentName = parentName;
        this.dateOfBirthday = dateOfBirthday;
    }
    public String toString() {
       return this.parentName + " " + this.dateOfBirthday;
    }

    public String getParentName() {
        return parentName;
    }

    public void setParentName(String parentName) {
        this.parentName = parentName;
    }

    public String getDateOfBirthday() {
        return dateOfBirthday;
    }

    public void setDateOfBirthday(String dateOfBirthday) {
        this.dateOfBirthday = dateOfBirthday;
    }
}
