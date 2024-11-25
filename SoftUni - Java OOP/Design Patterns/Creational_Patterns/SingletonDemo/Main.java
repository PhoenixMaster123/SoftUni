package Creational_Patterns.SingletonDemo;

public class Main {
    public static void main(String[] args) {
        Database database = Database.getInstance();
        database.add("Kris");
        database.add("Ivan");

        // I will receive the same instance that I created before that
        Database myDatabase = Database.getInstance();
        myDatabase.add("Vik");

    }
}
