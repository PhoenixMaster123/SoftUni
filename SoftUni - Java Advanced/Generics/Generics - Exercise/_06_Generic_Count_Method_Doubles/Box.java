package exercise._06_Generic_Count_Method_Doubles;

public class Box<T extends Comparable<T>> {
    private T data;

    public Box(T data) {
        this.data = data;
    }
    public Box() {

    }

    public int compareTo(T e) {
        return this.data.compareTo(e);
    }
}
