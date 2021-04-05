Algoritmo Punto_1
	Escribir("Digite el radio del circulo")
	Leer radioCirculo
	Escribir("Digite la altura del triangulo")
	Leer alturaTriangulo
	Escribir("Digite la base del triangulo")
	Leer baseTriangulo
	Escribir("Digite al área de la base de la piramide")
	Leer areaBasePiramide
	Escribir("Digite la longitud del lado del cuadrado")
	Leer ladoCuadrado
	
	Escribir("Los resultados son los siguientes: ")
	areaCirculo<- PI * radioCirculo^2
	volumenEsfera<- 4/3 * PI * radioCirculo^3
	areaTriangulo<- baseTriangulo * alturaTriangulo / 2
	volumenPiramide<- areaBasePiramide * alturaTriangulo / 3
	areaCuadrado<- ladoCuadrado^2
	volumenCubo<- ladoCuadrado^3
	
	Escribir("El área del circulo es: "), areaCirculo
	Escribir("El volumen de la esfera es: "), volumenEsfera
	
	Escribir("El área del triangulo es: "), areaTriangulo
	Escribir("El volumen de la piramide es: "), volumenPiramide
	
	Escribir("El área del cuadrado es: "), areaCuadrado
	Escribir("El volumen del cubo es: "), volumenCubo

FinAlgoritmo
