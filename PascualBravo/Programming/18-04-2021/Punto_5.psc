Algoritmo Punto_5
	Escribir("Digite la duración de la llamada en minutos, por favor")
	Leer duracion_de_llamada
	
	Si duracion_de_llamada < 3 Entonces
		valor_a_pagar <- 100
		
	SiNo
		valor_a_pagar <- ( 120 * (duracion_de_llamada -3)) + 100
	FinSi
	Escribir("El valor a pagar es: "), valor_a_pagar
FinAlgoritmo
