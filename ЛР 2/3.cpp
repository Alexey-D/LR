#include <iostream>
#include <string>
#include <ctime>

using namespace std;

string rand_string()
{
    int* a, N;
    string random;
    srand(time(0));
    N = rand() % 10 + 2;
    a = new int[N];
    for (int i = 0; i < N; i++)
        a[i] = rand() % 26 + 97;
    for (int i = 0; i < N; i++)
        random += (char)a[i];
    return random;
}

string swap_sub(string str_f, string sub_f, string new_sub_f)
{
    string new_str_f;
    int len1, len2, start, point = 0;
    len1 = str_f.length();
    len2 = sub_f.length();
    for (int i = 0; i < len1; i++)
    {
        start = i;
        for (int j = 0; j < len2; j++)
        {
            if (str_f[i] == sub_f[j])
            {
                if (j == len2 - 1)
                {
                    for (int k = point; k < start; k++)
                        new_str_f += str_f[k];
                    new_str_f += new_sub_f;
                    point = start + len2;
                }
            }
            else
                break;
            i++;
        }
    }
    for (int k = point; k < len1; k++)
        new_str_f += str_f[k];
    return new_str_f;
}

void main()
{
    setlocale(LC_ALL, "Russian");
    string str, new_str, sub, new_sub;
    cout << "Введите строку\n";
    cin >> str;
    cout << "Введите заменяемую в основной строке подстроку\n";
    cin >> sub;
    new_sub = rand_string();
    new_str = swap_sub(str, sub, new_sub);
    cout << "Новая строка\n";
    cout << new_str << endl;
    system("pause");
}
