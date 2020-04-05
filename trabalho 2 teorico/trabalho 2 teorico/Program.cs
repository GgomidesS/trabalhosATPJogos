using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_2_teorico
{
    class Program
    {
        static void Main(string[] args)
        {
            //nome: Gabriel Gomides Surjus
            //data: 02/04/2000
            Console.WriteLine("Aluno: Gabriel Gomides Surjus");
            char opcaoDeContinuar;

            do
            {
                Console.Write("Escolha o numero do exercício: ");
                int escolhaExercicio = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (escolhaExercicio)
                {
                    case 1:
                        //Atividade 1
                        Console.WriteLine("1) Faça um programa para calcular o valor de S, conforme a expressão abaixo, sendo n um valor lido do teclado. \n    S = 1 / n - 2 / (n - 1) + 3 / (n - 2) - 4 / (n - 3) + ... n / 1");
                        Console.WriteLine("--------------------");
                        Console.WriteLine();
                        Console.Write("Digite o valor de n: ");
                        int n = int.Parse(Console.ReadLine());
                        float calculo1 = 0, calculo2 = 0, s = 0, n1 = 1, n2 = 2;
                        for (int i = 0; n1 != n && n2 != n; i += 2)
                        {
                            calculo1 = n1 / (n + i);
                            calculo2 = n2 / (n - (1 + i));
                            s += calculo1 - calculo2;
                            n1 += 2;
                            n2 += 2;
                        }
                        Console.WriteLine(s);
                        break;
                    case 2:
                        //Atividade 2
                        Console.WriteLine("2) Números palíndromos são aqueles que escritos da direita para esquerda ou da esquerda para direita têm o");
                        Console.WriteLine("mesmo valor. Exemplos: 929, 44, 97379. Faça um programa que, dado um número de 5 dígitos, verifique e");
                        Console.WriteLine("informe se é ou não palíndromo.");
                        Console.WriteLine("-------------------");
                        Console.WriteLine();

                        Console.Write("Digite um numero: ");
                        int palindromo = int.Parse(Console.ReadLine());

                        string palindromoString = palindromo.ToString();

                        char[] vetorPalidromoChar1 = palindromoString.ToCharArray();
                        char[] vetorPalidromoChar2 = palindromoString.ToCharArray();
                        Array.Reverse(vetorPalidromoChar1);

                        int cont = 0, regulador = 0;
                        foreach(char p in vetorPalidromoChar1)
                        {
                            if (p == vetorPalidromoChar2[cont])
                            {
                                regulador++;
                            }
                            else
                            {

                            }
                            cont++;
                        }
                        if(regulador == vetorPalidromoChar1.Length)
                        {
                            Console.WriteLine("É Palíndromo");
                        }
                        else
                        {
                            Console.WriteLine("Não é palíndromo");
                        }
                        break;
                    case 3:
                        //Atividade 3
                        Console.WriteLine("3) Supondo que a população de um determinado país A seja de 90.500.000 de habitantes, com uma taxa anual de");
                        Console.WriteLine("crescimento de 3%, e que a população de um outro país B seja de 199.500.000 habitantes, com uma taxa anual");
                        Console.WriteLine("de crescimento de 1,5%, faça um programa que calcule e mostre o número de anos necessários para que a");
                        Console.WriteLine("população do país A ultrapasse ou iguale a população do país B, mantidas essas taxas de crescimento.");
                        Console.WriteLine("--------------------");
                        Console.WriteLine();

                        int anos = 0;
                        float pais1 = 90500000.0f, pais2 = 199500000.0f;
                        while (pais1 < pais2)
                        {
                            pais1 += pais1 * 3.0f / 100.0f;
                            pais2 += pais2 * 1.5f / 100.0f;
                            anos++;
                        }
                        Console.WriteLine(anos + " anos");
                        break;
                    case 4:
                        //Atividade 4
                        char jogo = ' ';

                        do
                        {
                            switch (jogo)
                            {
                                case 'a':
                                    Console.WriteLine("Jogar");
                                    break;
                                case 'b':
                                    Console.WriteLine("Seleção de personagem");
                                    break;
                                case 'c':
                                    Console.WriteLine("Configuração");
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida");
                                    break;
                            }
                            Console.WriteLine("a. Jogar");
                            Console.WriteLine("b. Seleção de personagem");
                            Console.WriteLine("c. configuração");
                            Console.WriteLine("d. sair");
                            jogo = char.Parse(Console.ReadLine());
                            Console.Clear();
                        } while (jogo != 'd');
                        break;
                    case 5:
                        //Atividade 5
                        Console.WriteLine("5) Faça um programa que calcule e escreva a soma dos quadrados dos números múltiplos de 5 que são");
                        Console.WriteLine("menores que 100.");
                        Console.WriteLine("--------------------");
                        Console.WriteLine();

                        double somador = 0;
                        for(int i = 5; i < 100; i += 5)
                        {
                            somador += Math.Pow(i, 2);
                        }
                        Console.WriteLine(somador);
                        break;
                    case 6:
                        //Atividade 6
                        Console.WriteLine("6) Faça um programa que leia um número inteiro positivo n e escreva todos os números positivos múltiplos de");
                        Console.WriteLine("3, de 0 até n. Utilize para isso o comando de repetição while. Por exemplo, se n for igual a 13, deve-se");
                        Console.WriteLine("escrever: 0 3 6 9 12.");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("");

                        Console.Write("Digite um numero: ");
                        int numero = int.Parse(Console.ReadLine());
                        int cont_ = 0;
                        Console.Write("0 ");
                        while (cont_ <= numero)
                        {
                            cont_++;
                            if(cont_ % 3 == 0)
                            {
                                Console.Write(cont_ + " ");
                            }
                        }
                        break;
                    case 7:
                        //Atividade 7
                        Console.WriteLine("7) Desenvolva um programa que leia 4 números, por meio do teclado, e determine e imprima a soma dos três");
                        Console.WriteLine("menores.");
                        Console.WriteLine("--------------------");
                        Console.WriteLine();

                        float numero1, v1 = 0, v2 = 0, v3 = 0;
                        int cont1 = 0;
                        do
                        {
                            Console.Write("Digte um nuemro: ");
                            numero1 = float.Parse(Console.ReadLine());
                            if(cont1 == 0)
                            {
                                v1 = numero1;
                            }
                            else if(cont1 == 1)
                            {
                                v2 = numero1;
                            }
                            else if(cont1 == 2)
                            {
                                v3 = numero1;
                            }
                            cont1++;
                        } while (cont1 != 4);

                        if (numero1 < v1)
                        {
                            v1 = numero1;
                        }
                        else if (numero1 < v2)
                        {
                            v2 = numero1;
                        }
                        else if (numero1 < v3)
                        {
                            v3 = numero1;
                        }

                        Console.WriteLine("Soma dos menores numero = " + (v1 + v2 + v3));
                        break;
                    case 8:
                        //Atividade 8
                        Console.WriteLine("A série de Fibonacci é formada pela seqüência:");
                        Console.WriteLine("1, 1, 2, 3, 5, 8, 13, 21, 34...");
                        Console.WriteLine("Esta sequência é construída de tal forma que, a partir do 3º termo, cada termo é igual à soma dos 2 termos");
                        Console.WriteLine("anteriores. Escreva um programa que peça um número N maior que 2 e que gere e escreva os N primeiros");
                        Console.WriteLine("termos da série.");
                        Console.WriteLine("--------------------");
                        Console.WriteLine();

                        Console.Write("Numeros de termos: ");
                        int quantidade = int.Parse(Console.ReadLine());

                        int fibonacci1 = 0, fibonacci2 = 1, fibonacci3 = 1;

                        for(int i = 0; i < quantidade; i++)
                        {
                            Console.Write(fibonacci3 + " ");
                            fibonacci3 = fibonacci1 + fibonacci2;
                            fibonacci1 = fibonacci2;
                            fibonacci2 = fibonacci3;
                        }
                        break;
                    case 9:
                        //Atividade 9
                        Console.WriteLine("9) André tem 1,50 metros e cresce 2 centímetros por ano, enquanto Bernardo tem 1,10 metros e cresce 3");
                        Console.WriteLine("centímetros por ano. Construa um programa que calcule e escreva quantos anos serão necessários para que");
                        Console.WriteLine("Bernardo seja maior que André. ");
                        Console.WriteLine("--------------------");
                        Console.WriteLine();

                        float alturaAndre = 1.5f, alturaBernado = 1.1f;
                        int anosAltura = 0;
                        while(alturaAndre >= alturaBernado)
                        {
                            alturaAndre += 0.02f;
                            alturaBernado += 0.03f;
                            anosAltura++;
                        }

                        Console.WriteLine(anosAltura + " anos");
                        break;
                    case 10:
                        //Atividade 10
                        Console.WriteLine("10) Faça um programa que leia um número indeterminado de idades dos alunos de uma turma. O último valor");
                        Console.WriteLine("inserido, que não deve entrar nos cálculos, será 0 (flag ou sentinela). O algoritmo deve calcular e apresentar");
                        Console.WriteLine("na tela o número de alunos que têm idade superior a 18 anos e a média de idade da turma.");
                        Console.WriteLine("--------------------");
                        Console.WriteLine();

                        float mediaTurma = 0;
                        int maioresDe18 = 0, somaIdade = 0, cont2 = 0, idade;

                        do
                        {
                            Console.Write("Digite a idade: ");
                            idade = int.Parse(Console.ReadLine());

                            if (idade != 0)
                            {
                                if (idade > 18.0f)
                                {
                                    maioresDe18++;
                                }
                                somaIdade += idade;
                                cont2++;
                            }
                        } while (idade != 0);
                        Console.WriteLine();

                        Console.WriteLine("Exitem {0} alunos com idade superior a 18", maioresDe18);
                        mediaTurma = somaIdade / cont2;
                        Console.WriteLine("Media da turma = " + mediaTurma);
                        break;
                    case 11:
                        //Atividade 11
                        Console.WriteLine("13) O numero 3025 possui a seguinte característica:");
                        Console.WriteLine("30 + 25 = 55");
                        Console.WriteLine("55^2 = 3025");
                        Console.WriteLine("Faça um programa que:");
                        Console.WriteLine("Leia um número de 4 dígitos.");
                        Console.WriteLine("Verifique se o número possui realmente 4 dígitos.");
                        Console.WriteLine("Se não possuir 4 dígitos, apresente uma mensagem de erro para o usuário. \nVerifique se o número possui ou não esta característica e apresente na tela o resultado da verificação.");
                        Console.WriteLine("------------");
                        Console.WriteLine();

                        int divisao2PrimeirosNum;
                        double numeroDeQuatroDigitos, multiplicacao, subtracao2UltimosNum, caracteristica;
                        string numeroDeQuatroDigitosEmString;

                        Console.Write("Digite um numero de 4 Digitos: ");
                        numeroDeQuatroDigitos = double.Parse(Console.ReadLine());
                        numeroDeQuatroDigitosEmString = numeroDeQuatroDigitos.ToString();

                        if (numeroDeQuatroDigitosEmString.Length == 4)
                        {
                            divisao2PrimeirosNum = (int)numeroDeQuatroDigitos / 100;
                            multiplicacao = divisao2PrimeirosNum * 100;
                            subtracao2UltimosNum = numeroDeQuatroDigitos - multiplicacao;
                            caracteristica = divisao2PrimeirosNum + subtracao2UltimosNum;

                            Console.WriteLine();

                            if (Math.Pow(caracteristica, 2) == numeroDeQuatroDigitos)
                            {
                                Console.WriteLine("Este numero apresenta as caracteristica do enunciado");
                            }
                            else
                            {
                                Console.WriteLine("Este numero nao possue as caractereisticas do enunciado");
                            }
                        }
                        else
                        {
                            Console.WriteLine("ERROR");
                        }
                        break;
                    
                    case 12:
                        //Atividade 12
                        Console.WriteLine("12) Escreva um programa que leia um número N que indica quantos valores devem ser lidos a seguir. Para cada");
                        Console.WriteLine("número lido, mostre uma tabela contendo o valor lido e o fatorial deste valor.");
                        Console.WriteLine("--------------------");
                        Console.WriteLine();

                        Console.Write("Digite o valor de N: ");
                        int N = int.Parse(Console.ReadLine());
                        int[] vetorNumeros = new int[N];

                        for (int i = 0; i < N; i++)
                        {
                            Console.Write("Digite o valor do {0}º numero: ", i + 1);
                            vetorNumeros[i] = int.Parse(Console.ReadLine());
                        }

                        int fatorial = 1;
                        for (int i = 0; i < N; i++)
                        {
                            for(int j = vetorNumeros[i]; j >= 1; j--)
                            {
                                fatorial *= j;
                            }
                            Console.WriteLine("Fatorial de {0} = {1}", vetorNumeros[i], fatorial);
                            fatorial = 1;
                        }
                        break;
                    case 13:
                        //Atividade 13
                        Console.WriteLine("13) Faça um programa que realize o produto entre 2 números inteiros A e B utilizando somas sucessivas. Os números");
                        Console.WriteLine("deverão ser lidos do teclado.");
                        Console.WriteLine("--------------------");
                        Console.WriteLine();

                        Console.Write("Digite o valor de A: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Digite o valor de B: ");
                        int b = int.Parse(Console.ReadLine());

                        int somaSucessiva = 0;
                        for(int i = 0; i < b; i++)
                        {
                            somaSucessiva += a; 
                        }
                        Console.WriteLine("Resultado = " + somaSucessiva);
                        break;
                    case 14:
                        //Atividade 14
                        Console.WriteLine("14) Faça um programa que imprima os números ímpares entre 250 e 650 (inclusive) em ordem decrescente.");
                        Console.WriteLine("------------------");
                        Console.WriteLine();
                        for(int i = 250; i <= 650; i += 2)
                        {
                            Console.Write(i + " ");
                        }
                        break;
                    case 15:
                        //Atividade 15
                        Console.WriteLine("15) Uma universidade deseja fazer um levantamento a respeito de seu concurso vestibular. Para cada curso, é");
                        Console.WriteLine("fornecido o seguinte conjunto de valores, via teclado:");
                        Console.WriteLine("• o código do curso; ");
                        Console.WriteLine("• número de vagas;");
                        Console.WriteLine("• número de candidatos do sexo masculino; ");
                        Console.WriteLine("• número de candidatos do sexo feminino.");
                        Console.WriteLine("A entrada de dados será interrompida quando o código do curso for igual a zero. Faça um programa que");
                        Console.WriteLine("calcule e escreva, para cada curso: o código do curso, o número de candidatos por vaga e a porcentagem de");
                        Console.WriteLine("candidatos do sexo. Ao final, o programa deve calcular e escrever o maior número de candidatos por vaga e");
                        Console.WriteLine("o código do curso correspondente (supor que não haja empate).");
                        Console.WriteLine("-----------------");
                        Console.WriteLine();

                        int codigo, maiorVaga = 0, codigoMaiorVaga = 0;
                        do
                        {
                            Console.Write("Digite o codigo do curso: ");
                            codigo = int.Parse(Console.ReadLine());
                            if (codigo != 0)
                            {
                                Console.Write("Numeros De vagas: ");
                                int vagas = int.Parse(Console.ReadLine());
                                Console.Write("Número de candidatos do sexo masculino: ");
                                int quantidadeHomens = int.Parse(Console.ReadLine());
                                Console.Write("Número de candidatos do sexo feminino: ");
                                int quantidadeMulheres = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.WriteLine("Codigo = " + codigo);
                                Console.WriteLine("o número de candidatos por vaga  = " + ((float)vagas / ((float)quantidadeHomens + (float)quantidadeMulheres)));
                                Console.WriteLine("Porcentagem de homens = {0}%", (((float)quantidadeHomens * 100.0f / ((float)quantidadeHomens + (float)quantidadeMulheres))).ToString("F2"));
                                Console.WriteLine("Porcentagem de mulheres = {0}%", (((float)quantidadeMulheres * 100.0f / ((float)quantidadeHomens + (float)quantidadeMulheres))).ToString("F2"));
                                Console.WriteLine("-----------------");

                                if (vagas > maiorVaga)
                                {
                                    maiorVaga = vagas;
                                    codigoMaiorVaga = codigo;
                                }
                            }
                        } while (codigo != 0);
                        Console.WriteLine();
                        Console.WriteLine("Codigo do curso com maior vagas = {0}\nQuantidade de vagas = {1}", codigoMaiorVaga, maiorVaga);
                        break;
                    default:
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Deseja continuar no programa?(s/n)");
                opcaoDeContinuar = char.Parse(Console.ReadLine().ToLower());
                Console.Clear();
            } while (opcaoDeContinuar == 's');
        }
    }
}
