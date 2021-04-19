Algoritmo Punto_3
	Escribir("Digite el valor de 1 entrada, por favor: ")
	Leer valor_1_entrada
	Escribir("Digite la cantidad de entradas que desea comprar, máximo 4.")
	Leer cantidad_de_entradas
	
	Si cantidad_de_entradas > 4 O cantidad_de_entradas < 1 Entonces
		Escribir("Lo sentimos, solo se pueden comprar máximo 4 entradas")
	FinSi
	Si cantidad_de_entradas = 1 Entonces
		Escribir("El valor a pagar es: "), valor_1_entrada
	FinSi
	Si cantidad_de_entradas = 2 Entonces
		valor_a_pagar <- ((valor_1_entrada * 2) * 0.9)
		Escribir("El valor a pagar es: "), valor_a_pagar
	FinSi
	Si cantidad_de_entradas = 3 Entonces
		valor_a_pagar <- ((valor_1_entrada * 3) * 0.85)
		Escribir("El valor a pagar es: "), valor_a_pagar
	FinSi
	Si cantidad_de_entradas = 4 Entonces
		valor_a_pagar <- ((valor_1_entrada * 2) * 0.8)
		Escribir("El valor a pagar es: "), valor_a_pagar
	FinSi
FinAlgoritmo
