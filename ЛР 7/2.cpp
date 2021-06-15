#include <iostream>

using namespace std;

void sort(double& x, double& y, double& z)
{
    double arr[3] = { x, y , z };
    double min = arr[0], max = arr[0], beet;
    for (int i = 0; i < 3; i++)
    {
        if (arr[i] < min)
            min = arr[i];
        if (arr[i] > max)
            max = arr[i];
    }
    for (int i = 0; i < 3; i++)
    {
        if (arr[i] != min)
        {
            if (arr[i] != max)
                beet = arr[i];
        }
    }
    x = min;
    z = max;
    y = (min + max + beet) / 3;
}

void main()
{
    setlocale(LC_ALL, "Russian");
    double doub_1 = 3.6, doub_2 = 4.5, doub_3 = 2.4;
    cout << doub_1 << " " << doub_2 << " " << doub_3 << endl;
    sort(doub_1, doub_2, doub_3);
    cout << "Наименьшее = " << doub_1 << ", среднее = " << doub_2 << ", наибольшее = " << doub_3 << endl;
    system("pause");
}