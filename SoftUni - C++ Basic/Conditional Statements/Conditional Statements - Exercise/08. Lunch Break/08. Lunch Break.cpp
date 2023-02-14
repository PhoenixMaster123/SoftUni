#include <iostream>
#include <cmath>
#include <iomanip>
#include <string>
using namespace std;

int main()
{
	string serial;
	int durationEpisode, durationBreak;
	getline(cin, serial);
	cin >> durationEpisode >> durationBreak;

	double timeForLunch = durationBreak / 8.0;
	double timeForBreak = durationBreak / 4.0;

	double timeLeft = durationBreak - (timeForLunch + timeForBreak);
	if (timeLeft >= durationEpisode)
	{
		cout << "You have enough time to watch " << serial << " and left with " << ceil(timeLeft - durationEpisode) << " minutes free time." << endl;
	}
	else
	{
		cout << "You don't have enough time to watch " << serial << ", you need " << ceil(durationEpisode - timeLeft) << " more minutes." << endl;
	}
}

