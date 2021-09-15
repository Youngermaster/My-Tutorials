#include <iostream>

using namespace std;

int main(int argc, char const *argv[])
{
    for (int i = 0; i < 5; i++)
    {
        float angulo;
        cout << "Digite el ángulo " << i + 1 << " por favor: ";
        cin >> angulo;

        if (angulo < 90)
            cout << "El ángulo " << angulo << " es agudo." << endl;
        else if (angulo == 90)
            cout << "El ángulo " << angulo << " es recto." << endl;
        else if (angulo > 90)
            cout << "El ángulo " << angulo << " es obtuso." << endl;
    }

    return 0;
}
