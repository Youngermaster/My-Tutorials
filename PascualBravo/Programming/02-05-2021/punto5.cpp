#include <iostream>

using namespace std;

int main(int argc, char const *argv[])
{
    int numeroInferior, numeroSuperior;
    cout << "Digite el inicio del rango: ";
    cin >> numeroInferior;
    cout << "Digite el final del rango: ";
    cin >> numeroSuperior;

    float sumaDeNumerosImpares = 0;
    float promedioDeNumerosImpares = 0;
    int cantidadDeNumerosImpares = 0;

    for (int i = numeroInferior; i <= numeroSuperior; i++)
    {
        if (i % 2 != 0)
        {
            sumaDeNumerosImpares += i;
            cantidadDeNumerosImpares++;
        }
    }

    promedioDeNumerosImpares = sumaDeNumerosImpares / cantidadDeNumerosImpares;

    cout << "La suma de los números imapres entre "
         << numeroInferior << " y " << numeroSuperior << " es: " << sumaDeNumerosImpares << endl;

    cout << "El promedio de los números imapres entre "
         << numeroInferior << " y " << numeroSuperior << " es: " << promedioDeNumerosImpares << endl;

    return 0;
}
