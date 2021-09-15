Algoritmo Punto_2
	Escribir("Por favor digíte la hora de entrada, por favor: ")
	Leer hora_de_entrada
	Escribir("Por favor digíte los minutos de entrada, por favor: ")
	Leer minutos_de_entrada
	
	Escribir("Por favor digíte la hora de salida, por favor: ")
	Leer hora_de_salida
	Escribir("Por favor digíte los minutos de salida, por favor: ")
	Leer minutos_de_salida
	
	// Ejemplos para testear
	// 2:00 - 3:15
	// 3:35 - 5:15
	// 12:15 - 4:05

	Si hora_de_entrada = hora_de_salida Entonces
		valor_a_pagar <- 3500
	SiNo
		Si minutos_de_salida >= minutos_de_entrada Entonces
			cantidad_de_15_minutos <- Trunc((minutos_de_salida - minutos_de_entrada) / minutos_de_salida)
			cantidad_de_horas <- hora_de_salida - hora_de_entrada - 1
			valor_a_pagar <- (5000 * cantidad_de_horas) + (1250 * cantidad_de_15_minutos) + 3500
		SiNo
			proporcion_cantidad_de_15_minutos <- Trunc(minutos_de_entrada / minutos_de_salida)
			
			Si proporcion_cantidad_de_15_minutos = 1 Entonces
				cantidad_de_15_minutos <- 3
			FinSi
			Si proporcion_cantidad_de_15_minutos = 2 Entonces
				cantidad_de_15_minutos <- 2
			FinSi
			Si proporcion_cantidad_de_15_minutos = 3 Entonces
				cantidad_de_15_minutos <- 2
			FinSi
			
			cantidad_de_horas <- hora_de_salida - hora_de_entrada - 2
			
			valor_a_pagar <- (5000 * cantidad_de_horas) + (1250 * cantidad_de_15_minutos) + 3500
			
			Si cantidad_de_horas < 0 Entonces
				valor_a_pagar <- 3500
			FinSi
		FinSi
	FinSi

	Escribir("El valor a pagar es: "), valor_a_pagar
FinAlgoritmo