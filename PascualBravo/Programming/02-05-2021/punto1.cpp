#include <iostream>

using namespace std;

int main(int argc, char const *argv[])
{
    // Promedio usando Do-While
    int i = 1;
    float sumatoria = 0;
    float promedio = 0;
    do
    {
        sumatoria += i;
        i++;

    } while (i <= 100);

    promedio = sumatoria / 100;

    cout << "Punto A:" << endl;
    cout << "El promedio de la suma de los primeros 100 números es: " << promedio << endl;

    // Promedio usando el For
    sumatoria = 0;

    for (int i = 1; i <= 100; i++)
        sumatoria += i;

    promedio = sumatoria / 100;

    cout << "Punto B:" << endl;
    cout << "El promedio de la suma de los primeros 100 números es: " << promedio << endl;

    return 0;
}
