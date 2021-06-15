#include <iostream>
#include <string>
#include <cctype>

using namespace std;

void main()
{
	setlocale(LC_ALL, "Russian");
	char sym;
	string str;
	int sig = 1;
	cout << "Введите символ\n";
	cin >> sym;
	while (sig)
	{
		if (isalpha(sym))
			sig = 0;
		else
		{
			cout << "Введите символ\n";
			cin >> sym;
		}
	}
	sig = 1;
	cout << "Введите строку\n";
	cin >> str;
	int len;
	len = str.length();
	while (sig)
	{
		for (int i = 0; i < len; i++)
		{
			if (isalpha(str[i]))
			{
				if (i == len - 1)
					sig = 0;
			}
			else
			{
				cout << "Введите строку\n";
				cin >> str;
				len = str.length();
				break;
			}
		}
	}
	for (int i = 0; i < len; i++)
	{
		if (str[i] == sym)
		{
			cout << "Номер символа в строке - " << i + 1 << endl;
			break;
		}
		if (i == len - 1)
			cout << "Символ в строке отсутствует\n";
	}
	system("pause");
}