#include <iostream>

using namespace std;

int main(int argc, char const *argv[])
{
    int sumaNumerosPares = 0;
    float sumaNumerosImapares = 0;
    int cantidadDeNumerosImpares = 0;
    int i = 1;

    do
    {
        if (i % 2 == 0)
            sumaNumerosPares += i;
        else
        {
            sumaNumerosImapares += i;
            cantidadDeNumerosImpares++;
        }

        i++;

    } while (i < 1000);

    float promedioNumerosImpares = sumaNumerosImapares / cantidadDeNumerosImpares;

    cout << "La suma de los primeros 1000 números pares es: " << sumaNumerosPares << endl;
    cout << "El promedio de los primeros 1000 números impares es: " << promedioNumerosImpares
         << endl;

    return 0;
}
