Algoritmo Punto_9
	Escribir("Digite la cantidad de litros: ")
	Leer litros
	onzas_liquidas <- litros * 33.814
	metros_cubicos <- litros / 1000
	centimetros_cubicos <- litros * 1000
	
	Escribir litros, " litros equivalen a ", onzas_liquidas, " onzas líquidas"
	Escribir litros, " litros equivalen a ", metros_cubicos, " metros cúbicos"
	Escribir litros, " litros equivalen a ", centimetros_cubicos, " centimetros cúbicos"
FinAlgoritmo
