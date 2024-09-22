package exercise._11_Serialize_Custom_Object;

import java.io.Serializable;

public class Course implements Serializable
{
    private String name;
    private int students;

    public Course(String name, int students)
    {
        this.name = name;
        this.students = students;
    }

    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }

    public int getStudents() {
        return students;
    }
    public void setStudents(int students) {
        this.students = students;
    }
}
