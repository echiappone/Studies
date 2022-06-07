programa {
	funcao inicio() {
	    inteiro segundos, minutos, horas
	    
		escreva("informe quantos segundos o evento durou: ")
		leia (segundos)
		
		horas = segundos / 3600
		minutos = (segundos % 3600) / 60
		segundos = (segundos % 3600) % 60
		
		escreva("O evento durou: ", horas + " horas, ", minutos + " minutos e ", segundos + " segundos")
		
	}
}
