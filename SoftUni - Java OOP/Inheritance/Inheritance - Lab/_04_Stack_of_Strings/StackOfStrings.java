package _04_Stack_of_Strings;

import java.util.ArrayList;

public class StackOfStrings {
    private ArrayList<String> data = new ArrayList<>();
    public void push(String item) {
        this.data.addFirst(item);
    }
    public String pop() {
        if(isEmpty()) {
            throw new NullPointerException("The stack is empty");
        }
        return this.data.removeLast();
    }
    public String peek() {
        return this.data.getFirst();
    }
    public boolean isEmpty() {
        return this.data.isEmpty();
    }
}
