programa {
	funcao inicio() {
	    inteiro anos, meses, dias, idade
	    
		escreva("Informe quantos dias de vida você tem: ")
		leia (dias)

        anos = dias / 365
        
        meses = (dias % 365) / 30
		
		dias = (dias % 365) % 30
		
		
		escreva("Você tem: ", anos," anos, ", meses, " meses e ", dias, " dias de vida")
	}
}