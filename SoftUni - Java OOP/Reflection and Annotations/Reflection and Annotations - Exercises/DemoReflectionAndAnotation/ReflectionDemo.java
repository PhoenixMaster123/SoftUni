package DemoReflectionAndAnotation;

import java.lang.reflect.*;

public class ReflectionDemo {
    public static void main(String[] args) throws ClassNotFoundException, NoSuchMethodException, InvocationTargetException, InstantiationException, IllegalAccessException {


        // Access class Variant 1:

        Class<Employee> employeeClass1 = Employee.class;

        // Access class Variant 2:

        //Class<Employee> employeeClass2 = (Class<Employee>) Class.forName("Employee");

        // Access class Variant 3:

        //Employee employee = new Employee("Peter", "sofia");
        //Class<? extends Employee> employeeClass3 = employee.getClass();

        // Access all fields:

        Field[] allFields = employeeClass1.getDeclaredFields(); // return all fields (public, private, protected)

        // Access only public fields:

        Field[] publicFields = employeeClass1.getFields(); // return all public fields

        for (Field field : allFields) {
            System.out.println(field.getName());
            System.out.println(Modifier.toString(field.getModifiers())); // it will give the exact modifier otherwise only an integer
            System.out.println(Modifier.isPrivate(field.getModifiers())); // check if the field is private
        }

        // Access constructors:

        Constructor<Employee> allArgConstructor = employeeClass1.getDeclaredConstructor(String.class, String.class);// String.class -> parameters
        Constructor<Employee> noArgConstructor = employeeClass1.getDeclaredConstructor();

        Employee employee = allArgConstructor.newInstance("Peter", "Sofia"); // we created a new instance of employee class
        noArgConstructor.setAccessible(true); // we receive access to private parts of a given class (otherwise we cannot)
        Employee employee1 = noArgConstructor.newInstance();

        // Access methods:

        Method[] allMethods = employeeClass1.getDeclaredMethods(); // return all methods
        Method[] publicMethods = employeeClass1.getMethods(); // return all public methods + public methods that are inherited

        Method toStringMethod = allMethods[1];
        System.out.println(toStringMethod.invoke(employee)); // call the method to an object

        Field privateField = allFields[0];
        privateField.setAccessible(true);
        privateField.set(employee1, "Kaloyan");
        System.out.println();
        System.out.println(toStringMethod.invoke(employee));

    }
}
