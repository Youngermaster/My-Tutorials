// * Usamos la librería math.h para elevar al cuadrado y/o al cubo.
#include <math.h>
// * Usamos la librería iostream para imprimir u obtener valores en la terminal.
#include <iostream>
// * Usamos la librería para crear un "arreglo" dinámico y guardar información.
#include <vector>

// * Usamos esta línea para no repetir el "keyword" std constantemente.
using namespace std;

// * Con #define podemos identificar una variable o "función" para no repetir código.
#define PRINT(x) std::cout << x << std::endl

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
    // * Esta variable nos permite saber si se está ejecutando o no el programa.
    bool estaEjecutandose = true;
    // * Con esta variable revisamos qué opción estamos seleccionando en el menú.
    int opcionSeleccionada = 0;

    // * Realizamos este ciclo para poderlo ejecutarlo infinitamente hasta que decidamos terminarlo.
    while (estaEjecutandose) {
        imprimirMenuPrincipal();
        cin >> opcionSeleccionada;

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
                PRINT("Por favor, selecciona una opción válida.");
                continue;
        }
    }

    return 0;
}

void imprimirMenuPrincipal() {
    PRINT("|===============================|");
    PRINT("|       Proyecto Matemático     |");
    PRINT("|===============================|");
    PRINT("|                               |");
    PRINT("| Selecciona una opción:        |");
    PRINT("|                               |");
    PRINT("| 1. Ejercicios aritméticos.    |");
    PRINT("| 2. Ejercicios de ciclos.      |");
    PRINT("| 3. Ejercicios de cálculos.    |");
    PRINT("| 4. Calcular factorial de N.   |");
    PRINT("| 5. Salir.                     |");
    PRINT("|                               |");
    PRINT("|===============================|");
}

void menuUno() {
    imprimirMenUno();
    int opcionSeleccionada = 0;

    cin >> opcionSeleccionada;

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
            PRINT("Volviendo al menú principal...");
            break;
        default:
            PRINT("Por favor, selecciona una opción válida.");
            PRINT("Volviendo al menú principal...");
            break;
    }
}

void imprimirMenUno() {
    PRINT("|=============================================================================|");
    PRINT("|                                                                             |");
    PRINT("| Selecciona una opción:                                                      |");
    PRINT("|                                                                             |");
    PRINT("| 1. Determinar el cuadrado y el cubo de la suma de un binomio.               |");
    PRINT("| 2. Determinar el cuadrado y el cubo de la diferencia de un binomio.         |");
    PRINT("| 3. Sumar, restar, multiplicar y dividir el inverso de tres números enteros. |");
    PRINT("| 4. Salir.                                                                   |");
    PRINT("|                                                                             |");
    PRINT("|=============================================================================|");
}

void sumaOperacionDeBinomios() {
    int a = 0;
    int b = 0;
    PRINT("Dame el valor de a:");
    cin >> a;

    PRINT("Dame el valor de b:");
    cin >> b;

    // * Lo que realizamos con la función "pow(valor, exponente)" es elevar
    // * a la potencia que queramos un número.
    PRINT("El cuadrado de la suma de un binomio es:");
    cout << "(" << a << " + " << b << ")^2 = " << pow((a + b), 2) << endl;
    PRINT("El cubo de la suma de un binomio es:");
    cout << "(" << a << " + " << b << ")^3 = " << pow((a + b), 3) << endl;
}

void restaOperacionDeBinomios() {
    int a = 0;
    int b = 0;
    PRINT("Dame el valor de a:");
    cin >> a;

    PRINT("Dame el valor de b:");
    cin >> b;

    // * Lo que realizamos con la función "pow(valor, exponente)" es elevar
    // * a la potencia que queramos un número.
    PRINT("El cuadrado de la resta de un binomio es:");
    cout << "(" << a << " - " << b << ")^2 = " << pow((a - b), 2) << endl;
    PRINT("El cubo de la resta de un binomio es:");
    cout << "(" << a << " - " << b << ")^3 = " << pow((a - b), 3) << endl;
}

void operacionesInvertidas() {
    float a = 0;
    float b = 0;
    float c = 0;
    PRINT("Dame el valor de a:");
    cin >> a;

    PRINT("Dame el valor de b:");
    cin >> b;

    PRINT("Dame el valor de c:");
    cin >> c;

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

// * Esta función nos permite devolver el valor inverso de un número, en el tipo float.
// * En esta función usamos el símbolo "&" para decirle a C++ que estamos pasando
// * por referencia un valor, esto quiere decir que no estamos creando copias en
// * en la memoria, sino que estamos usando el valor real. Esto hace que sea más
// * "eficiente".
float invertirNumero(float& a) {
    return 1 / (a);
}

void menuDos() {
    imprimirMenuDos();
    int opcionSeleccionada = 0;

    cin >> opcionSeleccionada;

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
            PRINT("Volviendo al menú principal...");
            break;
        default:
            PRINT("Por favor, selecciona una opción válida.");
            PRINT("Volviendo al menú principal...");
            break;
    }
}

void imprimirMenuDos() {
    PRINT("|======================================================================|");
    PRINT("|                                                                      |");
    PRINT("| Selecciona una opción:                                               |");
    PRINT("|                                                                      |");
    PRINT("| 1. Hallar los números primos entre dos números.                      |");
    PRINT("| 2. Hallar los múltiplos de un número dado en un rango determinado.   |");
    PRINT("| 3. Hallar los múltiplos de 7 para un rango ingresado por el usuario. |");
    PRINT("| 4. Salir.                                                            |");
    PRINT("|                                                                      |");
    PRINT("|======================================================================|");
}

// * Esta función lo que hace es revisar si la variable 'a' tiene algún multiplo.
// * Si tiene algún múltiplo, retornamos 'false', es decir que no es primo.
// * Si no tiene algún múltiplo, retornamos 'true', es decir que es primo.
// * En esta función usamos el símbolo "&" para decirle a C++ que estamos pasando
// * por referencia la variable.
bool esPrimo(int& a) {
    int m = a / 2;
    for (int i = 2; i <= m; i++) {
        if (a % i == 0) {
            return false;
        }
    }
    return true;
}

void primosEnRango() {
    int a = 0;
    int b = 0;
    // * En este vector es donde guardaremos los números primos que encontremos.
    vector<int> numerosPrimos;
    PRINT("Dame el valor de inicio:");
    cin >> a;

    PRINT("Dame el valor del rango final:");
    cin >> b;

    // * Este condicional lo hacemos para evitar problemas en caso de que le usuario
    // * ingrese al revés los valores de inicio y final.
    if (a > b) {
        // * Lo que hacemos acá es recorrer cada número en el rango y verificar
        // * si es primo, y si es primo, entonces lo añadimos a nuestro
        // * "arreglo" de números primos.
        for (int i = b; i <= a; i++) {
            if (esPrimo(i))
                numerosPrimos.push_back(i);
            else
                continue;
        }

        cout << "Los números primos encontrados en el rango "
             << b << ", " << a << " son: " << endl;
    } else if (a == b) {
        // * Si sólo el rango inicial y final son iguales, eso significa que
        // * solo tenemos un número, por lo que sólo tenemos que revisar ese número y ya.
        if (esPrimo(a))
            cout << a << " Es el único número primo" << endl;
        else
            PRINT("No hay números primos en este rango ");

        return;
    } else {
        // * Lo que hacemos acá es recorrer cada número en el rango y verificar
        // * si es primo, y si es primo, entonces lo añadimos a nuestro
        // * "arreglo" de números primos.
        for (int i = a; i <= b; i++) {
            if (esPrimo(i))
                numerosPrimos.push_back(i);
            else
                continue;
        }

        cout << "Los números primos encontrados en el rango "
             << b << ", " << a << " son: " << endl;
    }
    cout << "[ ";

    for (auto&& numeroPrimo : numerosPrimos) {
        cout << numeroPrimo << " ";
    }

    cout << "]" << endl;
}

void multiplosEnRango() {
    int a = 0;
    int b = 0;
    int c = 0;

    // * En este vector es donde guardaremos los múltiplos que encontremos.
    vector<int> multiplos;
    PRINT("Dame el número al que le quieres encontrar el múltiplo:");
    cin >> a;

    PRINT("Dame la base del rango donde quieres empezar:");
    cin >> b;

    PRINT("Dame el número máximo del rango:");
    cin >> c;

    if (b > c) {
        // * Lo que hacemos acá es recorrer cada número en el rango y multiplicarlo
        // * por el número que nos dio el usuario, y luego lo añadimos a nuestro
        // * "arreglo" de múltiplos.
        for (int i = c; i <= b; i++) {
            multiplos.push_back(i * a);
        }
        cout << "Los multiplos encontrados en el rango "
             << c << ", " << b << " son: " << endl;
    } else if (b == c) {
        multiplos.push_back(a * b);
    } else {
        // * Lo que hacemos acá es recorrer cada número en el rango y multiplicarlo
        // * por el número que nos dio el usuario, y luego lo añadimos a nuestro
        // * "arreglo" de múltiplos.
        for (int i = b; i <= c; i++) {
            multiplos.push_back(i * a);
        }
        cout << "Los multiplos encontrados en el rango "
             << b << ", " << c << " son: " << endl;
    }

    cout << "[ ";
    // * Este es un for-range, lo que nos permite hacer es
    // * iterar sobre nuestro vector de una manera más elegante.
    // * el "keyword" 'auto&&' lo usamos para que automáticamente
    // * asigne el tipo a la variable del for-range.
    for (auto&& multiplo : multiplos) {
        cout << multiplo << " ";
    }

    cout << "]" << endl;
}

void multiplosEnRangoDeSiete() {
    int b = 0;
    int c = 0;
    vector<int> multiplos;

    PRINT("Dame la base del rango donde quieres empezar:");
    cin >> b;

    PRINT("Dame el número máximo del rango:");
    cin >> c;

    if (b > c) {
        // * Lo que hacemos acá es recorrer cada número en el rango y multiplicarlo
        // * por el número siete, y luego lo añadimos a nuestro
        // * "arreglo" de múltiplos.
        for (int i = c; i <= b; i++) {
            multiplos.push_back(i * 7);
        }
        cout << "Los multiplos encontrados en el rango "
             << c << ", " << b << " de 7 son: " << endl;
    } else if (b == c) {
        multiplos.push_back(7 * b);
    } else {
        // * Lo que hacemos acá es recorrer cada número en el rango y multiplicarlo
        // * por el número siete, y luego lo añadimos a nuestro
        // * "arreglo" de múltiplos.
        for (int i = b; i <= c; i++) {
            multiplos.push_back(i * 7);
        }
        cout << "Los multiplos encontrados en el rango "
             << b << ", " << c << " de 7 son: " << endl;
    }

    cout << "[ ";
    // * Este es un for-range, lo que nos permite hacer es
    // * iterar sobre nuestro vector de una manera más elegante.
    // * el "keyword" 'auto&&' lo usamos para que automáticamente
    // * asigne el tipo a la variable del for-range.
    for (auto&& multiplo : multiplos) {
        cout << multiplo << " ";
    }

    cout << "]" << endl;
}

void menuTres() {
    imprimirMenuTres();
    int opcionSeleccionada = 0;

    cin >> opcionSeleccionada;

    switch (opcionSeleccionada) {
        case 1:
            pagarImpuestosDelCarro();
            break;
        case 2:
            pagarAEmpleado();
            break;
        case 3:
            PRINT("Volviendo al menú principal...");
            break;
        default:
            PRINT("Por favor, selecciona una opción válida.");
            PRINT("Volviendo al menú principal...");
            break;
    }
}

void imprimirMenuTres() {
    PRINT("|===================================|");
    PRINT("|                                   |");
    PRINT("| Selecciona una opción:            |");
    PRINT("|                                   |");
    PRINT("| 1. Pago del impuesto de un carro. |");
    PRINT("| 2. Pago de un trabajador.         |");
    PRINT("| 3. Salir.                         |");
    PRINT("|                                   |");
    PRINT("|===================================|");
}

void pagarImpuestosDelCarro() {
    float precioDelCarro = 0;
    float descuentoPorProntoPago = 0;
    float descuentoTrabajadorOficial = 0;
    float impuestosTotales = 0;
    PRINT("Digita el valor del carro, por favor:");
    cin >> precioDelCarro;

    if (precioDelCarro < 0) {
        PRINT("Perdón, pero el valor del carro no puede ser negativo.");
    } else if (precioDelCarro == 0) {
        PRINT("Perdón, pero el valor del carro no puede ser igual a 0.");
    } else {
        impuestosTotales += precioDelCarro * 0.15;             // * Este es el 15%
        descuentoPorProntoPago = impuestosTotales * 0.1;       // * Este es el 10%
        descuentoTrabajadorOficial = impuestosTotales * 0.05;  // * Este es el 5%
        PRINT("============================================");
        cout << "El valor del carro es: " << precioDelCarro << " Unidades" << endl;
        PRINT("============================================");
        PRINT("Impuestos");
        cout << "Debes pagar " << impuestosTotales << " Unidades en impuestos." << endl;
        PRINT("============================================");
        PRINT("Descuentos");
        cout << "Si pagas a tiempo, debes pagar "
             << (impuestosTotales - descuentoPorProntoPago) << " Unidades en impuestos." << endl;
        cout << "Si eres Trabajador Oficial, debes pagar "
             << (impuestosTotales - descuentoTrabajadorOficial) << " Unidades en impuestos." << endl;
        cout << "Si cumples con ambos requisitos, debes pagar "
             << (impuestosTotales - descuentoPorProntoPago - descuentoTrabajadorOficial)
             << " Unidades en impuestos." << endl;
        PRINT("============================================");
    }
}

void pagarAEmpleado() {
    float horasTrabajadas = 0;
    float precioPorHora = 0;
    float porcentajeDeDescuento = 0;
    float horasExtraTrabajadas = 0;
    float pagoTotal = 0;

    PRINT("Digita las horas trabajadas, por favor:");
    cin >> horasTrabajadas;

    PRINT("Digita el precio por hora trabajada, por favor:");
    cin >> precioPorHora;

    PRINT("Digita el porcentaje de impuestos, por favor:");
    cin >> porcentajeDeDescuento;

    if (horasTrabajadas < 0) {
        PRINT("Perdón, pero el valor de las horas trabajadas no pueden ser negativas.");
    } else if (horasTrabajadas == 0) {
        PRINT("Perdón, pero el de valor las horas trabajadas no puede ser igual a 0.");
    } else {
        // * 'porcentajeDeDescuento' lo dividimos por 100% para que cuando multipliquemos
        // * con otras variables nos de directamente el valor del porcentaje de esas
        // * variables, esto por la "Regla de 3".
        porcentajeDeDescuento /= 100;
        // * Aquí verificamos si el empleado trabajó más de 40 horas.
        // * En este caso no, por lo que hacemos un procedimiento normal.
        if (horasTrabajadas <= 40) {
            pagoTotal += horasTrabajadas * precioPorHora;
            pagoTotal = pagoTotal - (pagoTotal * porcentajeDeDescuento);
            cout << "Se le pagará al empleado un total de " << pagoTotal << " Unidades" << endl;
            return;
        } else {
            // * Aquí verificamos si el empleado trabajó más de 40 horas.
            // * En este caso sí, por lo que hacemos un procedimiento adicional.

            // * Aquí obtenemos las horas adicionales trabajadas.
            horasExtraTrabajadas = horasTrabajadas - 40;
            // * Luego le restamos esas horas extra y multiplicamos por la hora convecional.
            pagoTotal += (horasTrabajadas - horasExtraTrabajadas) * precioPorHora;
            // * Después el excedente lo multiplicamos por 1.5 veces más.
            pagoTotal += horasExtraTrabajadas * (precioPorHora * 1.5);
            pagoTotal = pagoTotal - (pagoTotal * porcentajeDeDescuento);
            cout << "Se le pagará al empleado un total de " << pagoTotal << " Unidades" << endl;
            return;
        }
    }
}

void factorialDeUnNumero() {
    int n = -1;
    PRINT("Dame un número para encontrar su factorial");
    cin >> n;

    int factorial = 1;
    if (n < 0) {
        PRINT("Perdón, no existe factorial para los números negativos");
    } else if (n == 0) {
        PRINT("El factorial de 0 es 1");
    } else {
        for (int i = 1; i < n + 1; i++) {
            factorial *= i;
        }
        std::cout << "El factorial de " << n << " es " << factorial << std::endl;
    }
}
