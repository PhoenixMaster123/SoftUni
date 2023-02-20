#include <iostream>
#include <iomanip>
#include <ctype.h>
using namespace std;

int main()
{
    double budget;
    string season;
    cin >> budget >> season;
    double price = 0;

    if (budget <= 100)
    {
        if (season == "summer")
        {
            price = budget * 0.30;
            cout << "Somewhere in Bulgaria " << endl;
            cout << "Camp - " << fixed << setprecision(2) << price << endl;
        }
        else
        {
            price = budget * 0.70;
            cout << "Somewhere in Bulgaria " << endl;
            cout << "Hotel - " << fixed << setprecision(2) << price << endl;
        }
    }
    else if (budget > 100 && budget <= 1000)
    {
        if (season == "summer")
        {
            price = budget * 0.40;
            cout << "Somewhere in Balkans " << endl;
            cout << "Camp - " << fixed << setprecision(2) << price << endl;
        }
        else
        {
            price = budget * 0.80;
            cout << "Somewhere in Balkans " << endl;
            cout << "Hotel - " << fixed << setprecision(2) << price << endl;
        }
    }
    else
    {
        price = budget * 0.90;
        cout << "Somewhere in Europe " << endl;
        cout << "Hotel - " << fixed << setprecision(2) << price << endl;
    }
}