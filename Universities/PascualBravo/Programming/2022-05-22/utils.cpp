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