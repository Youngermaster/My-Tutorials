#include <math.h>
#include <iostream>

#define LOG(x) std::cout << x << std::endl;

int main() {
    int n = 1;
    double sumatoria = 0;

    LOG("Digita el valor de n:");
    std::cin >> n;

    for (int i = 0; i <= n; i++) {
        if (i % 2 == 0 || i == 0) {
            continue;
        } else {
            sumatoria += (std::pow(2, i)) / i;
        }
    }

    LOG("La sumatoria es igual a: ");
    LOG(sumatoria);

    return 0;
}
