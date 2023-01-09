#include <iostream>
using namespace std;

int main()
{
	double usd;
	cin >> usd;
	double bg = 1.79549;
	double result = usd * bg;
	cout.setf(ios::fixed);
	cout.precision(2);
	cout << result;
	

}
