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

void menuOne() {
    printMenuOne();
    int optionSelected = 0;

    cin >> optionSelected;
    if (!cin.good()) {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        LOG("Por favor, selecciona una opción válida.");
        return;
    }

    switch (optionSelected) {
        case 1:
            getSumeBinomeOperations();
            break;
        case 2:
            getMinusBinomeOperations();
            break;
        case 3:
            inverseOperations();
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

void printMenuOne() {
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

void getSumeBinomeOperations() {
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

void getMinusBinomeOperations() {
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

void inverseOperations() {
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

    float invertedA = invertANumber(a);
    float invertedB = invertANumber(b);
    float invertedC = invertANumber(c);
    cout << "(1/" << a << ") + (1/" << b << ") + (1/" << c << ") = "
         << (invertedA + invertedB + invertedC) << endl;
    cout << "(1/" << a << ") - (1/" << b << ") - (1/" << c << ") = "
         << (invertedA - invertedB - invertedC) << endl;
    cout << "(1/" << a << ") * (1/" << b << ") * (1/" << c << ") = "
         << (invertedA * invertedB * invertedC) << endl;
    cout << "(1/" << a << ") / (1/" << b << ") / (1/" << c << ") = "
         << (invertedA / invertedB / invertedC) << endl;
}

float invertANumber(float& a) {
    return 1 / (a);
}

void menuTwo() {
    printMenuTwo();
    int optionSelected = 0;

    cin >> optionSelected;
    if (!cin.good()) {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        LOG("Por favor, selecciona una opción válida.");
        return;
    }

    switch (optionSelected) {
        case 1:
            getPrimesInRange();
            break;
        case 2:
            getMultiplesInRange();
            break;
        case 3:
            getMultiplesInRangeOfSeven();
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

void printMenuTwo() {
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

bool isPrime(int& a) {
    int i, m = 0;
    m = a / 2;
    for (i = 2; i <= m; i++) {
        if (a % i == 0) {
            return false;
        }
    }
    return true;
}

void getPrimesInRange() {
    int a = 0;
    int b = 0;
    vector<int> primeNumbers;
    LOG("Dame el valor de inicio:");
    cin >> a;

    LOG("Dame el valor del rango final:");
    cin >> b;

    if (a > b) {
        for (int i = b; i <= a; i++) {
            if (isPrime(i))
                primeNumbers.push_back(i);
            else
                continue;
        }

        cout << "Los números primos encontrados en el rango "
             << b << ", " << a << " son: " << endl;
    } else if (a == b) {
        isPrime(a) ? cout << a << " Es el único número primo" << endl
                   : LOG("No hay números primos en este rango ");
        return;
    } else {
        for (int i = a; i <= b; i++) {
            if (isPrime(i))
                primeNumbers.push_back(i);
            else
                continue;
        }

        cout << "Los números primos encontrados en el rango "
             << b << ", " << a << " son: [ " << endl;
    }

    for (auto&& primeNumber : primeNumbers) {
        cout << primeNumber << " ";
    }

    cout << "]" << endl;
}

void getMultiplesInRange() {
    int a = 0;
    int b = 0;
    int c = 0;
    vector<int> multiples;
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
            multiples.push_back(i * a);
        }
        cout << "Los multiplos encontrados en el rango "
             << c << ", " << b << " son: [ " << endl;
    } else if (b == c) {
        multiples.push_back(a * b);
    } else {
        for (int i = b; i <= c; i++) {
            multiples.push_back(i * a);
        }
        cout << "Los multiplos encontrados en el rango "
             << b << ", " << c << " son: [ " << endl;
    }

    for (auto&& multiple : multiples) {
        cout << multiple << " ";
    }

    cout << "]";
}

void getMultiplesInRangeOfSeven() {
    int b = 0;
    int c = 0;
    vector<int> multiples;

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
            multiples.push_back(i * 7);
        }
        cout << "Los multiplos encontrados en el rango "
             << c << ", " << b << " de 7 son: [ " << endl;
    } else if (b == c) {
        multiples.push_back(7 * b);
    } else {
        for (int i = b; i <= c; i++) {
            multiples.push_back(i * 7);
        }
        cout << "Los multiplos encontrados en el rango "
             << b << ", " << c << " de 7 son: [ " << endl;
    }

    for (auto&& multiple : multiples) {
        cout << multiple << " ";
    }

    cout << "]";
}

void menuThree() {
    printMenuThree();
    int optionSelected = 0;

    cin >> optionSelected;
    if (!cin.good()) {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        LOG("Por favor, selecciona una opción válida.");
        return;
    }

    switch (optionSelected) {
        case 1:
            payCarTaxes();
            break;
        case 2:
            payToEmployee();
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

void printMenuThree() {
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

void payCarTaxes() {
    float carPrice = 0;
    float earlyPaymentDeduction = 0;
    float officialEmployeeDeduction = 0;
    float totalDeductions = 0;
    float totalTaxes = 0;
    LOG("Digita el valor del carro, por favor:");
    cin >> carPrice;

    if (!cin.good()) {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        LOG("Por favor, selecciona un número válido.");
    } else if (carPrice < 0) {
        LOG("Perdón, pero el valor del carro no puede ser negativo.");
    } else if (carPrice == 0) {
        LOG("Perdón, pero el valor del carro no puede ser igual a 0.");
    } else {
        totalTaxes += carPrice * 0.15;
        earlyPaymentDeduction = totalTaxes * 0.1;
        officialEmployeeDeduction = totalTaxes * 0.05;
        LOG("============================================");
        cout << "El valor del carro es: " << carPrice << " Unidades" << endl;
        LOG("============================================");
        LOG("Impuestos");
        cout << "Debes pagar " << totalTaxes << " Unidades en impuestos." << endl;
        LOG("============================================");
        LOG("Descuentos");
        cout << "Si pagas a tiempo, debes pagar "
             << (totalTaxes - earlyPaymentDeduction) << " Unidades en impuestos." << endl;
        cout << "Si eres Trabajador Oficial, debes pagar "
             << (totalTaxes - officialEmployeeDeduction) << " Unidades en impuestos." << endl;
        cout << "Si cumples con ambos requisitos, debes pagar "
             << (totalTaxes - earlyPaymentDeduction - officialEmployeeDeduction)
             << " Unidades en impuestos." << endl;
        LOG("============================================");
    }
}

void payToEmployee() {
    float workedHours = 0;
    float pricePerHour = 0;
    float deductionPercentage = 0;
    float extraWorkedHours = 0;
    float totalPayment = 0;

    LOG("Digita las horas trabajadas, por favor:");
    cin >> workedHours;

    LOG("Digita el precio por hora trabajada, por favor:");
    cin >> pricePerHour;

    LOG("Digita el porcentaje de impuestos, por favor:");
    cin >> deductionPercentage;

    if (!cin.good()) {
        cin.clear();
        cin.ignore(numeric_limits<streamsize>::max(), '\n');
        LOG("Por favor, selecciona un número válido.");
    } else if (workedHours < 0) {
        LOG("Perdón, pero el valor de las horas trabajadas no pueden ser negativas.");
    } else if (workedHours == 0) {
        LOG("Perdón, pero el de valor las horas trabajadas no puede ser igual a 0.");
    } else {
        deductionPercentage /= 100;
        if (workedHours <= 40) {
            totalPayment += workedHours * pricePerHour;
            totalPayment = totalPayment - (totalPayment * deductionPercentage);
            cout << "Se le pagará al empleado un total de " << totalPayment << " Unidades" << endl;
            return;
        } else {
            extraWorkedHours = workedHours - 40;
            totalPayment += (workedHours - extraWorkedHours) * pricePerHour;
            totalPayment += extraWorkedHours * (pricePerHour * 1.5);
            totalPayment = totalPayment - (totalPayment * deductionPercentage);
            cout << "Se le pagará al empleado un total de " << totalPayment << " Unidades" << endl;
            return;
        }
    }
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
