package lab._02_SoftUni_Party;

import java.util.*;

public class Main
{
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        Set<String> regularGuest = new TreeSet<>();
        Set<String> vipGuest = new TreeSet<>();

        String guest = scanner.nextLine();


        while (!guest.equals("PARTY"))
        {
            if(Character.isDigit(guest.charAt(0)))
            {
                vipGuest.add(guest);
            }
            else
            {
                regularGuest.add(guest);
            }
                guest = scanner.nextLine();
        }
        guest = scanner.nextLine();
        while (!guest.equals("END"))
        {
            /*if(vipGuest.contains(guest))
            {
                vipGuest.remove(guest);
            }
            else
            {
                regularGuest.remove(guest);
            }
             */
            // We don't need contains in Set bc if it is there we remove it otherwise not
            vipGuest.remove(guest);
            regularGuest.remove(guest);

            guest = scanner.nextLine();
        }
        System.out.println(vipGuest.size() + regularGuest.size());
        vipGuest.forEach(System.out::println);
        regularGuest.forEach(System.out::println);
    }
}
