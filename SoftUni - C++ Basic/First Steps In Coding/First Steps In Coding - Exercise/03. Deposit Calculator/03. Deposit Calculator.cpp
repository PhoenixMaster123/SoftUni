#include <iostream>
using namespace std;

int main()
{
	double depositValue;
	cin >> depositValue;
	int month;
	cin >> month;
	double yearpercent;
	cin >> yearpercent;
	double percent = depositValue * yearpercent / 100;
	double foronemoth = percent / 12;
	double result = depositValue + month * foronemoth;
	cout.setf(ios::fixed);
	cout.precision(2);
	cout << result << endl;
}