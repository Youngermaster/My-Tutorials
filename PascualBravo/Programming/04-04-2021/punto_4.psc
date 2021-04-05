Algoritmo Punto_4
	Escribir("Digite el lado 1: ")
	Leer lado_1
	Escribir("Digite el lado 2: ")
	Leer lado_2
	Escribir("Digite el lado 3: ")
	Leer lado_3
	
	anguloA<- ACOS(-1 * ((lado_1^2 - lado_2^2 - lado_3^2)/(2 * lado_2 * lado_3)))
	anguloAGrados<- anguloA * 180 / PI
	
	anguloB<- (lado_2 * SEN(anguloA) / lado_1)
	anguloBGrados<- anguloB * 180 / PI
	
	
	anguloC<- (lado_3 * SEN(anguloA) / lado_1)
	anguloCGrados<- anguloC * 180 / PI
	
	Escribir("El ángulo A es: "), anguloAGrados
	Escribir("El ángulo B es: "), anguloBGrados
	Escribir("El ángulo C es: "), anguloCGrados
FinAlgoritmo
