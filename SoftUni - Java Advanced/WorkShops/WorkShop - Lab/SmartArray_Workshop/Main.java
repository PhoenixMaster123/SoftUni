package lab.SmartArray_Workshop;

public class Main {
    public static void main(String[] args) {
        SmartArray smartArray = new SmartArray();

        for (int i = 0; i < 5000; i++) {
            smartArray.add(i);
        }
        for (int i = 0; i < 3000; i++) {
            smartArray.remove(0);
        }
    }
}