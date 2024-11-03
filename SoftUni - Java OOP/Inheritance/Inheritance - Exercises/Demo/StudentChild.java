package Demo;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class StudentChild extends PersonParent {
    private List<Integer> grades;
    public StudentChild(String name, String email) {
        super(name, email);
        this.grades = new ArrayList<>();
    }

    public List<Integer> getGrades() {
        return Collections.unmodifiableList(this.grades);
    }
    public void addGrade(int grade) {
        this.grades.add(grade);
    }
}
