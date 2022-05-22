#include <iostream>

using namespace std;

#include "utils.h"

int main(int argc, char const *argv[]) {
    bool isRunning = true;
    int optionSelected = 0;
    if (!isdigit(2)) {
        LOG("Is digit");
    }

    LOG(addTwoNumbers(2, 3));
    while (isRunning) {
        printMainMenu();
        cin >> optionSelected;

        switch (optionSelected) {
            case 1:
                LOG("Number 1");
                break;
            case 2:
                LOG("Number 1");
                break;
            case 3:
                LOG("Number 1");
                break;
            case 4:
                LOG("Number 1");
                break;
            case 5:
                isRunning = false;
                break;
            default:
                LOG("Por favor selecciona la opción correcta");
                break;
        }
    }

    return 0;
}
