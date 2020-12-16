using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
	        // 1 - Faça um programa que receba o nome e quatro notas de 10 alunos e armazene essas notas em vetores. Calcule e mostre:
	        // A. A Média do aluno - Função
	        // B. A quantidade de Aprovados (Média >=7)
	        // C. A quantidade de Reprovados (Méida < 7)
	        // D. A Média geral dos 10 alunos.

            Console.Clear();

            Media ();
                void Media () {

                string[] nomes = new string [10];
                float[] nota1 = new float [10];
                float[] nota2 = new float [10];
                float[] nota3 = new float [10];
                float[] nota4 = new float [10];
                float[] media = new float [10];

                for (var i = 0; i < 10; i++)
                {
                    Console.WriteLine("Digite o nome do aluno:");
                    nomes[i] = Console.ReadLine();

                    Console.WriteLine("Digite a 1º nota do aluno:");
                    nota1[i] = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a 2º nota do aluno:");
                    nota2[i] = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite 3º terceira nota do aluno:");
                    nota3[i] = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a 4] nota do aluno:");
                    nota4[i] = float.Parse(Console.ReadLine());

                    media[i] = (nota1[i] + nota2[i] + nota3[i] + nota4[i])/4;

                }
                    for (var i = 0; i < 10; i++)
                    {
                        Console.WriteLine($"O Aluno {nomes[i]} possui média = {media[i]}");
                    }
                
                    for (var i = 0; i < 10; i++)
                    {
                         if(media [i] >= 7){
                               Console.WriteLine($"O(A) aluno(a) {nomes[i]} possui média = {media[i]} e está aprovado");
                            
                        }else{
                               Console.WriteLine($"O(A) aluno(a) {nomes[i]} possui média = {media[i]} e está reprovado"); 
                            
                        }
                    }
                }       

        }
    }
}

