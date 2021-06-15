#include <iostream>
#include <string>

using namespace std;

string zip(string str)
{
	string new_str;
	int len, count, temp;
	len = str.length();
	for (int i = 0; i < len - 1; i++)
	{
		if (str[i] == str[i + 1])
		{
			count = 2;
			i++;
			for (int j = i; j < len - 1; j++)
			{
				if (str[i] == str[i + 1])
				{
					count++;
					i++;
				}
			}
			temp = (int)str[i];
			new_str += "(" + to_string(temp) + "-" + to_string(count) + ")";
		}
		else
		{
			new_str += str[i];
			if (i == len - 2)
				new_str += str[i + 1];
		}
	}
	return new_str;
}

string unzip(string str)
{
	string new_str, temp;
	int len, sym, num;
	len = str.length();
	for (int i = 0; i < len; i++)
	{
		if (str[i] == '(')
		{
			i++;
			while (str[i] != '-')
			{
				temp += str[i];
				i++;
			}
			i++;
			sym = stoi(temp);
			temp = "";
			while (str[i] != ')')
			{
				temp += str[i];
				i++;
			}
			num = stoi(temp);
			for (int j = 0; j < num; j++)
				new_str += char(sym);
			temp = "";
		}
		else
			new_str += str[i];
	}
	return new_str;
}

void main()
{
	setlocale(LC_ALL, "Russian");
	string s;
	cout << "Введите строку\n";
	cin >> s;
	s = zip(s);
	cout << "Архивированная строка\n";
	cout << s << endl;
	s = unzip(s);
	cout << "Разархивированная строка\n";
	cout << s << endl;
	system("pause");
}
