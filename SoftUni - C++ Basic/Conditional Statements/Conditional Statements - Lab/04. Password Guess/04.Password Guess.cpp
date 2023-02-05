#include <iostream>
using namespace std;

int main()
{
	string text;
	cin >> text;
	if (text == "s3cr3t!P@ssw0rd")
	{
		cout << "Welcome" << endl;
	}
	else
	{
		cout << "Wrong password!" << endl;
	}
	return 0;
}

