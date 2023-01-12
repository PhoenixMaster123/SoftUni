#include <iostream>
using namespace std;

int main()
{
	double meters;
	cin >> meters;
	double allground = meters * 7.61;
	double percent = allground * 0.18;
	double result = allground - percent;
	cout << "The final price is: " << result << " lv." << endl;
	cout << "The discount is: " << percent << " lv. " << endl;
}
