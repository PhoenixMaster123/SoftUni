package Creational_Patterns.Builder_Pattern;

// Builder design pattern
public class User {
    private String firstName;
    private String lastName;
    private String address;
    private String email;
    private int age;
    private String country;
    private String city;

    public User setLastName(String lastName) {
        this.lastName = lastName;
        return this;
    }

    public User setAddress(String address) {
        this.address = address;
        return this;
    }

    public User setAge(int age) {
        this.age = age;
        return this;
    }

    public User setCountry(String country) {
        this.country = country;
        return this;
    }

    public User setCity(String city) {
        this.city = city;
        return this;
    }

    public User setFirstName(String firstName) {
        this.firstName = firstName;
        return this;
    }
    public User setEmail(String email) {
        this.email = email;
        return this;
    }

}
