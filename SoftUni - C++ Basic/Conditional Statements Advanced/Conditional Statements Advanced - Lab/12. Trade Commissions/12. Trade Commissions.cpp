#include <iostream>
#include <cmath>
#include <iomanip>
#include <string>
using namespace std;

int main()
{
    string city;
    double sales;
    cin >> city >> sales;

    double commision = 0.0;

    if (city == "Sofia")
    {
        if (sales >= 0 && sales <= 500)
        {
            commision = 0.05;
            cout << fixed << setprecision(2) << sales  * commision << endl;
        }
        else if (sales > 500 && sales <= 1000)
        {
            commision = 0.07;
            cout << fixed << setprecision(2) << sales * commision << endl;
        }
        else if (sales > 1000 && sales <= 10000)
        {
            commision = 0.08;
            cout << fixed << setprecision(2) << sales * commision << endl;
        }
        else if (sales > 10000)
        {
            commision = 0.12;
            cout << fixed << setprecision(2) << sales * commision << endl;
        }
        else
        {
            cout << "error" << endl;
        }
    }
    else if (city == "Varna")
    {
        if (sales >= 0 && sales <= 500)
        {
            commision = 0.045;
            cout << fixed << setprecision(2) << sales * commision << endl;
        }
        else if (sales > 500 && sales <= 1000)
        {
            commision = 0.075;
            cout << fixed << setprecision(2) << sales * commision << endl;
        }
        else if (sales > 1000 && sales <= 10000)
        {
            commision = 0.10;
            cout << fixed << setprecision(2) << sales * commision << endl;
        }
        else if (sales > 10000)
        {
            commision = 0.13;
            cout << fixed << setprecision(2) << sales * commision << endl;
        }
        else
        {
            cout << "error" << endl;
        }
    }
    else if (city == "Plovdiv")
    {
        if (sales >= 0 && sales <= 500)
        {
            commision = 0.055;
            cout << fixed << setprecision(2) << sales * commision << endl;
        }
        else if (sales > 500 && sales <= 1000)
        {
            commision = 0.08;
            cout << fixed << setprecision(2) << sales * commision << endl;
        }
        else if (sales > 1000 && sales <= 10000)
        {
            commision = 0.12;
            cout << fixed << setprecision(2) << sales * commision << endl;
        }
        else if (sales > 10000)
        {
            commision = 0.145;
            cout << fixed << setprecision(2) << sales * commision << endl;
        }
        else
        {
            cout << "error" << endl;
        }
    }
    else
    {
        cout << "error" << endl;
    }
}