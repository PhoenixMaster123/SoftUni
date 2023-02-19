#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
    int budget;
    string season;
    int count;
    double price = 0;
    cin >> budget >> season >> count;

    double springships = 3000;
    double summerandautumn = 4200;
    double winterships = 2600;

    if (season == "Winter")
    {
        price = winterships;
    }
    else if (season == "Spring")
    {
        price = springships;
    }
    else if (season == "Summer" || season == "Autumn")
    {
        price = summerandautumn;
    }
    
    if (count <= 6)
    {
        price -= price * 0.10;
    }
    else if (count >= 7 && count <= 11)
    {
        price -= price * 0.15;
    }
    else
    {
        price -= price * 0.25;
    }
    if (count % 2 == 0 && season != "Autumn")
    {
        price -= price * 0.05;
    }

    if (budget >= price)
    {
        double moneyLeft = budget - price;
        cout << "Yes! You have " << fixed << setprecision(2) << moneyLeft << " leva left. " << endl;
    }
    else
    {
        double moneyneeded = price - budget;
        cout << "Not enough money! You need " << fixed << setprecision(2) << moneyneeded << " leva. " << endl;
    }
}