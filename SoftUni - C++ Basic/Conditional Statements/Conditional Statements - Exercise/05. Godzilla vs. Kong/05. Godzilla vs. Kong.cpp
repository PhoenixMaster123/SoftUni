#include <iostream>
using namespace std;
#include <iomanip>
int main()
{
	double budget;
	cin >> budget;
	int statics;
	cin >> statics;
	double clothes;
	cin >> clothes;
	double total;
	double decor = budget * 0.1;
	double priceCloethes = statics * clothes;
	if (statics > 150)
	{
		priceCloethes = priceCloethes - priceCloethes * 0.1;
	}
	total = decor + priceCloethes;

	if (budget >= total)
	{
		budget -= total;
		cout << "Action!" << endl;
		cout << "Wingard starts filming with " << fixed << setprecision(2) << budget << " leva left." << endl;
	}
	else
	{
		total -= budget;
		cout << "Not enough money!" << endl;
		cout << "Wingard needs " << fixed << setprecision(2) << total << " leva more." << endl;
	}
}

