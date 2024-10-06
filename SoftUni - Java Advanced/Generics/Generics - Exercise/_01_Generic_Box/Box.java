package exercise._01_Generic_Box;

public class Box<T> {

    private T data;

    public Box(T data) {
        this.data = data;
    }

    public String toString() {
        return String.format("%s: %s",this.data.getClass().getName(), this.data);
    }
}
