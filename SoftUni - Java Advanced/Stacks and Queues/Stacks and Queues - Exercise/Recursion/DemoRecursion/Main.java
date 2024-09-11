package Recursion.DemoRecursion;

public class Main
{
    public static void main(String[] args)
    {
        methodA(5);
    }
    private static void methodA(int count)
    {
        System.out.println("Invoke methodA");
        if(count == 1)
        {
            return;
        }
        methodA(count - 1);

    }
}
