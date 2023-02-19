#include <iostream>
#include <iomanip>
using namespace std;

int main()
{

    string flowers;
    int count;
    int budget;
    cin >> flowers >> count >> budget;

    double roses = 5.00;
    double dahlias = 3.80;
    double tulips = 2.80;
    double narcissus = 3.00;
    double gladiolus = 2.50;
    double price = 0;
    if (flowers == "Roses")
    {
        if (count > 80)
        {
            price -= count * roses * 0.10;
        }
        price += count * roses;
    }
    else if (flowers == "Dahlias")
    {
        if (count > 90)
        {
            price -= count * dahlias * 0.15;
        }
        price += count * dahlias;
    }
    else if (flowers == "Tulips")
    {
        if (count > 80)
        {
            price -= count * tulips * 0.15;
        }
        price += count * tulips;
    }
    else if (flowers == "Narcissus")
    {
        if (count < 120)
        {
            price += count * narcissus * 0.15;
        }
        price += count * narcissus;
    }
    else if(flowers == "Gladiolus")
    {
        if (count < 80)
        {
            price += count * gladiolus * 0.20;
        }
        price += count * gladiolus;
    }
    if (budget >= price)
    {
        double moneyLeft = budget - price;
        cout << "Hey, you have a great garden with " << count << " " << flowers << " and " << fixed << setprecision(2) << moneyLeft << " leva left. " << endl;
    }
    else
    {
        double moneyLeft = price - budget;
        cout << "Not enough money, you need " << fixed << setprecision(2) << moneyLeft << " leva more. " << endl;
    }


}