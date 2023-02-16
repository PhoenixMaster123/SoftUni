#include <iostream>
#include <cmath>
#include <iomanip>
using namespace std;

int main()
{
    string fruit;
    string days;
    double quantity;
    cin >> fruit >> days >> quantity;

    double price = 0;

    if (days == "Monday" || days == "Tuesday" || days == "Wednesday" || days == "Thursday" || days == "Friday")
    {
        if (fruit == "banana")
        {
            price = 2.50;
        }
        else if (fruit == "apple")
        {
            price = 1.20;
        }
        else if (fruit == "orange")
        {
            price = 0.85;
        }
        else if (fruit == "grapefruit")
        {
            price = 1.45;
        }
        else if (fruit == "kiwi")
        {
            price = 2.70;
        }
        else if (fruit == "pineapple")
        {
            price = 5.50;
        }
        else if (fruit == "grapes")
        {
            price = 3.85;
        }
    }

    else if (days == "Saturday" || days == "Sunday")
    {
        if (fruit == "banana")
        {
            price = 2.70;
        }
        else if (fruit == "apple")
        {
            price = 1.25;
        }
        else if (fruit == "orange")
        {
            price = 0.90;
        }
        else if (fruit == "grapefruit")
        {
            price = 1.60;
        }
        else if (fruit == "kiwi")
        {
            price = 3.00;
        }
        else if (fruit == "pineapple")
        {
            price = 5.60;
        }
        else if (fruit == "grapes")
        {
            price = 4.20;
        }
    }
    else
    {
        cout << "error" << endl;
    }


    double total = quantity * price;
    if (price != 0)
    {
        cout << fixed << setprecision(2) << total << endl;
    }
}