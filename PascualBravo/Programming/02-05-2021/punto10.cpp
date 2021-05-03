#include <iostream>

using namespace std;

int main(int argc, char const *argv[])
{
    char respuesta;

    do
    {
        cout << "¿Desea continuar? [S/N]: ";
        cin >> respuesta;
    } while (respuesta != 'N' && respuesta != 'n');

    return 0;
}
