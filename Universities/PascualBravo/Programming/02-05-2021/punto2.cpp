#include <iostream>
#include <climits>

using namespace std;

int main(int argc, char const *argv[])
{
    int cantidadDeSalariosAltos = 0;
    int cantidadDeSalariosMedios = 0;
    int cantidadDeSalariosBajos = 0;
    int salarioMenor = INT_MAX;
    int salarioMayor = 0;

    for (int i = 0; i < 10; i++)
    {
        int salarioActual;
        cout << "Digite el salario del empleado " << i + 1 << ": " << endl;
        cin >> salarioActual;

        if (salarioActual > 1200000)
            cantidadDeSalariosAltos++;
        else if (salarioActual >= 800000 && salarioActual <= 1200000)
            cantidadDeSalariosMedios++;
        else
            cantidadDeSalariosBajos++;

        if (salarioActual > salarioMayor)
            salarioMayor = salarioActual;

        if (salarioActual < salarioMenor)
            salarioMenor = salarioActual;
    }

    cout << "Hay " << cantidadDeSalariosAltos << " empleado/s con salarios altos" << endl;
    cout << "Hay " << cantidadDeSalariosMedios << " empleado/s con salarios medios" << endl;
    cout << "Hay " << cantidadDeSalariosBajos << " empleado/s con salarios bajos" << endl;

    cout << "El salario mayor es: " << salarioMayor << endl;
    cout << "El salario menor es: " << salarioMenor << endl;

    return 0;
}
