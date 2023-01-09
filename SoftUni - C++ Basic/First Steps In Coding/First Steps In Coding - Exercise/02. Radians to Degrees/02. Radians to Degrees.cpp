#include <iostream>
#include <math.h>
using namespace std;

int main()
{
    double radians;
    cin >> radians;
    double grad = radians * 180 / 3.14;
    cout << round(grad) << endl;
}

