#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
	string ticketType;
	int rows, cols;
	cin >> ticketType >> rows >> cols;
	double ticketPrice = 0;
	double allSeats = rows * cols;
	if (ticketType == "Premiere")
	{
		ticketPrice = 12 * allSeats;
	}
	else if (ticketType == "Normal")
	{
		ticketPrice = 7.50 * allSeats;
	}
	else if (ticketType == "Discount")
	{
		ticketPrice = 5 * allSeats;
	}
	//////////////////////////////////////////////////////////////////////// First Variant /////////////////////////////////
	cout.setf(ios::fixed);
	cout.precision(2);
	cout << ticketPrice << " leva" << endl;
	//////////////////////////////////////////////////////////////////////// Second Variant ////////////////////////////////
	// cout << fixed << setprecision(2) << ticketPrice << endl;
}