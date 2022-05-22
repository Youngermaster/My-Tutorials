Algoritmo Promedio_2_Numeros
	// Juan quiere saber el promedio de sus 2 notas
	// Haga un programa que dadas 2 notas calcule
	// el promedio, y dependiendo de que si es mayor de 10
	// Imprima que pasó la materia.
	
	Escribir "Digite la nota 1: "
	Leer nota_1 // 4
	Escribir "Digite la nota 2: "
	Leer nota_2 // 5
	
	sumaDeNotas <- nota_1 + nota_2 // 9
	resultadoDeNotas <- sumaDeNotas / 2 // 4.5
	
	Si resultadoDeNotas > 10
		Escribir "Pasó la materia"
	SiNo
		Escribir "No pasó la materia"
	FinSi

FinAlgoritmo
