#pragma once
#include <math.h>

#include <iostream>
#include <limits>
#include <vector>

using namespace std;

#define LOG(x) std::cout << x << std::endl

void imprimirMenuPrincipal();

// Funciones Punto 1
void menuUno();
void imprimirMenUno();
void sumaOperacionDeBinomios();
void restaOperacionDeBinomios();
void operacionesInvertidas();
float invertirNumero(float& a);

// Funciones Punto 2
void menuDos();
void imprimirMenuDos();
bool esPrimo(int& a);
void primosEnRango();
void multiplosEnRango();
void multiplosEnRangoDeSiete();

// Funciones Punto 3
void menuTres();
void imprimirMenuTres();
void pagarImpuestosDelCarro();
void pagarAEmpleado();

// Funciones Punto 4
void factorialDeUnNumero();

int main() {
    bool estaEjecutandose = true;
    int opcionSeleccionada = 0;

    while (estaEjecutandose) {
        imprimirMenuPrincipal();
        cin >> opcionSeleccionada;

        if (!cin.good()) {
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
            LOG("Por favor, selecciona una opción válida.");
            continue;  // asks again
        }

        switch (opcionSeleccionada) {
            case 1:
                menuUno();
                break;
            case 2:
                menuDos();
                break;
            case 3:
                menuTres();
                break;
            case 4:
                factorialDeUnNumero();
                break;
            case 5:
                estaEjecutandose = false;
                break;
            default:
                LOG("Por favor, selecciona una opción válida.");
                continue;
        }
    }

    return 0;
}

void imprimirMenuPrincipal() {
    LOG("|===============================|");
    LOG("|       Proyecto Matemático     |");
    LOG("|===============================|");
    LOG("|                               |");
    LOG("| Selecciona una opción:        |");
    LOG("|                               |");
    LOG("| 1. Ejercicios aritméticos.    |");
    LOG("| 2. Ejercicios de ciclos.      |");
    LOG("| 3. Ejercicios de cálculos.    |");
    LOG("| 4. Calcular factorial de N.   |");
    LOG("| 5. Salir.                     |");
    LOG("|                               |");
    LOG("|===============================|");
}

void menuUno() {
    imprimirMenUno();
    int opcionSeleccionada = 0;

    cin >> opcionSeleccionada;
    if (!cin.good()) {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        LOG("Por favor, selecciona una opción válida.");
        return;
    }

    switch (opcionSeleccionada) {
        case 1:
            sumaOperacionDeBinomios();
            break;
        case 2:
            restaOperacionDeBinomios();
            break;
        case 3:
            operacionesInvertidas();
            break;
        case 4:
            LOG("Volviendo al menú principal...");
            break;
        default:
            LOG("Por favor, selecciona una opción válida.");
            LOG("Volviendo al menú principal...");
            break;
    }
}

void imprimirMenUno() {
    LOG("|=============================================================================|");
    LOG("|                                                                             |");
    LOG("| Selecciona una opción:                                                      |");
    LOG("|                                                                             |");
    LOG("| 1. Determinar el cuadrado y el cubo de la suma de un binomio.               |");
    LOG("| 2. Determinar el cuadrado y el cubo de la diferencia de un binomio.         |");
    LOG("| 3. Sumar, restar, multiplicar y dividir el inverso de tres números enteros. |");
    LOG("| 4. Salir.                                                                   |");
    LOG("|                                                                             |");
    LOG("|=============================================================================|");
}

void sumaOperacionDeBinomios() {
    int a = 0;
    int b = 0;
    LOG("Dame el valor de a:");
    cin >> a;

    LOG("Dame el valor de b:");
    cin >> b;

    if (!cin.good()) {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        LOG("Por favor. selecciona un número válido.");
        return;
    }

    LOG("El cuadrado de la suma de un binomio es:");
    cout << "(" << a << " + " << b << ")^2 = " << pow((a + b), 2) << endl;
    LOG("El cubo de la suma de un binomio es:");
    cout << "(" << a << " + " << b << ")^3 = " << pow((a + b), 3) << endl;
}

void restaOperacionDeBinomios() {
    int a = 0;
    int b = 0;
    LOG("Dame el valor de a:");
    cin >> a;

    LOG("Dame el valor de b:");
    cin >> b;

    if (!cin.good()) {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        LOG("Por favor, selecciona un número válido.");
        return;
    }

    LOG("El cuadrado de la resta de un binomio es:");
    cout << "(" << a << " - " << b << ")^2 = " << pow((a - b), 2) << endl;
    LOG("El cubo de la resta de un binomio es:");
    cout << "(" << a << " - " << b << ")^3 = " << pow((a - b), 3) << endl;
}

void operacionesInvertidas() {
    float a = 0;
    float b = 0;
    float c = 0;
    LOG("Dame el valor de a:");
    cin >> a;

    LOG("Dame el valor de b:");
    cin >> b;

    LOG("Dame el valor de c:");
    cin >> c;

    if (!cin.good()) {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        LOG("Por favor, selecciona un número válido.");
        return;
    }

    float invertidoA = invertirNumero(a);
    float invertidoB = invertirNumero(b);
    float invertidoC = invertirNumero(c);
    cout << "(1/" << a << ") + (1/" << b << ") + (1/" << c << ") = "
         << (invertidoA + invertidoB + invertidoC) << endl;
    cout << "(1/" << a << ") - (1/" << b << ") - (1/" << c << ") = "
         << (invertidoA - invertidoB - invertidoC) << endl;
    cout << "(1/" << a << ") * (1/" << b << ") * (1/" << c << ") = "
         << (invertidoA * invertidoB * invertidoC) << endl;
    cout << "(1/" << a << ") / (1/" << b << ") / (1/" << c << ") = "
         << (invertidoA / invertidoB / invertidoC) << endl;
}

float invertirNumero(float& a) {
    return 1 / (a);
}

void menuDos() {
    imprimirMenuDos();
    int opcionSeleccionada = 0;

    cin >> opcionSeleccionada;
    if (!cin.good()) {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        LOG("Por favor, selecciona una opción válida.");
        return;
    }

    switch (opcionSeleccionada) {
        case 1:
            primosEnRango();
            break;
        case 2:
            multiplosEnRango();
            break;
        case 3:
            multiplosEnRangoDeSiete();
            break;
        case 4:
            LOG("Volviendo al menú principal...");
            break;
        default:
            LOG("Por favor, selecciona una opción válida.");
            LOG("Volviendo al menú principal...");
            break;
    }
}

void imprimirMenuDos() {
    LOG("|======================================================================|");
    LOG("|                                                                      |");
    LOG("| Selecciona una opción:                                               |");
    LOG("|                                                                      |");
    LOG("| 1. Hallar los números primos entre dos números.                      |");
    LOG("| 2. Hallar los múltiplos de un número dado en un rango determinado.   |");
    LOG("| 3. Hallar los múltiplos de 7 para un rango ingresado por el usuario. |");
    LOG("| 4. Salir.                                                            |");
    LOG("|                                                                      |");
    LOG("|======================================================================|");
}

bool esPrimo(int& a) {
    int i, m = 0;
    m = a / 2;
    for (i = 2; i <= m; i++) {
        if (a % i == 0) {
            return false;
        }
    }
    return true;
}

void primosEnRango() {
    int a = 0;
    int b = 0;
    vector<int> numerosPrimos;
    LOG("Dame el valor de inicio:");
    cin >> a;

    LOG("Dame el valor del rango final:");
    cin >> b;

    if (a > b) {
        for (int i = b; i <= a; i++) {
            if (esPrimo(i))
                numerosPrimos.push_back(i);
            else
                continue;
        }

        cout << "Los números primos encontrados en el rango "
             << b << ", " << a << " son: " << endl;
    } else if (a == b) {
        esPrimo(a) ? cout << a << " Es el único número primo" << endl
                   : LOG("No hay números primos en este rango ");
        return;
    } else {
        for (int i = a; i <= b; i++) {
            if (esPrimo(i))
                numerosPrimos.push_back(i);
            else
                continue;
        }

        cout << "Los números primos encontrados en el rango "
             << b << ", " << a << " son: [ " << endl;
    }

    for (auto&& numeroPrimo : numerosPrimos) {
        cout << numeroPrimo << " ";
    }

    cout << "]" << endl;
}

void multiplosEnRango() {
    int a = 0;
    int b = 0;
    int c = 0;
    vector<int> multiplos;
    LOG("Dame el número al que le quieres encontrar el múltiplo:");
    cin >> a;

    LOG("Dame la base del rango donde quieres empezar:");
    cin >> b;

    LOG("Dame el número máximo del rango:");
    cin >> c;

    if (!cin.good()) {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        LOG("Por favor, selecciona una opción válida.");
        return;
    }

    if (b > c) {
        for (int i = c; i <= b; i++) {
            multiplos.push_back(i * a);
        }
        cout << "Los multiplos encontrados en el rango "
             << c << ", " << b << " son: [ " << endl;
    } else if (b == c) {
        multiplos.push_back(a * b);
    } else {
        for (int i = b; i <= c; i++) {
            multiplos.push_back(i * a);
        }
        cout << "Los multiplos encontrados en el rango "
             << b << ", " << c << " son: [ " << endl;
    }

    for (auto&& multiplo : multiplos) {
        cout << multiplo << " ";
    }

    cout << "]";
}

void multiplosEnRangoDeSiete() {
    int b = 0;
    int c = 0;
    vector<int> multiplos;

    LOG("Dame la base del rango donde quieres empezar:");
    cin >> b;

    LOG("Dame el número máximo del rango:");
    cin >> c;

    if (!cin.good()) {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        LOG("Por favor, selecciona una opción válida.");
        return;
    }

    if (b > c) {
        for (int i = c; i <= b; i++) {
            multiplos.push_back(i * 7);
        }
        cout << "Los multiplos encontrados en el rango "
             << c << ", " << b << " de 7 son: [ " << endl;
    } else if (b == c) {
        multiplos.push_back(7 * b);
    } else {
        for (int i = b; i <= c; i++) {
            multiplos.push_back(i * 7);
        }
        cout << "Los multiplos encontrados en el rango "
             << b << ", " << c << " de 7 son: [ " << endl;
    }

    for (auto&& multiplo : multiplos) {
        cout << multiplo << " ";
    }

    cout << "]";
}

void menuTres() {
    imprimirMenuTres();
    int opcionSeleccionada = 0;

    cin >> opcionSeleccionada;
    if (!cin.good()) {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        LOG("Por favor, selecciona una opción válida.");
        return;
    }

    switch (opcionSeleccionada) {
        case 1:
            pagarImpuestosDelCarro();
            break;
        case 2:
            pagarAEmpleado();
            break;
        case 3:
            LOG("Volviendo al menú principal...");
            break;
        default:
            LOG("Por favor, selecciona una opción válida.");
            LOG("Volviendo al menú principal...");
            break;
    }
}

void imprimirMenuTres() {
    LOG("|===================================|");
    LOG("|                                   |");
    LOG("| Selecciona una opción:            |");
    LOG("|                                   |");
    LOG("| 1. Pago del impuesto de un carro. |");
    LOG("| 2. Pago de un trabajador.         |");
    LOG("| 3. Salir.                         |");
    LOG("|                                   |");
    LOG("|===================================|");
}

void pagarImpuestosDelCarro() {
    float precioDelCarro = 0;
    float descuentoPorProntoPago = 0;
    float descuentoTrabajadorOficial = 0;
    float impuestosTotales = 0;
    LOG("Digita el valor del carro, por favor:");
    cin >> precioDelCarro;

    if (!cin.good()) {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        LOG("Por favor, selecciona un número válido.");
    } else if (precioDelCarro < 0) {
        LOG("Perdón, pero el valor del carro no puede ser negativo.");
    } else if (precioDelCarro == 0) {
        LOG("Perdón, pero el valor del carro no puede ser igual a 0.");
    } else {
        impuestosTotales += precioDelCarro * 0.15;
        descuentoPorProntoPago = impuestosTotales * 0.1;
        descuentoTrabajadorOficial = impuestosTotales * 0.05;
        LOG("============================================");
        cout << "El valor del carro es: " << precioDelCarro << " Unidades" << endl;
        LOG("============================================");
        LOG("Impuestos");
        cout << "Debes pagar " << impuestosTotales << " Unidades en impuestos." << endl;
        LOG("============================================");
        LOG("Descuentos");
        cout << "Si pagas a tiempo, debes pagar "
             << (impuestosTotales - descuentoPorProntoPago) << " Unidades en impuestos." << endl;
        cout << "Si eres Trabajador Oficial, debes pagar "
             << (impuestosTotales - descuentoTrabajadorOficial) << " Unidades en impuestos." << endl;
        cout << "Si cumples con ambos requisitos, debes pagar "
             << (impuestosTotales - descuentoPorProntoPago - descuentoTrabajadorOficial)
             << " Unidades en impuestos." << endl;
        LOG("============================================");
    }
}

void pagarAEmpleado() {
    float horasTrabajadas = 0;
    float precioPorHora = 0;
    float porcentajeDeDescuento = 0;
    float horasExtraTrabajadas = 0;
    float pagoTotal = 0;

    LOG("Digita las horas trabajadas, por favor:");
    cin >> horasTrabajadas;

    LOG("Digita el precio por hora trabajada, por favor:");
    cin >> precioPorHora;

    LOG("Digita el porcentaje de impuestos, por favor:");
    cin >> porcentajeDeDescuento;

    if (!cin.good()) {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        LOG("Por favor, selecciona un número válido.");
    } else if (horasTrabajadas < 0) {
        LOG("Perdón, pero el valor de las horas trabajadas no pueden ser negativas.");
    } else if (horasTrabajadas == 0) {
        LOG("Perdón, pero el de valor las horas trabajadas no puede ser igual a 0.");
    } else {
        porcentajeDeDescuento /= 100;
        if (horasTrabajadas <= 40) {
            pagoTotal += horasTrabajadas * precioPorHora;
            pagoTotal = pagoTotal - (pagoTotal * porcentajeDeDescuento);
            cout << "Se le pagará al empleado un total de " << pagoTotal << " Unidades" << endl;
            return;
        } else {
            horasExtraTrabajadas = horasTrabajadas - 40;
            pagoTotal += (horasTrabajadas - horasExtraTrabajadas) * precioPorHora;
            pagoTotal += horasExtraTrabajadas * (precioPorHora * 1.5);
            pagoTotal = pagoTotal - (pagoTotal * porcentajeDeDescuento);
            cout << "Se le pagará al empleado un total de " << pagoTotal << " Unidades" << endl;
            return;
        }
    }
}

void factorialDeUnNumero() {
    int n = -1;
    LOG("Dame un número para encontrar su factorial");
    cin >> n;

    int factorial = 1;
    if (!cin.good()) {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        LOG("Por favor selecciona un número válido.");
    } else if (n < 0) {
        LOG("Perdón, no existe factorial para los números negativos");
    } else if (n == 0) {
        LOG("El factorial de 0 es 1");
    } else {
        for (int i = 1; i < n + 1; i++) {
            factorial *= i;
        }
        std::cout << "El factorial de " << n << " es " << factorial << std::endl;
    }
}
