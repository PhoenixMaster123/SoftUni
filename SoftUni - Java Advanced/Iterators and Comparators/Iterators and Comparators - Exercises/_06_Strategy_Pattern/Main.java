package _06_Strategy_Pattern;

import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Set<Person> personSet1 = new TreeSet<>(new ComparatorNameLength());
        Set<Person> personSet2 = new TreeSet<>(new ComparatorAge());

        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < n; i++) {
            String[] tokens = scanner.nextLine().split(" ");
            String name = tokens[0];
            int age = Integer.parseInt(tokens[1]);

            Person person = new Person(name, age);

            personSet1.add(person);
            personSet2.add(person);
        }
        personSet1.forEach(System.out::println);
        personSet2.forEach(System.out::println);
    }
}
