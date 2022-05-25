#include <iostream>

#include "utils.h"

int main() {
    bool isRunning = true;
    int optionSelected = 0;

    while (isRunning) {
        printMainMenu();
        cin >> optionSelected;

        if (!cin.good()) {
            cin.clear();
            cin.ignore(numeric_limits<streamsize>::max(), '\n');
            LOG("Por favor selecciona una opción válida.");
            continue;  // asks again
        }

        switch (optionSelected) {
            case 1:
                menuOne();
                break;
            case 2:
                menuTwo();
                break;
            case 3:
                menuThree();
                break;
            case 4:
                factorialOfANumber();
                break;
            case 5:
                isRunning = false;
                break;
            default:
                LOG("Por favor selecciona una opción válida.");
                continue;
        }
    }

    return 0;
}
