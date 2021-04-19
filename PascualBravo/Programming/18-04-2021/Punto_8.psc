Algoritmo Punto_8
	Escribir("Digite un número de 4 digitos, por favor")
	Leer numero_de_4_digitos
	
	Si Longitud(numero_de_4_digitos) <> 4 Entonces
		Escribir("Error, el numero "), numero_de_4_digitos, " no es de 4 digitos, tiene ", Longitud(numero_de_4_digitos), " digitos"
		
	SiNo
		Escribir Subcadena(numero_de_4_digitos, 1, 1)
		Escribir Subcadena(numero_de_4_digitos, 2, 2)
		Escribir Subcadena(numero_de_4_digitos, 3, 3)
		Escribir Subcadena(numero_de_4_digitos, 4, 4)
	FinSi
	
FinAlgoritmo
