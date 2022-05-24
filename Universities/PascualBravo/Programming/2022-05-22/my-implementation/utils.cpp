#include "utils.h"

void printMainMenu() {
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

void printMenuOne() {
    LOG("|================================================================================|");
    LOG("|                                                                                |");
    LOG("| Selecciona una opción:                                                         |");
    LOG("|                                                                                |");
    LOG("| 1. Determinar el cuadrado y el cubo de la suma de un binomio.                  |");
    LOG("| 2. Determinar el cuadrado y el cubo de la diferencia de un binomio.            |");
    LOG("| 3. Sumar, restar, multiplicar y dividir el inverso de tres números enteros.    |");
    LOG("| 4. Salir.                                                                      |");
    LOG("|                                                                                |");
    LOG("|================================================================================|");
}

void getSumeBinomeOperations() {
    int a = 0;
    int b = 0;
    LOG("Dame el valor de a");
    cin >> a;

    LOG("Dame el valor de b");
    cin >> b;

    if (!cin.good()) {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        LOG("Por favor selecciona un número válido.");
    }

    LOG("El cuadrado de la suma de un binomio es:");
    LOG(pow((a + b), 2));
    LOG("El cubo de la suma de un binomio es:");
    LOG(pow((a + b), 3));
}

void getMinusBinomeOperations() {
    int a = 0;
    int b = 0;
    LOG("Dame el valor de a");
    cin >> a;

    LOG("Dame el valor de b");
    cin >> b;

    if (!cin.good()) {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        LOG("Por favor selecciona un número válido.");
    }

    LOG("El cuadrado de la resta de un binomio es:");
    LOG(pow((a - b), 2));
    LOG("El cubo de la resta de un binomio es:");
    LOG(pow((a - b), 3));
}

void factorialOfANumber() {
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
