package lab.Demo;

import java.util.HashMap;
import java.util.Map;

public class Main
{
    public static void main(String[] args)
    {
        String name = "Ivan";
        // hashCode() return int
        System.out.println(name.hashCode());

        Map<String, Integer> map = new HashMap<>();

        // When we put in map we hashCode() the key

        // That means that the hashcode decide where the key
        // will be put, which specific index in our HashMap


        // Kolisia -> two items has the same code, and it will be put on the same index

    }
}
