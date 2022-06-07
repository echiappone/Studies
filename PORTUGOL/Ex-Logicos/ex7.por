programa {
	funcao inicio() {
		// 7. Um sistema de equações lineares do tipo:
		// as + by = c & dx + ey = f
		// pode ser resolvido da seguinte forma:
		// x = (ce - bf) / (ae - bd)
		// y = (af - cd) / (ae - bd)
		// Escreva um programa que leia os coeficientes a,b,c,d,e,f 
		// e calcula e mostra os valores de x e y.
		
		real A, B, C, D, E, F, X, Y, final, final2
		
		escreva ("insira a letra A: ")
		leia (A)
		escreva ("insira a letra B: ")
		leia (B)
		escreva ("insira a letra C: ")
		leia (C)
		escreva ("insira a letra D: ")
		leia (D)
		escreva ("insira a letra E: ")
		leia (E)
		escreva ("insira a letra F: ")
		leia (F)
		
		X = ((C*E)-(B*F)) / ((A*E)-(B*D))
		Y = ((A*F)-(C*D)) / ((A*E)-(B*D))
		
		final = ((A*X)+(B*Y))
		final2 = ((D*X)+(E*Y))
		
		escreva ("Resultado final: ", final, " Resultado final2: ", final2)
    
	}
}
