using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_4_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar;
            do
            {
                Console.Write("Escolha o numero da Atividade: ");
                byte atividade = byte.Parse(Console.ReadLine());
                Console.Clear();

                switch (atividade)
                {
                    case 1:
                        //atividade 1
                        Console.WriteLine("Digite a quantidade de linhas e colunas da matriz nula");
                        string[] vetorGenerico = Console.ReadLine().Split(' ');
                        int linhas = int.Parse(vetorGenerico[0]);
                        int colunas = int.Parse(vetorGenerico[1]);
                        int[,] matrizNula = new int[linhas, colunas];

                        for (int i = 0; i < linhas; i++)
                        {
                            for (int j = 0; j < colunas; j++)
                            {
                                matrizNula[i, j] = 0;
                            }
                        }

                        for (int i = 0; i < linhas; i++)
                        {
                            for (int j = 0; j < colunas; j++)
                            {
                                Console.Write(matrizNula[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        //atividade 2
                        Console.Write("Digite o valor da matriz quadrada: ");
                        int valorMatrizQuadrada = int.Parse(Console.ReadLine());
                        int[,] matrizQuadrada = new int[valorMatrizQuadrada, valorMatrizQuadrada];

                        int contColunas = 1, regulador = 1;
                        for (int i = 0; i < valorMatrizQuadrada; i++)
                        {
                            for (int j = 0; j < valorMatrizQuadrada; j++)
                            {
                                matrizQuadrada[i, j] = contColunas;
                                contColunas++;
                            }
                            regulador++;
                            contColunas = regulador;
                        }

                        for (int i = 0; i < valorMatrizQuadrada; i++)
                        {
                            for (int j = 0; j < valorMatrizQuadrada; j++)
                            {
                                Console.Write(matrizQuadrada[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        //atividade 3
                        Console.WriteLine("Digite o valor da matriz 2x2");
                        int[,] matriz2x2 = new int[2, 2];
                        
                        for (int i = 0; i < 2; i++)
                        {
                            string[] vetorGenerico1 = Console.ReadLine().Split(' ');
                            for (int j = 0; j < 2; j++)
                            {
                                matriz2x2[i, j] = int.Parse(vetorGenerico1[j]);
                            }
                        }

                        int somaDiagonalPrincipal = 1, somaDiagonalSecundaria = 1;
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (i == j)
                                {
                                    somaDiagonalPrincipal *= matriz2x2[i, j];
                                }
                                else
                                {
                                    somaDiagonalSecundaria *= matriz2x2[i, j];
                                }
                            }
                        }

                        int determinante = somaDiagonalPrincipal - somaDiagonalSecundaria;

                        Console.WriteLine(determinante);
                        break;

                    case 4:
                        //atividade 4
                        int[,] matriz5x5 = new int[5, 5];
                        Random numerosAleatorios = new Random();
                        //preencho a matriz
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                matriz5x5[i, j] = numerosAleatorios.Next(1, 51);
                            }
                        }
                        //escrevo a matriz na tela
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                Console.Write(matriz5x5[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        //vejo qual quis sao primos
                        Console.WriteLine();
                        int cont = 0;
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                for (int k = 1; k <= matriz5x5[i, j]; k++)
                                {
                                    if (matriz5x5[i, j] % k == 0)
                                    {
                                        cont++;
                                    }
                                }
                                if (cont == 2)
                                {
                                    Console.WriteLine("O {0} é primo e se encontra na posição: [{1} – {2}]", matriz5x5[i, j], i, j);
                                }
                                cont = 0;
                            }
                        }
                        break;

                    case 5:
                        //atividade 5
                        //Preencho os vetores
                        int[] vetorNumeroMatricula = new int[20];
                        float[] vetorPrimeiraNota = new float[20];
                        float[] vetorSegundaNota = new float[20];
                        Console.WriteLine("Digite as matriculas, primeira nota e a segunda nota do aluno(separadas por espaço)");
                        for (int i = 0; i < 20; i++)
                        {
                            string[] vetorGenerico2 = Console.ReadLine().Split(' ');
                            vetorNumeroMatricula[i] = int.Parse(vetorGenerico2[0]);
                            vetorPrimeiraNota[i] = float.Parse(vetorGenerico2[1]);
                            vetorSegundaNota[i] = float.Parse(vetorGenerico2[2]);
                        }

                        Console.Clear();
                        //preencho a matriz
                        float[,] matrizGeral = new float[4, 20];
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 20; j++)
                            {
                                if (i == 0)
                                {
                                    matrizGeral[i, j] = vetorNumeroMatricula[j];
                                }
                                else if (i == 1)
                                {
                                    matrizGeral[i, j] = vetorPrimeiraNota[j];
                                }
                                else if (i == 2)
                                {
                                    matrizGeral[i, j] = vetorSegundaNota[j];
                                }
                                else
                                {
                                    matrizGeral[i, j] = (vetorPrimeiraNota[j] + vetorSegundaNota[j]) / 2;
                                }
                            }
                        }
                        //escrevo a matriz na tela
                        Console.WriteLine("Matricula | nota 1 | nota 2 | media das notas");
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                Console.Write(matrizGeral[j, i] + " | ");
                            }
                            Console.WriteLine();
                        }
                        //vejo qual e a maior nota
                        float maiorNota = 0;
                        int matriculaMaiorNota = 0;
                        for (int i = 0; i < 20; i++)
                        {
                            if (matrizGeral[3, i] > maiorNota)
                            {
                                maiorNota = matrizGeral[3, i];
                                matriculaMaiorNota = (int)matrizGeral[0, i];
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Matrícula com maior nota : {0}", matriculaMaiorNota);
                        Console.WriteLine("Nota Média: {0}", maiorNota);
                        break;
                }

                Console.WriteLine();
                Console.Write("Deseja Continuar(s/n): ");
                continuar = char.Parse(Console.ReadLine().ToLower());
                Console.Clear();
            } while (continuar == 's');
        }
    }
}
