#include <iostream>
using namespace std;

int main()
{
	string product, city;
	double quantity;
	cin >> product >> city >> quantity;

	if (city == "Sofia")
	{
		if (product == "coffee")
		{

			cout << 0.5 * quantity << endl;
		}
		else if (product == "water")
		{

			cout << 0.8 * quantity << endl;
		}
		else if (product == "beer")
		{

			cout << 1.2 * quantity << endl;
		}
		else if (product == "sweets")
		{

			cout << 1.45 * quantity << endl;
		}
		else
		{
			cout << 1.60 * quantity << endl;
		}
	}

	else if (city == "Plovdiv")
	{
		if (product == "coffee")
		{

			cout << 0.4 * quantity << endl;
		}
		else if (product == "water")
		{

			cout << 0.7 * quantity << endl;
		}
		else if (product == "beer")
		{

			cout << 1.15 * quantity << endl;
		}
		else if (product == "sweets")
		{

			cout << 1.30 * quantity << endl;
		}
		else
		{
			cout << 1.50 * quantity << endl;
		}
	}
	else
	{
		if (product == "coffee")
		{

			cout << 0.45 * quantity << endl;
		}
		else if (product == "water")
		{

			cout << 0.7 * quantity << endl;
		}
		else if (product == "beer")
		{

			cout << 1.10 * quantity << endl;
		}
		else if (product == "sweets")
		{

			cout << 1.35 * quantity << endl;
		}
		else
		{
			cout << 1.55 * quantity << endl;
		}
	}
}