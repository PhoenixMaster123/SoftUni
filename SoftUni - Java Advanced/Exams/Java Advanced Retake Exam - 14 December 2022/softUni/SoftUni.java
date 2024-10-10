package softUni;

import java.util.ArrayList;
import java.util.List;

public class SoftUni {
    private int capacity;
    private List<Student> data;

    public SoftUni(int capacity) {
        this.capacity = capacity;
        this.data = new ArrayList<>();
    }

    public int getCapacity() {
        return this.capacity;
    }
    public int getCount() {
        return this.data.size();
    }
    public String insert(Student student) {

        if(capacity == data.size()) {
            return "The hall is full.";
        }
        else if(data.contains(student)) {
            return "Student is already in the hall.";
        }
        else {
            this.data.add(student);
            return "Added student " + student.getFirstName() + " " + student.getLastName() + ".";
        }
    }
    public String remove(Student student) {
        if(!this.data.contains(student)) {
            return "Student not found.";
        }
        else {
            this.data.remove(student);
           return "Removed student " + student.getFirstName() + " " + student.getLastName() + ".";
        }
    }
    public Student getStudent(String firstName, String lastName) {

        for (Student student : data) {
            if(student.getFirstName().equals(firstName) && student.getLastName().equals(lastName)) {
                return student;
            }
        }
        return null;
    }
    public String getStatistics() {
        String str = "";
        str += "Hall size: " + this.data.size() + "\n";
        for (Student student : data) {
            str += "Student: " + student.getFirstName() + " " + student.getLastName() + ", " +
            "Best Course = " + student.getBestCourse() + "\n";
        }
        return str;
    }

}
