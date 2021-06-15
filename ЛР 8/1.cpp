#include <iostream>

using namespace std;

void division(int num)
{
    int div = 10000, temp;
    for (int i = 0; i < 5; i++)
    {
        temp = num / div;
        cout << temp << endl;
        num %= div;
        div /= 10;
    }
}

void main()
{
    setlocale(LC_ALL, "Russian");
    int num = 0;
    while (num < 10000 || num > 99999)
    {
        cout << "¬ведите п€тизначное число\n";
        cin >> num;
    }
    division(num);
    system("pause");
}