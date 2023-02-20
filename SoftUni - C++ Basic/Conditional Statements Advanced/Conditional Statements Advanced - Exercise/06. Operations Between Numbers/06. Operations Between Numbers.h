int main()
{
    double n1, n2, result;
    string operators;
    cin >> n1 >> n2 >> operators;
    if (operators == "+")
    {
        result = n1 + n2;
        if (result % 2 == 0)
        {
            cout << n1 << " + " << n2 << " = " << result << " - even" << endl;
        }
        else
        {
            cout << n1 << " + " << n2 << " = " << result << " - odd" << endl;
        }
    }
    else if (operators == "-")
    {
        result = n1 - n2;
        if (result % 2 == 0)
        {
            cout << n1 << " - " << n2 << " = " << result << " - even" << endl;
        }
        else
        {
            cout << n1 << " - " << n2 << " = " << result << " - odd" << endl;
        }
    }
    else if (operators == "*")
    {
        result = n1 * n2;
        if (result % 2 == 0)
        {
            cout << n1 << " * " << n2 << " = " << result << " - even" << endl;
        }
        else
        {
            cout << n1 << " * " << n2 << " = " << result << " - odd" << endl;
        }
    }
    else if (operators == "/")
    {
        result = n1 / n2;
        if (n2 != 0)
        {
            cout << n1 << " / " << n2 << " = " << fixed << setprecision(2) << result << endl;
        }
        else if (n2 == 0)
        {
            cout << "Cannot divide " << n1 << " by zero" << endl;
        }
    }
    else if (operators == "%")
    {
        result = n1 % n2;

        if (n2 != 0)
        {
            cout << n1 << " % " << n2 << " = " << result << endl;
        }
        else if (n2 == 0)
        {
            cout << "Cannot divide " << n1 << " by zero" << endl;
        }
    }
    return 0;
}
