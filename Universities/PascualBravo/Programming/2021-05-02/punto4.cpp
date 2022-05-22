#include <iostream>

using namespace std;

int main(int argc, char const *argv[])
{
    float potencia = 1;
    int i = 1;
    do
    {
        potencia *= 4;
        cout << "4 elevado a la " << i << " es: " << potencia << endl;
        i++;
    } while (i <= 20);

    return 0;
}
