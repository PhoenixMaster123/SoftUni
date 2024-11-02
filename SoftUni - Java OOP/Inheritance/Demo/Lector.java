package Demo;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Lector extends PersonParent {
    private List<String> courses;
    public Lector(String name, String email) {
        super(name, email);
        courses = new ArrayList<>();
    }

    public List<String> getCourses() {
        return Collections.unmodifiableList(this.courses);
    }
    public void addCourse(String course) {
        this.courses.add(course);
    }
}
