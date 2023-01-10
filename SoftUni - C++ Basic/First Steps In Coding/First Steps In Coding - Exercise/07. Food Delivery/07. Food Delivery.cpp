#include <iostream>
using namespace std;

int main()
{
	int chicken, fish, vegetarian;
	cin >> chicken >> fish >> vegetarian;
	double chickenmenu = chicken * 10.35;
	double fishmenu = fish * 12.40;
	double vegetarianmenu = vegetarian * 8.15;
	double pricemenu = chickenmenu + fishmenu + vegetarianmenu;
	double desert = pricemenu * 0.20;
	double delivery = 2.50;
	double result = pricemenu + desert + delivery;
	cout << result << endl;
}