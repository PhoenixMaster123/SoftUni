#include <iostream>
using namespace std;

int main()
{
	string day;
	cin >> day;
	if (day == "Monday" || day == "Tuesday" || day == "Friday")
	{
		cout << 12 << endl;
	}
	else if (day == "Wednesday" || day == "Thursday")
	{
		cout << 14 << endl;
	}
	else
	{
		cout << 16 << endl;
	}
}