package _01_Jar_of_T;

public class Main {
    public static void main(String[] args) {

        Jar<String> jar = new Jar<>();

        jar.add("Kris");
        jar.add("Gosho");
        System.out.println(jar.remove());
        System.out.println(jar.remove());

        Jar<Integer> jarNum = new Jar<>();

        jarNum.add(2);
        jarNum.add(1);
    }
}