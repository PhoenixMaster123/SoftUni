package DemoReflectionAndAnotation;

public class AnnotationDemo {
    public static void main(String[] args) {
        Employee employee = new Employee("Peter", "Plowdiw");

        Company company = employee.getClass().getAnnotation(Company.class);

        System.out.println(company.name());
    }
}
