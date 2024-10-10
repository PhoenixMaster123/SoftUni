package _05_Comparing_Objects;

public class Person implements Comparable<Person> {
    private String name;
    private int age;
    private String town;

    public Person(String name, int age, String town) {
        this.name = name;
        this.age = age;
        this.town = town;
    }

    @Override
    public int compareTo(Person person) {
        int result = 0;

        if(this.name.equals(person.name)) {
            if(this.age == person.age) {
               return this.town.compareTo(person.town);
            }
        }
        return this.name.compareTo(person.name);
    }
}
