#include <iostream>
using namespace std;
int main()
{
	int points;
	cin >> points;
	double bonusPoints = 0;
	double totalPoints = 0;
	if (points <= 100)
	{
		bonusPoints += 5;
		if (points % 2 == 0)
		{
			bonusPoints++;
		}
		if (points % 10 == 5)
		{
			bonusPoints += 2;
		}
	}
	else if (points > 100 && points <= 1000)
	{
		bonusPoints += points * 0.2;
		if (points % 2 == 0)
		{
			bonusPoints++;
		}
		if (points % 10 == 5)
		{
			bonusPoints += 2;
		}
	}
	else if (points > 1000)
	{
		bonusPoints += points * 0.1;
		if (points % 2 == 0)
		{
			bonusPoints++;
		}
		if (points % 10 == 5)
		{
			bonusPoints += 2;
		}
	}
	totalPoints = points + bonusPoints;
	cout << bonusPoints << endl;
	cout << totalPoints << endl;
}

