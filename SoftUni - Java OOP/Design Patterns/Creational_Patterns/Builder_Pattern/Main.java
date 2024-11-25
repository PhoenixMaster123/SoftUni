package Creational_Patterns.Builder_Pattern;

public class Main {
    public static void main(String[] args) {
        User user = new User().setAge(20)
                .setEmail("email")
                .setFirstName("Vik")
                .setLastName("Aleksandrov");
    }
}
