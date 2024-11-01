package _04_Say_Hello_Extended;
public class European extends BasePerson {

    protected European(String name) {
        super(name);
    }

    @Override
    public String sayHello() {
        return "Hello";
    }
}
