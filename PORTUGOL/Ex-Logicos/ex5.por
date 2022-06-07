programa {
	funcao inicio() {
		//Faça um programa que leia as 3 notas de um aluno e calcule a média final
        //deste aluno. Considerar que a média é ponderada e que o peso das notas é: 2,3 e, 5
        //respectivamente.
        inteiro nota1, nota2, nota3, media
        
        escreva("Digite sua primeira nota: ")
        leia(nota1)
        escreva("Digite sua segunda nota: ")
        leia(nota2)
        escreva("Digite sua terceira nota:")
        leia(nota3)
        
        nota1 = (nota1 * 2) / 10
        nota2 = (nota2 * 3) / 10
        nota3 = (nota3 * 5) / 10
        media = nota1 + nota2 + nota3
        
        escreva("Sua média é: ", media)
	}
}
