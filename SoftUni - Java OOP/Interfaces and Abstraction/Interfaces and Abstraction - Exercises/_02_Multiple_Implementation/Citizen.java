package _02_Multiple_Implementation;

public class Citizen implements Person, Birthable, Identifiable{
    private String name;
    private int age;
    private String id;
    private String birthDate;
    public Citizen(String name, int age, String id, String birthDate) {
        setName(name);
        setAge(age);
        setId(id);
       setBirthDate(birthDate);

    }
    @Override
    public String getName() {
        return this.name;
    }

    @Override
    public int getAge() {
        return this.age;
    }

    private void setName(String name) {
        this.name = name;
    }

    private void setAge(int age) {
        this.age = age;
    }

    public String getId() {
        return id;
    }

    private void setId(String id) {
        this.id = id;
    }

    public String getBirthDate() {
        return birthDate;
    }

    private void setBirthDate(String birthDate) {
        this.birthDate = birthDate;
    }
}
