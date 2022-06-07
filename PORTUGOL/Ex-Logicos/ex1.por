programa {
	funcao inicio() {
	    inteiro anos, meses, dias, idade
	    
		escreva("Informe quantos anos, meses e dias de vida você tem (digite um de cada vez e apenas os numeros) ")
		escreva("Primeiro os anos: ")
		leia (anos)
		escreva("Meses: ")
		leia (meses)
		escreva("Dias: ")
		leia (dias)
		
		idade = (anos * 365) + (meses * 30) + dias
		
		
		escreva ("você tem: ", idade, " dias de vida")
	}
}