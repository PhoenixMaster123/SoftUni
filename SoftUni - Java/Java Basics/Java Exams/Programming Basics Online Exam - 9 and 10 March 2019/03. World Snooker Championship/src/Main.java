import java.util.Scanner;

public class Main {
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);

        String competition = sc.nextLine();
        String ticketArt = sc.nextLine();
        int countTickets = Integer.parseInt(sc.nextLine());
        char trophy = sc.nextLine().charAt(0);
        double total = 0;
        if(competition.equals("Quarter final"))
        {
            if(ticketArt.equals("Standard"))
            {
                total += countTickets * 55.50;
            }
            else if(ticketArt.equals("Premium"))
            {
                total += countTickets * 105.20;
            }
            else
            {
                total += countTickets * 118.90;
            }
        }
        else if(competition.equals("Semi final"))
        {
            if(ticketArt.equals("Standard"))
            {
                total += countTickets * 75.88;
            }
            else if(ticketArt.equals("Premium"))
            {
                total += countTickets * 125.22;
            }
            else
            {
                total += countTickets * 300.40;
            }
        }
        else
        {
            if(ticketArt.equals("Standard"))
            {
                total += countTickets * 110.10;
            }
            else if(ticketArt.equals("Premium"))
            {
                total += countTickets * 160.66;
            }
            else
            {
                total += countTickets * 400;
            }
        }

        if(total > 4000 && trophy == 'Y')
        {
            total -= total * 0.25;
        }
        else if(total > 4000)
        {
            total -= total * 0.25;
        }
        else if(total > 2500 && trophy == 'Y')
        {
            total -= total * 0.10;
            total += countTickets * 40;
        }
        else if(total > 2500)
        {
            total -= total * 0.10;
        }
        else if (total < 2500 && trophy == 'Y')
        {
            total += countTickets * 40;
        }
        System.out.printf("%.2f",total);


    }
}