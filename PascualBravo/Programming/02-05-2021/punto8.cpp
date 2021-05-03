#include <iostream>

using namespace std;

int main(int argc, char const *argv[])
{
    int i = 1;
    int j = 1;

    while (i <= 10)
    {
        while (j <= 10)
        {
            cout << i << " x " << j << " = " << i * j << endl;
            j++;
        }
        i++;
        j = 1;
        cout << endl;
    }

    return 0;
}
