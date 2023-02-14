#include <iostream>
using namespace std;

int main()
{
	int hour, minutes;
	cin >> hour >> minutes;
	int wholeTime = minutes + 15;
	if (wholeTime < 60)
	{
		if (wholeTime < 10)
		{
			
			cout << hour << ":0" << wholeTime << endl;
		}
		else
		{
			cout << hour << ":" << wholeTime << endl;
		}
	}
	else if (hour == 23 && wholeTime >= 60)
	{
		hour++;
		wholeTime -= 60;
		if (wholeTime < 10)
		{

			cout << "0" << ":0" << wholeTime << endl;
		}
		else
		{
			cout << "0" << ":" << wholeTime << endl;
		}
	}
	else
	{
		hour++;
		wholeTime -= 60;
		if (wholeTime < 10)
		{
			cout << hour << ":0" << wholeTime << endl;
		}
		else
		{
			cout << hour << ":" << wholeTime << endl;
		}
	}
}

	
