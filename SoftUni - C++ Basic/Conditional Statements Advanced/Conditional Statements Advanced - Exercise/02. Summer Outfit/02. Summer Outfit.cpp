#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	int degree;
	string timeOfDay;
	cin >> degree >> timeOfDay;
	if (degree >= 10 && degree <= 18)
	{
		if (timeOfDay == "Morning")
		{
			cout << "It's " << degree << " degrees, get your Sweatshirt and Sneakers." << endl;
		}
		else if (timeOfDay == "Afternoon" || timeOfDay == "Evening")
		{
			cout << "It's " << degree << " degrees, get your Shirt and Moccasins." << endl;
		}
	}
	else if (degree > 18 && degree <= 24)
	{
		if (timeOfDay == "Morning" || timeOfDay == "Evening")
		{
			cout << "It's " << degree << " degrees, get your Shirt and Moccasins." << endl;
		}
		else if (timeOfDay == "Afternoon")
		{
			cout << "It's " << degree << " degrees, get your T-Shirt and Sandals." << endl;
		}
	}
	else
	{
		if (timeOfDay == "Morning")
		{
			cout << "It's " << degree << " degrees, get your T-Shirt and Sandals." << endl;
		}
		else if (timeOfDay == "Afternoon")
		{
			cout << "It's " << degree << " degrees, get your Swim Suit and Barefoot." << endl;
		}
		else
		{
			cout << "It's " << degree << " degrees, get your Shirt and Moccasins." << endl;
		}
	}
}