package coins;

import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		  double change = Double.parseDouble(sc.nextLine());
		  double convert = change * 100;
          int cenc = (int)convert;
          int coins = 0;
          
          while (cenc > 0)
          {
              if (cenc - 200 >= 0)
              {
                  coins++;
                  cenc -= 200;
              }            
              else if (cenc - 100 >= 0)
              {
                  coins++;
                  cenc -= 100;
              }
              else if (cenc - 50 >= 0)
              {
                  coins++;
                  cenc -= 50;
              }
              else if (cenc - 20 >= 0)
              {
                  coins++;
                  cenc -= 20;
              }
              else if (cenc - 10 >= 0)
              {
                  coins++;
                  cenc -= 10;
              }
              else if (cenc - 5 >= 0)
              {
                  coins++;
                  cenc -= 5;
              }
              else if (cenc - 2 >= 0)
              {
                  coins++;
                  cenc -= 2;
              }
              else if (cenc - 1 >= 0)
              {
                  coins++;
                  cenc -= 1;
              }
          }
          System.out.println(coins);
	}

}
