Algoritmo Punto_7
	Escribir("Digite el primer número: ")
	Leer numero_1
	Escribir("Digite el segundo número: ")
	Leer numero_2
	
	Si numero_1 = numero_2 Entonces
		Escribir("Ambos números son multiplos")
	FinSi
	
	Si numero_1 > numero_2 Entonces
		Si numero_1 % numero_2 = 0 Entonces
			Escribir numero_1, " es multiplo de ", numero_2
		SiNo
			Escribir numero_1, " NO es multiplo de ", numero_2
		FinSi
	FinSi
	
	Si numero_1 < numero_2 Entonces
		Si numero_2 % numero_1 = 0 Entonces
			Escribir numero_2, " es multiplo de ", numero_1
		SiNo
			Escribir numero_2, " NO es multiplo de ", numero_1
		FinSi
	FinSi
	
FinAlgoritmo
