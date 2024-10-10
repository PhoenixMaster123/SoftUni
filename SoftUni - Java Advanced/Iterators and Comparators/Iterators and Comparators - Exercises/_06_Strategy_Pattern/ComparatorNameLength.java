package _06_Strategy_Pattern;

import java.util.Comparator;

public class ComparatorNameLength implements Comparator<Person> {

    @Override
    public int compare(Person p1, Person p2) {

        if(p1.getName().length() == p2.getName().length()) {
            return Character.compare(p1.getName().toUpperCase().charAt(0), p2.getName().toUpperCase().charAt(0));
        }
        return Integer.compare(p1.getName().length(), p2.getName().length());
    }
}
