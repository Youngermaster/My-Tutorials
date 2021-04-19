Algoritmo Punto_4
	Escribir("Digite el valor de A: ")
	Leer A
	Escribir("Digite el valor de B: ")
	Leer B
	Escribir("Digite el valor de C: ")
	Leer C
	
	Si A = B O A = C O B = C Entonces
		Escribir("Error, todos los valores son iguales")
	SiNo
		Escribir "A ->", A
		Escribir "B ->", B
		Escribir "C ->", C
		
		
		a_auxiliar <- A
		b_auxiliar <- B
		c_auxiliar <- C
		
		B <- a_auxiliar
		C <- b_auxiliar
		A <- c_auxiliar
		Escribir("Convirtiendo...")
		Escribir "A ->", A
		Escribir "B ->", B
		Escribir "C ->", C
		
	FinSi
	
FinAlgoritmo
