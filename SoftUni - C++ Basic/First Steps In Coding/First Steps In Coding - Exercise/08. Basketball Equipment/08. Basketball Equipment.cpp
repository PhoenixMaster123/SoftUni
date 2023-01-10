#include <iostream>
using namespace std;


int main()
{
	int trainingTaxes;
	cin >> trainingTaxes;
	double shoes = trainingTaxes - trainingTaxes * 0.40;
	double cloeths = shoes - shoes * 0.20;
	double ball = cloeths * 1 / 4;
	double accesoars = ball * 1 / 5;
	double priceresult = trainingTaxes + shoes + cloeths + ball + accesoars;
	cout << priceresult << endl;
}