Algoritmo Punto_2
	Escribir("Digite el lado 1: ")
	Leer lado_1
	Escribir("Digite el lado 2: ")
	Leer lado_2
	Escribir("Digite el ángulo: ")
	Leer angulo
	anguloEnGrados<- angulo * PI / 180
	area<- 1 / 2 * lado_1 * lado_2 * SEN(anguloEnGrados)
	Escribir("El área es: "), area
FinAlgoritmo
