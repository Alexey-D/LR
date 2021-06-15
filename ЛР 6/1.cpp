#include <iostream>

using namespace std;

int maximum(int a, int b, int c)
{
	int max = a;
	if (b > max)
		max = b;
	if (c > max)
		max = c;
	return max;
}

void main()
{
	setlocale(LC_ALL, "Russian");
	int int_1, int_2, int_3, max;
	cout << "Введите 3 целых числа\n";
	cin >> int_1;
	cin >> int_2;
	cin >> int_3;
	max = maximum(int_1, int_2, int_3);
	cout << int_1 << " " << int_2 << " " << int_3 << " max = " << max << endl;
	system("pause");
}
