#include <iostream>
using namespace std;


int main()
{
    int countlists, lists, days;
    cin >> countlists >> lists >> days;
    int hours = countlists / lists;
    int neededhours = hours / days;
    cout << neededhours << endl;

}
