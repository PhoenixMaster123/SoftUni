#include <iostream>
using namespace std;


int main()
{
    int nailon, paint, raz, hours;
    cin >> nailon >> paint >> raz >> hours;
    double pricenailon = (nailon + 2) * 1.50;
    double pricepaint = (paint + paint * 0.10) * 14.50;
    double priceraz = raz * 5.00;
    double back = 0.40;
    double allmatirials = pricenailon + pricepaint + priceraz + back;
    double workersprice = (allmatirials * 0.30) * hours;
    double result = allmatirials + workersprice;
    cout.setf(ios::fixed);
    cout.precision(2);
    cout << result << endl;
}
