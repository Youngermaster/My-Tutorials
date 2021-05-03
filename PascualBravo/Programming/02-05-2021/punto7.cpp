#include <iostream>

using namespace std;

int main(int argc, char const *argv[])
{
    char primeraVocal, letraActual, respuesta;
    int contadorDeVocales = 0;
    do
    {
        cout << "Digite la letra de la palabra que quiere insertar: ";
        cin >> letraActual;
        cout << "¿Desea añadir más letras? [S/N]: ";
        cin >> respuesta;

        if (contadorDeVocales == 0)
        {
            if (letraActual == 'A' || letraActual == 'a')
            {
                primeraVocal = letraActual;
                contadorDeVocales++;
            }
            else if (letraActual == 'E' || letraActual == 'e')
            {
                primeraVocal = letraActual;
                contadorDeVocales++;
            }
            else if (letraActual == 'I' || letraActual == 'i')
            {
                primeraVocal = letraActual;
                contadorDeVocales++;
            }
            else if (letraActual == 'O' || letraActual == 'o')
            {
                primeraVocal = letraActual;
                contadorDeVocales++;
            }
            else if (letraActual == 'U' || letraActual == 'u')
            {
                primeraVocal = letraActual;
                contadorDeVocales++;
            }
            else
            {
                primeraVocal = 'z';
            }
        }

    } while (respuesta != 'N' && respuesta != 'n');

    if (primeraVocal != 'z')
        cout << "La primera vocal es: " << primeraVocal << endl;
    else
        cout << "No hay vocales" << endl;

    return 0;
}
