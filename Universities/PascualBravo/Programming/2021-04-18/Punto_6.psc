Algoritmo Punto_6
	Escribir("Digite el valor de A ")
	Leer A
	Escribir("Digite el valor de B ")
	Leer B
	Escribir("Digite el valor de C ")
	Leer C
	Si A <> 0 Entonces
		solucion_1 <- (-B + RAIZ((B^2) - (4*A*C) )) / (2 * A)
		solucion_2 <- (-B - RAIZ((B^2) - (4*A*C) )) / (2 * A)
		Escribir A, "x^2 + ", B, "x + ", C
		Escribir("La soluci�n 1 es: "), solucion_1
		Escribir("La soluci�n 2 es: "), solucion_2
	SiNo
		Escribir("La ecuaci�n no tiene soluci�n")
	FinSi
FinAlgoritmo
