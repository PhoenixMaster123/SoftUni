#include <iostream>
using namespace std;

int main()
{
	int num;
	cin >> num;
	if (num == 0)
	{
		cout << "No" << endl;
	}
	else if (num >= -100 && num <= 100)
	{
		cout << "Yes" << endl;
	}
	else
	{
		cout << "No" << endl;
	}
}