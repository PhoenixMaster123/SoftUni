package exercise._02_Company_Roster_02;

import java.util.ArrayList;
import java.util.List;

public class Department {
    private String name;
    private List<Employee> employees;

    public double getAvgSalary() {
       return employees.stream().
               mapToDouble(Employee::getSalary)
               .average()
               .orElse(0.0);
    }
    public Department(String name) {
        this.name = name;
        this.employees = new ArrayList<>();
    }
    public void addEmployee(Employee employee) {
        this.employees.add(employee);
    }

    public String getName() {
        return name;
    }
    public List<Employee> getEmployee() {
        return this.employees;
    }
}
