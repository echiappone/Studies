programa {
	funcao inicio() {
	    
		// 8. O custo ao consumidor de um carro novo é a soma do custo de fábrica com a
        // do distribuidor e dos impostos (aplicados ao custo de fábrica).
        // Supondo que a percentagem do distribuidor seja de 28% e os impostos de 45%,
        // escrever um programa que leia o custo de fábrica de um carro e escreva o custo
        // ao consumidor
		
		real custoc, custof
		
		escreva("Informe o custo de fabrica: ")
		leia(custof)
		
		custoc = custof + (custof * 0.28) + (custof * 0.45)
		
		escreva ("O custo total do consumidor é: ", custoc)
	}
}
