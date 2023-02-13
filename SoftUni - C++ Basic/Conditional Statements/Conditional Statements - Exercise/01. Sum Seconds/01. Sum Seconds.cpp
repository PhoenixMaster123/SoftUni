#include <iostream>
using namespace std;

int main()
{
	int firstTime, secondTime, thirdTime;
	cin >> firstTime >> secondTime >> thirdTime;
	int wholeTime = firstTime + secondTime + thirdTime;
	int minutes = wholeTime / 60;
	int seconds = wholeTime % 60;

	if (seconds < 10)
	{
		cout << minutes << ":0" << seconds << endl;
	}
	else
	{
		cout << minutes << ":" << seconds << endl;
	}
}
