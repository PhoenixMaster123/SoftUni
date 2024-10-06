package exercise._05_Generic_Count_Method_String;

public class Box<T extends Comparable<T>> {
    private T data;

    public Box(T data) {
        this.data = data;
    }
    public String toString() {
        return String.format("%s: %s", this.data.getClass().getName(), this.data);
    }
    public int compareTo(T o) {
        return this.data.compareTo(o);
    }

}