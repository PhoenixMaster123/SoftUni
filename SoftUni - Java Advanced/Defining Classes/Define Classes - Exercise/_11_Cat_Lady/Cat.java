package exercise._11_Cat_Lady;

public class Cat {
    public String name;
    public String type;

    public Cat(String name, String type) {
        this.name = name;
        this.type = type;
    }
    public String toString() {
        return String.format("%s %s", this.type, this.name);
    }

}
