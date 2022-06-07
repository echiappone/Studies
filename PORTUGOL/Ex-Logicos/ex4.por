programa {
	funcao inicio() {
		inteiro A, B, C, D, R, S
		escreva("Digite o valor de A: ")
		leia(A)
		escreva("Digite o valor de B: ")
		leia(B)
		escreva("Digite o valor de C: ")
		leia(C)
		
		R = (A + B) * (A + B)
		S = (B + C) * (B + C)
		D = (R + S) / 2
		
		escreva("Resultado de D: ", D)
	}
}
