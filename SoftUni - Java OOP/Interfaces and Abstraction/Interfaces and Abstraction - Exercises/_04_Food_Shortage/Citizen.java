package _04_Food_Shortage;

public class Citizen implements Person, Birthable, Identifiable, Buyer {
    private String name;
    private int age;
    private String id;
    private String birthDate;
    private int food;
    public Citizen(String name, int age, String id, String birthDate) {
        setName(name);
        setAge(age);
        setId(id);
       setBirthDate(birthDate);
       this.food = 0;
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

    @Override
    public void buyFood() {
        this.food = 10;
    }

    @Override
    public int getFood() {
        return this.food;
    }
}
