Algoritmo Punto_3
	Escribir("Digite el lado 1: ")
	Leer lado_1
	Escribir("Digite el lado 2: ")
	Leer lado_2
	Escribir("Digite el lado 3: ")
	Leer lado_3
	
	SI lado_1 > lado_2 y lado_1 > lado_3 Entonces
		lado_mayor<- lado_1^2
		cuadradoDeDosLados<- (lado_2^2) + (lado_3^2)
	FinSi
	SI lado_2 > lado_1 y lado_2 > lado_3 Entonces
		lado_mayor<- lado_2^2
		cuadradoDeDosLados<- (lado_1^2) + (lado_3^2)
	FinSi
	SI lado_3 > lado_1 y lado_3 > lado_2 Entonces
		lado_mayor<- lado_3^2
		cuadradoDeDosLados<- (lado_1^2) + (lado_2^2)
	FinSi
	
	SI lado_mayor < cuadradoDeDosLados Entonces
		Escribir("El triangulo es acutángulo")
	FinSi
	SI lado_mayor = cuadradoDeDosLados Entonces
		Escribir("El triangulo es rectángulo")
	FinSi
	SI lado_mayor > cuadradoDeDosLados Entonces
		Escribir("El triangulo es obtusángulo")
	FinSi
	
FinAlgoritmo