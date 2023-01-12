#include <iostream>
#include <string>
using namespace std;


int main()
{
	string name;
	cin >> name;
	int projects;
	cin >> projects;
	int needHours = projects * 3;
	cout << "The architect " << name << " will need " << needHours << " hours to complete " << projects << " project/s." << endl;
	return 0;
}
