Algoritmo Punto_6
	Escribir("Digite la variable A: ")
	Leer A
	Escribir("Digite la variable B: ")
	Leer B
	Escribir("Digite la variable C: ")
	Leer C
	
	SI A = B o A = C Entonces
		Escribir("[ERROR] Hay valores iguales")
	SiNo
		SI A > B y A > C Entonces
			Escribir("La variable mayor es A")
			SI B < A y B < C Entonces
				Escribir("La variable menor es B")
			SiNo
				Escribir("La variable menor es C")
			FinSi
		FinSi
		
		SI B > A y B > C Entonces
			Escribir("La variable mayor es B")
			SI A < B y A < C Entonces
				Escribir("La variable menor es A")
			SiNo
				Escribir("La variable menor es C")
			FinSi
		FinSi
		
		SI C > A y C > B Entonces
			Escribir("La variable mayor es C")
			SI A < B y A < C Entonces
				Escribir("La variable menor es A")
			SiNo
				Escribir("La variable menor es B")
			FinSi
		FinSi
	FinSi
	
FinAlgoritmo
