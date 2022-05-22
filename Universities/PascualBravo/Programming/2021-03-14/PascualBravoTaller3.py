def punto_1():
    numeros = []
    existe_cero = False
    existe_negativo = False
    
    for i in range(5):
        numero = int(input("Escriba un Número: "))
        numeros.append(numero)
        if numero == 0:
            existe_cero = True
        elif numero < 0:
            existe_negativo = True
    
    print("El número mayor es:", max(numeros))
    print("El número menor es:", min(numeros))
    if existe_cero:
        print("Existe un cero")
    if existe_negativo:
        print("Existe un número negativo")

def punto_4():
    a = int(input("Dígite el primer número: "))
    b = int(input("Dígite el segundo número: "))

    print("La suma es: ", a + b)
    print("La resta es: ", a - b)
    print("La multiplicación es: ", a * b)
    print("La división es: ", a / b)

# punto_1()
punto_4()
