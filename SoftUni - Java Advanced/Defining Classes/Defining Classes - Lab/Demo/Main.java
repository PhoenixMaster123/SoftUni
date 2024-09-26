package lab.Demo;

import lab._02_Constructors.Car;

public class Main
{
    public static void main(String[] args) {

        // object <=> instance

        Car_Demo audi = new Car_Demo("Audi", "RS6", 200); // we create an object from the class Car

        // the new keyword allocates memory on the heap (dynamic memory) | heap → object
        // The reference is stored in the stack memory | stack → variable

        Car_Demo bmw = new Car_Demo("BMW", "X5", 100);

        // Classes provide structure for creating objects
        // An object is a single instance of a class

        // Every method that comes from Object class → this method has behaviors
        //--------------------------------------------------------------------------//
        // static methods:

        // If the method is non-static, I need to create an instance (object) of the class

        // Example:

        // Person person = new Person();
        // person.sayHello();

       // If the method is static, I don't need to create an instance (object) of the class

        // Example:

        // Person.sayHello();

        // static can be also a field → only this field can be access with Person.

        Car_Demo.beep();

        Car_Demo car = new Car_Demo();

        car.model = "R";
    }
}
