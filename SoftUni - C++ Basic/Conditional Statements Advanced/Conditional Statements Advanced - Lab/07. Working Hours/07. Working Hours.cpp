#include <iostream>
using namespace std;

int main()
{
	int time;
	string day;
	cin >> time >> day;
	if (time >= 10 && time < 18 || day == "Monday" && day == "Tuesday" && day == "Wednesday" && day == "Thursday" && day == "Friday" && day == "Saturday")
	{
		cout << "open" << endl;
	}
	else
	{
		cout << "closed" << endl;
	}
}