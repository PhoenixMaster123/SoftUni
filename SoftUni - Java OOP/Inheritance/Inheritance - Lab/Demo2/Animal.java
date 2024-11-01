package Demo2;
public class Animal {
    // When the child inherits the base class, is the best to be private (getter/setter) the attributes
    private String name;
    private int age;
    public Animal(String name, int age) {
        setName(name);
        setAge(age);
    }
    public void eat() {
        System.out.println("This animal is eating..."); // default
        System.out.println();
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        // validation
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }
}
