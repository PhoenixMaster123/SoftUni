#include <iostream>
using namespace std;
#include <iomanip>
int main()
{
	double vacationPrice;
	cin >> vacationPrice;
	int puzzels, dols, bears, minions, trucks;
	cin >> puzzels >> dols >> bears >> minions >> trucks;

	double pricePuzzels = puzzels * 2.60;
	double priceDols = dols * 3;
	double priceBears = bears * 4.10;
	double priceMinions = minions * 8.20;
	double priceTrucks = trucks * 2;

	int totalToys = puzzels + dols + bears + minions + trucks;
	double totalMoney = pricePuzzels + priceDols + priceBears + priceMinions + priceTrucks;

	if (totalToys >= 50)
	{
		totalMoney = totalMoney - totalMoney * 0.25;
	}
	double rent = totalMoney * 0.1;
	totalMoney -= rent;
	if (totalMoney >= vacationPrice)
	{
		totalMoney -= vacationPrice;
		cout << "Yes! " << fixed << setprecision(2) << totalMoney << " lv left." << endl;
	}
	else
	{

		vacationPrice -= totalMoney;
		cout << "Not enough money! " << fixed << setprecision(2) << vacationPrice << " lv needed." << endl;
	}
}


