Algoritmo Leccion_9
	Definir peso_acumulado, peso_manzana, contador como real
	Escribir "Vascula de mercado"
	Mientras peso_acumulado <= 1000 Hacer
		Escribir "Ingrese el peso de la manzana en gramos (100-300)"
		Leer peso_manzana
		si peso_manzana>=100 y peso_manzana<=300 Entonces
			contador= contador +1
			peso_acumulado=peso_acumulado+peso_manzana
			Escribir "LLeva ",contador," manzanas"
			Escribir "Peso actual: ",peso_acumulado,"gramos"
		SiNo
			Escribir "manzana no existe"
		FinSi
	FinMientras
	Escribir "meta alcanzada"
FinAlgoritmo
