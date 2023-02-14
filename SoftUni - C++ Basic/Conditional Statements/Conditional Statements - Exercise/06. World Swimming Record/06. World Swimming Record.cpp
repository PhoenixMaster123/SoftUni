#include <iostream>
using namespace std;
#include <cmath>
#include <iomanip>
int main()
{
	double recordInSeconds, distanceInMeters,timeInSeconds;
	cin >> recordInSeconds >> distanceInMeters >> timeInSeconds;

	double time = distanceInMeters * timeInSeconds;
	double timeAdd = (distanceInMeters / 15);
	timeAdd = floor(timeAdd) * 12.5;

	double allTime = time + timeAdd;

	if (recordInSeconds > allTime)
	{
		cout << "Yes, he succeeded! The new world record is " << fixed << setprecision(2) << allTime << " seconds." << endl;
	}
	else
	{
		allTime -= recordInSeconds;
		cout << "No, he failed! He was " << fixed << setprecision(2) << allTime << " seconds slower." << endl;
	}
}

