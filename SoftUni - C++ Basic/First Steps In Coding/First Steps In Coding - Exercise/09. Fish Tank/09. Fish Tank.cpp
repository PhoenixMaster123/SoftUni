#include <iostream>
using namespace std;

int main()
{
    int cm, weight, height;
    cin >> cm >> weight >> height;
    double percent;
    cin >> percent;
    double obem = cm * weight * height;
    double obemlitur = obem / 1000;
    double privatestorage = percent / 100;
    double neededliturs = obemlitur * (1 - privatestorage);
    cout.setf(ios::fixed);
    cout.precision(5);
    cout << neededliturs << endl;
}
