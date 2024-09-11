package Recursion.Fibonacci;

import java.util.Scanner;

public class Main
{
    private static long[] memory;
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        memory = new long[n + 1];
        System.out.print(Fib(n));
    }

    ////////////////////////////// Rekursion - fast ////////////////////////////////////

    /*
    Memoization:
    When we add memory, it is as if we used recursion to find a single number, example 7 = 21
    if we make a one-time calculation we store them in the memory array and if we need it again the same
    calculation simply returns the calculation that is stored in the array and don't make the same recursion again.
     */

    private static long Fib(int n)
    {
        if (n < 2)
        {
            return 1;
        }
        if(memory[n] != 0)
        {
            return memory[n];
        }
        else
        {
            memory[n] = Fib(n - 1) + Fib(n - 2);
            return memory[n];
        }
    }
    ////////////////////////////// Rekursion - slow ////////////////////////////////////
    /* private static long Fib(int n)
    {
        if(n == 0)
        {
            return 0;
        }
        else if(n == 1 || n == 2)
        {
            return 1;
        }
        else
        {
           return Fib(n - 1) + Fib(n - 2);
        }
    }
     */
}
