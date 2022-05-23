#include <iostream>

#include "utils.h"

int main(int argc, char const *argv[]) {
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
                LOG("Number 1");
                break;
            case 2:
                LOG("Number 2");
                break;
            case 3:
                LOG("Number 3");
                break;
            case 4:
                LOG("Number 4");
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
