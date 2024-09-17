package exercise.Demo;

public class Main
{
    public static void main(String[] args)
    {
        // the things that we put in a map are called buckets
        // Map default value = 15

        // Function hash (hashcode(), 15) -> calculate which index to be put

        // Example: String name = "Kaloyan" -> calculate and is in index 4
        //          String name = "Kristian" -> calculate and is in index 4

        // It's called collision (equal hashcode by keys)
        // -> Like that can be formed LinkedList: "Kaloyan, value", "Kristian", value

        //  O(n) we need to try always need to be the Map O(1)

        // After 8-10 elements is not LinkedList anymore but Tree (better optimization) (Red-Black Tree)

        // AVL Tree -> with get O(log n)

        // under the map is hashtable

        // When we use Map or Set -> hashcode and equals walk together

        // if the hashcode is equivalent then the equals() with take part and we are not going to have
        // duplicate elements
    }
}
