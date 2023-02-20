#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

int main()
{
    string month;
    int sleepDays;
    double apartment = 0.00;
    double studio = 0.00;
    double totalA = 0.00;
    double totalS = 0.00;

    cin >> month >> sleepDays;

    if (month == "May" || month == "October")
    {
        apartment = 65;
        studio = 50;

        if (sleepDays <= 7)
        {
            totalA = apartment * sleepDays;
            totalS = studio * sleepDays;
        }
        else if (sleepDays > 7 && sleepDays <= 14)
        {
            totalS = (studio * sleepDays) * 0.95;
            totalA = apartment * sleepDays;
        }
        else if (sleepDays > 14)
        {
            totalS = (studio * sleepDays) * 0.70;
            totalA = (apartment * sleepDays) * 0.90;
        }
    }
    else if (month == "June" || month == "September")
    {
        apartment = 68.70;
        studio = 75.20;

        if (sleepDays <= 14)
        {
            totalA = apartment * sleepDays;
            totalS = studio * sleepDays;
        }
        else if (sleepDays > 14)
        {
            totalS = (studio * sleepDays) * 0.80;
            totalA = (apartment * sleepDays) * 0.90;
        }
    }
    else if (month == "July" || month == "August")
    {
        apartment = 77;
        studio = 76;

        if (sleepDays <= 14)
        {
            totalA = apartment * sleepDays;
            totalS = studio * sleepDays;
        }
        else if (sleepDays > 14)
        {
            totalA = (apartment * sleepDays) * 0.90;
            totalS = studio * sleepDays;
        }
    }

    cout << "Apartment: " << fixed << setprecision(2) << totalA << " lv." << endl;
    cout << "Studio: " << fixed << setprecision(2) << totalS << " lv." << endl;

    return 0;
}
