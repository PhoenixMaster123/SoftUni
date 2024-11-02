package animals;

public abstract class Animal {
    private String name;
    private int age;
    private String gender;

    public Animal(String name, int age, String gender) {
        this.setName(name);
        this.setAge(age);
        this.setGender(gender);
    }
    abstract String produceSound();
    @Override
    public String toString() {
        return String.format("%s\n" +
                        "%s %d %s\n" +
                        "%s",
                this.getClass().getSimpleName(),
                this.name,
                this.age,
                this.gender,
                this.produceSound()
        );
    }

    public String getName() {
        return this.name;
    }

    public void setName(String name) {
        if (name == null || name.isBlank()) {
            throw new IllegalArgumentException("Invalid input!");
        }
        this.name = name;
    }

    public int getAge() {
        return this.age;
    }

    public void setAge(int age) {
        if(age < 0) {
           throw new IllegalArgumentException("Invalid input!");
        }
        this.age = age;
    }

    public String getGender() {
        return gender;
    }

    public void setGender(String gender) {
        if (gender == null || gender.isBlank()) {
            throw new IllegalArgumentException("Invalid input!");
        }
        this.gender = gender;
    }
}
