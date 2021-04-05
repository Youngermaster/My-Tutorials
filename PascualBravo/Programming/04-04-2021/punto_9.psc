Algoritmo Punto_9
	Escribir("Digite el número de litros para 100Km")
	Leer litros_para_100_km
	
	galones_por_milla <- 235.215 / (litros_para_100_km)
	galones_por_km <- galones_por_milla * 1.609
	
	Escribir("El número de kilometros por galón es: "), galones_por_km
FinAlgoritmo
