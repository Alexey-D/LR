#include <iostream>

using namespace std;

double average(int* arr, int n)
{
    int sum = 0;
    double avg;
    for (int i = 0; i < n; i++)
        sum += arr[i];
    avg = (float)sum / n;
    return avg;
}

void main()
{
    setlocale(LC_ALL, "Russian");
    int* arr;
    int n;
    cout << "Введите количество элементов массива\n";
    cin >> n;
    arr = new int[n];
    cout << "Введите элементы массива\n";
    for (int i = 0; i < n; i++)
        cin >> arr[i];
    cout << "Массив\n";
    for (int i = 0; i < n; i++)
        cout << arr[i] << "  ";
    cout << "\nСреднее арифметическое данного массива = " << average(arr, n) << endl;
    system("pause");
}