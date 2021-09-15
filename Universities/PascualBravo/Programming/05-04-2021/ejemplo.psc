Algoritmo Ejemplo
	// Escribir es para siempre mostrar algo al usuario.
	Escribir "w", " " ,"x", " ", "y"
	
	// Leer es recibir lo que el usuario digite.
	Leer w, x
	
	Escribir "X -> ", x, ", W -> ", w
	
	// Asignar una variable sin tener que pedirla al usuario
	// Asignar son variables que nosotros mismos hacemos.
	interes<-1.1
	variableY<-123
	
	// Condicional
	
	// Si preguntamos algo y esto se cumple
	// hacemos determinado bloque
	// Y si no se cumple, ejecutamos el otro bloque.
	Si w > x Entonces
		Escribir "W es mayor que X"
		Escribir "La condición es verdadera"
		interes<-1.3
	SiNo
		Escribir "X es mayor que W"
		Escribir "dasdasd"
		Escribir "dasda"
	Fin Si
	
	
	cuantoGane<- variableY * interes
	Escribir "Lo que gané es: ", cuantoGane
	
	
	
FinAlgoritmo
