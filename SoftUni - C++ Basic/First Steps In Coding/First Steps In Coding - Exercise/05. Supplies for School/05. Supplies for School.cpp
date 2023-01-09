#include <iostream>
using namespace std;

int main()
{
	int chimikals, markers, litur, percent;
	cin >> chimikals >> markers >> litur >> percent;
	double pricechimikals = chimikals * 5.80;
	double pricemarkers = markers * 7.20;
	double pricelitur = litur * 1.20;
	double allmatirials = pricechimikals + pricemarkers + pricelitur;
	double result = allmatirials - (allmatirials * percent / 100);
	cout << result << endl;

}
