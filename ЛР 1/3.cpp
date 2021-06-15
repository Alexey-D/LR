#include <iostream>

using namespace std;

const int M = 3;

int main()
{
	setlocale(LC_ALL, "Russian");
	int array[M][M], definer;
	cout << "Введите элементы матрицы\n";
	for (int i = 0; i < M; i++)
	{
		cout << "Введите элементы " << i + 1 << " строки матрицы\n";
		for (int j = 0; j < M; j++)
			cin >> array[i][j];
	}
	cout << "\nМатрица\n";
	for (int i = 0; i < M; i++)
	{
		for (int j = 0; j < M; j++)
			cout << array[i][j] << "  ";
		cout << endl;
	}
	definer = array[0][0] * array[1][1] * array[2][2] + array[0][1] * array[1][2] * array[2][0] + array[0][2] * array[1][0] * array[2][1] - array[0][2] * array[1][1] * array[2][0] - array[0][1] * array[1][0] * array[2][2] - array[0][0] * array[1][2] * array[2][1];
	cout << "Определитель матрицы = " << definer << endl;
	system("pause");
}