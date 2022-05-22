#include <iostream>

class Perro
{
private:
    /* data */
    int edad;
public:
    Perro(/* args */);
    ~Perro();
    int cantidadDePatas;
};

Perro::Perro(/* args */)
{
    std::cout << "Se ha creado un perro" << std::endl;
}

Perro::~Perro()
{
}


int main(int argc, char const *argv[])
{
    std::cout << "Hola " << std::endl;
    return 0;
}
