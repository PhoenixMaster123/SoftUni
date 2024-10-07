package Demo_Varargs;

import java.util.List;
import java.util.Map;

public class Main {
    public static void main(String[] args) {
        // Varargs (Variable Arguments)

        String[] names = new String[5];

        // Varargs → give us to give arguments from (0 to n)
        // Rules:
        // 1. We can only use one vararg argument, we cannot make more than one varargs.
        // 2. Type varargs can only be used for arguments in a method. (Wrong: String... books = "dasd", "dasdaf");
        // 3. Type varargs needs to be last as argument in a method (Wrong: String...books, String city)

        print("e", "kris", "vik");
        print(); // works again

    }
    private static void print(String... names) { // Variable Arguments (0 - n)

        // This varargs parameter will work like an array
        for (String name : names) {
            System.out.println(name);
        }
    }
    private static void printList(List<String>... lists) { // 0 - n lists
        for (List<String> list : lists) {
            
        }
    }
    private static void printMap(Map<String, Integer>... lists) { // 0 - n map
        for (Map<String, Integer> list : lists) {
            
        }
    }
    private static void printList(String[]... lists) { // 0 - n like a matrix
        for (String[] list : lists) {

        }
    }
}
