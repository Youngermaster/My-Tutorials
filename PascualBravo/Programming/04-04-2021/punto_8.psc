Algoritmo Punto_8
	Escribir("Digite la variable A: ")
	Leer A
	Escribir("Digite la variable B: ")
	Leer B
	Escribir("Digite la variable C: ")
	Leer C

	Escribir("Digitaste las variables de la siguiente forma: "), A, ", ", B, ", ", C

	SI A = B o A = C O B = C Entonces
		Escribir("[ERROR] Hay valores iguales")
	SiNo
		SI A > B y A > C Entonces
			SI B < C Entonces
				Escribir("Las variables ordenadas son de la siguiente forma: "), A, ", ", C, ", ", B
			SiNo
				Escribir("Las variables ordenadas son de la siguiente forma: "), A, ", ", B, ", ", C
			FinSi
		FinSi
		
		SI B > A y B > C Entonces
			SI A < C Entonces
				Escribir("Las variables ordenadas son de la siguiente forma: "), B, ", ", C, ", ", A
			SiNo
				Escribir("Las variables ordenadas son de la siguiente forma: "), B, ", ", A, ", ", C
			FinSi
		FinSi
	
		SI C > A y C > B Entonces
			SI A < B Entonces
				Escribir("Las variables ordenadas son de la siguiente forma: "), C, ", ", B, ", ", A
			SiNo
				Escribir("Las variables ordenadas son de la siguiente forma: "), C, ", ", A, ", ", B
			FinSi
		FinSi
	FinSi

FinAlgoritmo
