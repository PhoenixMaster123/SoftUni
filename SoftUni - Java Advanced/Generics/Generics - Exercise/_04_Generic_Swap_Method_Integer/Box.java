package exercise._04_Generic_Swap_Method_Integer;

public class Box<T> {
    private T data;

    public Box(T data) {
        this.data = data;
    }

    public String toString() {
        return String.format("%s: %s",this.data.getClass().getName(), this.data);
    }
}
