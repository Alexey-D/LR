#include <iostream>

using namespace std;

const int N = 10;

void set(int* a, int size)
{
	cout << "Введите элементы массива\n";
	for (int i = 0; i < size; i++)
		cin >> a[i];
}

void get(int* a, int size)
{
	cout << "\nМассив\n";
	for (int i = 0; i < size; i++)
		cout << a[i] << "  ";
	cout << endl;
}

void change(int* a, int size)
{
	for (int i = 0; i < size; i++)
	{
		if (a[i] % 2 == 0)
			a[i] = 0;
	}
}

void main()
{
	setlocale(LC_ALL, "Russian");
	int array[N];
	set(array, N);
	get(array, N);
	change(array, N);
	get(array, N);
	system("pause");
}