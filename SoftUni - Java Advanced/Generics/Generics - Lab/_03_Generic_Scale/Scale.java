package _03_Generic_Scale;

public class Scale<T extends Comparable<T>> {
    private T left;
    private T right;

    public Scale(T left, T right) {
        this.left = left;
        this.right = right;
    }

    public T getHeavier(){
        int result = this.left.compareTo(this.right);
        // 0 => equal
        // 1 => left > right
        // -1 => right < left
        if(result == 0) {
            return null;
        }
        else if(result >= 1) {
            return left;
        }
        else {
            return right;
        }
    }

}
