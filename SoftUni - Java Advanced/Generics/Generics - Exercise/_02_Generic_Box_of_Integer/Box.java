package exercise._02_Generic_Box_of_Integer;

public class Box<T> {
    private T data;

    public Box(T data) {
        this.data = data;
    }
    public String toString() {
        return String.format("%s: %s", this.data.getClass().getName(), this.data);
    }
}
