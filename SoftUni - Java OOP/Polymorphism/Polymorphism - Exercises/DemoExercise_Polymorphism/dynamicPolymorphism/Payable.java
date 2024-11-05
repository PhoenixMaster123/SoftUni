package DemoExercise_Polymorphism.dynamicPolymorphism;

public interface Payable {

    // Abstract class → Polymorphism (abstract methods) + Code reusability
    // Interfaces → only Polymorphism
    // Inheritance → Code reusability
    static double calculateVat(int amount) {
        return amount * 0.2;
    }

    void pay(int price);
    // Default → add new method without broke the whole code, adding to the other classes right now
    // We need it to other otherwise everything manually.
    // Like that, we can implement for every class step by step and not to add every time
    default void addMoneyToAccount(int money) {
        System.out.printf("Service addMoneyToAccount is not available for %s!\n",
                this.getClass().getSimpleName());
    }
}
