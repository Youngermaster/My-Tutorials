Algoritmo Punto_1
	Escribir("Digite la hora de entrada, por favor: ")
	Leer hora_de_entrada
	Escribir("Digite la hora de salida, por favor: ")
	Leer hora_de_salida
	
	Si hora_de_entrada = hora_de_salida Entonces
		valor_a_pagar <- 3500
	SiNo
		valor_a_pagar <- (5000 * (hora_de_salida - hora_de_entrada - 1)) + 3500
	FinSi
	
	Escribir("El valor a pagar es: "), valor_a_pagar
FinAlgoritmo
