#include <iostream>
#include <cmath>

using namespace std;

int main() {
    int hoursexam, minutsexam, cominghours, comingminuts;

    cin >> hoursexam >> minutsexam >> cominghours >> comingminuts;

    int difference = 0;
    int hour = 0;
    int minuts = 0;

    minutsexam += hoursexam * 60;
    comingminuts += cominghours * 60;

    if (comingminuts > minutsexam) {
        cout << "Late" << endl;
        difference = comingminuts - minutsexam;
        if (difference < 60) {
            cout << difference << " minutes after the start" << endl;
        }
        else {
            hour = difference / 60;
            minuts = difference % 60;
            cout << hour << ":" << minuts / 10 << minuts % 10 << " hours after the start" << endl;
        }
    }
    else if (comingminuts < minutsexam - 30) {
        cout << "Early" << endl;
        difference = minutsexam - comingminuts;
        if (difference < 60) {
            cout << abs(difference) << " minutes before the start" << endl;
        }
        else {
            hour = difference / 60;
            minuts = difference % 60;
            cout << hour << ":" << minuts / 10 << minuts % 10 << " hours before the start" << endl;
        }
    }
    else {
        cout << "On time" << endl;
        difference = minutsexam - comingminuts;
        cout << difference << " minutes before the start" << endl;
    }

    return 0;
}
