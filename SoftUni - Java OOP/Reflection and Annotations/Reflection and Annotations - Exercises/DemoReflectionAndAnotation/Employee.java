package DemoReflectionAndAnotation;

@Company(name = "SoftUni")
//@Company() // It has default name
public class Employee {
    private String name;
    private String address;
    public Employee(String name, String address) {
        this.name = name;
        this.address = address;
    }
    private Employee() {

    }
    public String toString() {
        return "Employee{" + "name='" + name + '\'' + ", address='" + address + '\'' + '}';
    }

    public String getName() {
        return name;
    }

    public String getAddress() {
        return address;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setAddress(String address) {
        this.address = address;
    }
}
