#include <iostream>

using namespace std;

void sort(int* b, int M)
{
    int temp, k;
    for (int i = 0; i < M - 1; i++)
    {
        k = i + 1;
        temp = b[k];
        for (int j = i + 1; j > 0; j--)
        {
            if (temp < b[j - 1])
            {
                b[j] = b[j - 1];
                k = j - 1;
            }
        }
        b[k] = temp;
    }
    
}

void main()
{
    setlocale(LC_ALL, "Russian");
    int* a, N;
    cout << "Введите количество чисел\n";
    cin >> N;
    a = new int[N];
    cout << "Введите элементы массива\n";
    for (int i = 0; i < N; i++)
        cin >> a[i];
    sort(a, N);
    cout << "Отсортированный массив\n";
    for (int i = 0; i < N; i++)
        cout << a[i] << " ";
    cout << endl;
    delete[] a;
    system("pause");
}

