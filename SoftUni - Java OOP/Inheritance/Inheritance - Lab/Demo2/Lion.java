package Demo2;

public class Lion extends Animal{
    // this → we refer to the elements that are in this current class
    // super → refers to the elements that are in the base/father's class
    private String mainColor;

    public Lion(String name, int age, String mainColor) {
        super(name, age);
        this.mainColor = mainColor;
    }

    @Override
    public void eat() {
        System.out.println("The Lion is eating meat!!!");
    }
    public void roar() {
        System.out.println("The lion is roaring and his main color is " + this.mainColor);
    }
}
