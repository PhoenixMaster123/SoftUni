package exercise._07_Google;

public class Company {
    private String companyName;
    private String companyDepartment;

    private double salary;

    public Company(String companyName, String companyDepartment, double salary) {
        this.companyName = companyName;
        this.companyDepartment = companyDepartment;
        this.salary = salary;
    }

    public String getCompanyName() {
        return companyName;
    }

    public String toString()
    {
        return String.format("%s %s %.2f", this.companyName, this.companyDepartment, this.salary);
    }

    public void setCompanyName(String companyName) {
        this.companyName = companyName;
    }

    public String getCompanyDepartment() {
        return companyDepartment;
    }

    public void setCompanyDepartment(String companyDepartment) {
        this.companyDepartment = companyDepartment;
    }

    public double getSalary() {
        return salary;
    }

    public void setSalary(double salary) {
        this.salary = salary;
    }
}
