#include "utils.h"

int addTwoNumbers(int a, int b) {
    return a + b;
}

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