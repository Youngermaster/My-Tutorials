Algoritmo Punto_3
	Escribir("Digite el lado 1: ")
	Leer lado_1
	Escribir("Digite el lado 2: ")
	Leer lado_2
	Escribir("Digite el lado 3: ")
	Leer lado_3
	
	cuadradoDeDosLados<- (lado_2^2) + (lado_3^2)
	
	SI lado_1 < cuadradoDeDosLados Entonces
		Escribir("El triangulo es acut�ngulo")
	FinSi
	SI lado_1 = cuadradoDeDosLados Entonces
		Escribir("El triangulo es rect�ngulo")
	FinSi
	SI lado_1 > cuadradoDeDosLados Entonces
		Escribir("El triangulo es obtus�ngulo")
	FinSi
	
FinAlgoritmo
