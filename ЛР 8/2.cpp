#include <iostream>

using namespace std;

char trans(char ch)
{
    int num;
    num = (int)ch - 32;
    ch = (char)num;
    cout << "Буква - ";
    return ch;
}

void main()
{
    setlocale(LC_ALL, "Russian");
    char sym;
    while (1)
    {
        cout << "Введите символ или 0 для выхода\n";
        cin >> sym;
        if (sym == '0')
            break;
        cout << trans(sym) << endl;
    }
    system("pause");
}