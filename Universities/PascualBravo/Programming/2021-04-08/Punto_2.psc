Algoritmo Punto_2
	Escribir("Digite el salario, por favor.")
	Leer salarioUSD
	
	Si salarioUSD <= 200 Entonces
		descuentoEnUSD<- salarioUSD * 0.1
		salarioNetoUSD<- salarioUSD - descuentoEnUSD
	FinSi
	Si salarioUSD > 200 y salarioUSD <= 250 Entonces
		descuentoEnUSD<- salarioUSD * 0.05
		salarioNetoUSD<- salarioUSD - descuentoEnUSD
	FinSi
	Si salarioUSD > 300 Entonces
		descuentoEnUSD<- salarioUSD * 0.03
		salarioNetoUSD<- salarioUSD - descuentoEnUSD
	FinSi
	
	descuentoEnCOP<- descuentoEnUSD * 3600
	salarioNetoCOP<- salarioNetoUSD * 3600

	Escribir("El descuento en USD es: "), descuentoEnUSD
	Escribir("El Salario neto en USD es: "), salarioNetoUSD
	
	Escribir("El descuento en COP es: "), descuentoEnCOP
	Escribir("El Salario neto en COP es: "), salarioNetoCOP
FinAlgoritmo
