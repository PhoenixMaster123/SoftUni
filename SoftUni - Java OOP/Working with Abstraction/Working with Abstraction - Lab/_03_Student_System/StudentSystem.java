package _03_Student_System;

import java.util.HashMap;
import java.util.Map;

public class StudentSystem {
    private Map<String, Student> studentMap;

    public StudentSystem() {
        this.studentMap = new HashMap<>();
    }

    public Map<String, Student> getStudentMap() {
        return this.studentMap;
    }

    public void parseCommand(String[]args) {

        String commandName  = args[0];
        if (commandName.equals("Create")) {
            String name = args[1];
            int age = Integer.parseInt(args[2]);
            double grade =Double.parseDouble(args[3]);
            studentMap.putIfAbsent(name, new Student(name,age,grade));
        }
        else if (commandName.equals("Show")) {
            String name = args[1];
            if (studentMap.containsKey(name)) {
                Student student = studentMap.get(name);
                String view = String.format("%s is %s years old.",student.getName(),student.getAge());

                view += checkGrade(student.getGrade());

                System.out.println(view);
            }
        }
    }

    private String checkGrade(double grade) {
        if (grade >= 5.00) {
            return " Excellent student.";
        }
        else if (grade < 5.00 && grade >= 3.50) {
           return " Average student.";
        }
        else {
            return " Very nice person.";
        }
    }
}
