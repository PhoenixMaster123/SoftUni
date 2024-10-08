package _01_Jar_of_T;

import java.util.ArrayDeque;

// Generic parameter → wait to be replaced with type data (Integer, String, etc.)
public class Jar<T> { // I can type anything but convection is to type with one letter

    // EW
    private ArrayDeque<T> stack; // stack = null;
    public Jar() {
        this.stack = new ArrayDeque<>(); // if we don't put it in the constructor, we will get NullPointerException
    }

    public void add(T element) {
        stack.push(element);
    }
    public T remove() {
        return stack.pop();
    }
}
