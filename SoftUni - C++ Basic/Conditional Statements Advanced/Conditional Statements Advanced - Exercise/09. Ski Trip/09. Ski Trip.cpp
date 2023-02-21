#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

int main() 
{
    int days;
    string typeRoom;
    string rating;
    cin >> days;
    cin.ignore();
    getline(cin, typeRoom);
    getline(cin, rating);
   

    double roomforperson = 18.00;
    double aparthment = 25.00;
    double presidentaparthment = 35.00;

    if (typeRoom == "room for one person")
    {
        days -= 1;
        double price = days * roomforperson;
        if (rating == "positive")
        {
            double difference = price + price * 0.25;
            cout << fixed << setprecision(2) << difference << endl;
        }
        else if (rating == "negative")
        {
            double difference = price + price * 0.10;
            cout << fixed << setprecision(2) << difference << endl;
        }
    }
    else if (typeRoom == "apartment")
    {
        days = days - 1;
        double price = days * aparthment;
        double difference = 0;
        if (days < 10)
        {
            difference = price - price * 0.30;

        }
        else if (days >= 10 && days <= 15)
        {
            difference = price - price * 0.35;

        }
        else if (days > 15)
        {
            difference = price - price * 0.50;

        }
        if (rating == "positive")
        {
            double something = difference + difference * 0.25;
            cout << fixed << setprecision(2) << something << endl;
        }
        else if (rating == "negative")
        {
            double something = difference - difference * 0.10;
            cout << fixed << setprecision(2) << something << endl;
        }

    }

    else if (typeRoom == "president apartment")
    {
        days = days - 1;
        double price = days * presidentaparthment;
        double difference = 0;
        if (days < 10)
        {
            difference = price - price * 0.10;

        }
        else if (days >= 10 && days <= 15)
        {
            difference = price - price * 0.15;

        }
        else if (days > 15)
        {
            difference = price - price * 0.20;

        }
        if (rating == "positive")
        {
            double something = difference + difference * 0.25;
            cout << fixed << setprecision(2) << something << endl;
        }
        else if (rating == "negative")
        {
            double something = difference - difference * 0.10;
            cout << fixed << setprecision(2) << something << endl;
        }
    }
}
