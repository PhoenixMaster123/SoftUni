#include <iostream>
#include <string>
using namespace std;

int main()
{
	int fooddog, catfood;
	cin >> fooddog >> catfood;
	double pricedog = fooddog * 2.50;
	double pricecat = catfood * 4;
	double result = pricedog + pricecat;
	cout << result << " lv. " << endl;
}
