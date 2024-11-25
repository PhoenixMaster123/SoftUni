package Creational_Patterns.SingletonDemo;

import java.util.ArrayList;
import java.util.List;

// Singleton design pattern
public class Database {
    // 2. Field that will store one instance of the class
    private static Database instance;
    private List<Object> objects;

    // 1. private constructor
    private Database() {
        objects = new ArrayList<>();
    }

    // 3. a static method to return that one instance
    public static Database getInstance() {

        // If an instance already exists from this class, then return it.
        if(instance != null) {
            return instance;
        }
        // Create only one instance/object out of this class
        instance = new Database();
        return instance;
    }

    public void add(Object object) {
        this.objects.add(object);
    }
}
