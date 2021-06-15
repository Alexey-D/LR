#include <iostream>

using namespace std;

double avg_harm(double x, double y)
{
    double avg;
    x = ~(int)x;
    y = ~(int)y;
    avg = (x + y) / 2;
    avg = ~(int)avg;
    return avg;
}

void main()
{
    setlocale(LC_ALL, "Russian");
    double doub_1, doub_2;
    cout << "Введите 2 числа\n";
    cin >> doub_1;
    cin >> doub_2;
    cout << "Среднее гармоническое значеие " << doub_1 << " и " << doub_2 << " = " << avg_harm(doub_1, doub_2) << endl;
    system("pause");
}