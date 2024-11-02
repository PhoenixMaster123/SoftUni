package Interfaces_and_Abstraction_Demo;

public abstract class Payment {
    private String username;

    public Payment(String username) {
        setUsername(username);
    }
    public abstract void report();

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }
}
