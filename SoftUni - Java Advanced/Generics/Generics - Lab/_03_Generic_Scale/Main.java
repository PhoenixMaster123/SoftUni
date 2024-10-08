package _03_Generic_Scale;

public class Main {
    public static void main(String[] args) {
        Scale<Integer> numbers = new Scale<>(30, 50);

        System.out.println(numbers.getHeavier());
    }
}
