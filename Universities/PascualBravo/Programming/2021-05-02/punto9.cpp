#include <iostream>

using namespace std;

int main(int argc, char const *argv[])
{
    int dividendo, divisor, cociente = 0, resto;
    cout << "Digite el dividendo: ";
    cin >> dividendo;
    cout << "Digite el divisor: ";
    cin >> divisor;

    int x = dividendo;
    int y = divisor;

    if (dividendo > divisor)
    {
        do
        {
            dividendo -= divisor;
            cociente++;
            resto = dividendo;
        } while (dividendo >= divisor);
        
    } else if (dividendo == divisor) {
        cociente = 1;
        resto = 0;
    } else {
        cociente = 0;
        resto = dividendo;
    }
    
    cout << x << " / " << y << " = " << cociente << endl;
    cout << "Y su residuo es: " << resto << endl;
    
    return 0;
}
