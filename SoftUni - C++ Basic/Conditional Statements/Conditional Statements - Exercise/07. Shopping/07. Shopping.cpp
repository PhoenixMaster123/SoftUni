#include <iostream>
using namespace std;
#include <cmath>
#include <iomanip>
int main()
{
	double budget;
	cin >> budget;
	int videoCards, cpu, ram;
	cin >> videoCards >> cpu >> ram;

	double priceVideoCards = videoCards * 250;
	double priceCPU = cpu * (priceVideoCards * 0.35);
	double priceRAM = ram * (priceVideoCards * 0.10);

	double total = priceVideoCards + priceCPU + priceRAM;
	if (videoCards > cpu)
	{
		total -= total * 0.15;
	}
	if (budget >= total)
	{
		budget -= total;
		cout << "You have " << fixed << setprecision(2) << budget << " leva left!" << endl;
	}
	else
	{
		total -= budget;
		cout << "Not enough money! You need " << fixed << setprecision(2) << total << " leva more!" << endl;
	}
}

