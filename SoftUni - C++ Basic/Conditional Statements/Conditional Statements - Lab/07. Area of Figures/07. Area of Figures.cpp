#include <iostream>
#include <math.h>
# define M_PI  3.14159265359
using namespace std;

int main()
{
	string text;
	cin >> text;
	if (text == "square")
	{
		double side;
		cin >> side;
		double area = side * side;
		cout.setf(ios::fixed);
		cout.precision(3);
		cout << area << endl;
	}
	else if (text == "triangle")
	{
		double sideA, sideB{};
		cin >> sideA >> sideB;
		double area = (sideA * sideB) / 2;
		cout.setf(ios::fixed);
		cout.precision(3);
		cout << area << endl;
	}
	else if (text == "circle")
	{
		double r;
		cin >> r;
		double area = r * r * M_PI;
		cout.setf(ios::fixed);
		cout.precision(3);
		cout << area << endl;
	}
	else if (text == "rectangle")
	{
		double sideA, sideB;
		cin >> sideA >> sideB;
		double area = sideA * sideB;
		cout.setf(ios::fixed);
		cout.precision(3);
		cout << area << endl;
	}
	return 0;
}

