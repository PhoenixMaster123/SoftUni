package lab._09_Serialize_Custom_Object;

import java.io.Serializable;

public class Person implements Serializable
{
    private String name;
    private int age;
    public Person(String name, int age)
    {
        this.name = name;
        this.age = age;
    }
}
