using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {              
            char continuar;
            int numeroExercicio;
            do
            {
                Console.Write("Digite o numero do exercicio: ");
                numeroExercicio = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (numeroExercicio)
                {
                    //atividade 1
                    case 1:
                        int numeroParOuImpar;

                        Console.WriteLine("Atividade 1");
                        Console.WriteLine("------------");

                        Console.Write("Digite o numero para saber se é Par ou Impar: ");
                        numeroParOuImpar = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        if (numeroParOuImpar % 2 == 0)
                        {
                            Console.WriteLine("O numero {0} é par", numeroParOuImpar);
                        }
                        else
                        {
                            Console.WriteLine("O numero {0} é impar", numeroParOuImpar);
                        }                        
                        break;

                    //atividade 2
                    case 2:
                        double numero1, numero2;

                        Console.WriteLine("Atividade 2");
                        Console.WriteLine("------------");

                        Console.Write("Digite o primeiro numero: ");
                        numero1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo numero: ");
                        numero2 = double.Parse(Console.ReadLine());

                        Console.WriteLine();

                        if (numero1 == numero2)
                        {
                            Console.WriteLine("NÚMEROS IGUAI");
                        }
                        else if (numero1 > numero2)
                        {
                            Console.WriteLine("{0} é o maior numero", numero1);
                        }
                        else
                        {
                            Console.WriteLine("{0} é o maior numero", numero2);
                        }                        
                        break;

                    //atividade 3
                    case 3:
                        double a, b, c;

                        Console.WriteLine("Atividade 3");
                        Console.WriteLine("------------");

                        Console.Write("Digite o Primeiro numero: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Digite o Segundo numero: ");
                        b = double.Parse(Console.ReadLine());
                        Console.Write("Digite o Terceiro numero: ");
                        c = double.Parse(Console.ReadLine());

                        Console.WriteLine();

                        if (a < b && a < c)
                        {
                            Console.WriteLine("{0} é o menor numero", a);
                        }
                        else if (b < a && b < c)
                        {
                            Console.WriteLine("{0} é o menor numero", b);
                        }
                        else
                        {
                            Console.WriteLine("{0} é o menor numero", c);
                        }                        
                        break;

                    //atividade 4
                    case 4:
                        double nota1, nota2;

                        Console.WriteLine("Atividade 4");
                        Console.WriteLine("------------");

                        Console.Write("Digite a nota 1: ");
                        nota1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite a nota 2: ");
                        nota2 = double.Parse(Console.ReadLine());

                        Console.WriteLine();

                        if (nota1 > 80 || nota2 > 80)
                        {
                            Console.WriteLine("Você nao pode ter nota maior que 80");
                        }
                        else
                        {
                            if ((nota1 + nota2) / 2 >= 40)
                            {
                                Console.WriteLine("Você foi aprovado. Parabens!!!");
                            }
                            else
                            {
                                Console.WriteLine("Você foi reporovado. Mais sorte na proxima");
                            }
                        }                        
                        break;

                    //atividade 5
                    case 5:
                        int escolhaMetodo;
                        double calculo1, calculo2;

                        Console.WriteLine("Atividade 5");
                        Console.WriteLine("------------");

                        Console.Write("Digite o peimeiro numero para ser calculado: ");
                        calculo1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo numero para ser calculado: ");
                        calculo2 = double.Parse(Console.ReadLine());
                        
                        Console.WriteLine();
                        
                        Console.WriteLine("escolha a operação");
                        Console.WriteLine("1 - Adição \n2 - Subtração \n3 - Multiplicação\n4 - Divisão");
                        escolhaMetodo = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        switch (escolhaMetodo)
                        {
                            case 1:
                                Console.WriteLine("A Adição de {0} + {1} = {2}", calculo1, calculo2, (calculo1 + calculo2).ToString("F"));
                                break;

                            case 2:
                                Console.WriteLine("A Subtração de {0} - {1} = {2}", calculo1, calculo2, (calculo1 - calculo2).ToString("F"));
                                break;

                            case 3:
                                Console.WriteLine("A Multiplicação de {0} x {1} = {2}", calculo1, calculo2, (calculo1 * calculo2).ToString("F"));
                                break;

                            case 4:
                                Console.WriteLine("A Divisão de {0} / {1} = {2}", calculo1, calculo2, (calculo1 / calculo2).ToString("F"));
                                break;
                            default:
                                Console.WriteLine("ERROR");
                                break;
                        }
                        break;

                    //Atividade 6
                    case 6:
                        int quantidadeParafuso;

                        Console.WriteLine("Atividade 6");
                        Console.WriteLine("------------");

                        Console.WriteLine("Desconto parafuso");
                        Console.WriteLine("______________________________\n No de Parafusos | Desconto|\n|   1 a 99    |   0% |\n| 100 a 199   |  10% |\n| 200 a 299   |  20% |\n" +
                            "| Acima de 200|  30% |\n---------------------");

                        Console.Write("Quantos parafusos você quer comprar: ");
                        quantidadeParafuso = int.Parse(Console.ReadLine());

                        if (quantidadeParafuso >= 1 && quantidadeParafuso <= 99)
                        {
                            Console.WriteLine((quantidadeParafuso * 0.80).ToString("c"));
                        }
                        else if (quantidadeParafuso >= 100 && quantidadeParafuso <= 199)
                        {
                            Console.WriteLine(((quantidadeParafuso * 0.80) - (quantidadeParafuso * 0.80) / 10).ToString("c"));
                        }
                        else if(quantidadeParafuso >= 200 && quantidadeParafuso <= 299)
                        {
                            Console.WriteLine(((quantidadeParafuso * 0.80) - ((quantidadeParafuso * 0.80) * 20) / 100).ToString("c"));
                        }
                        else
                        {
                            Console.WriteLine(((quantidadeParafuso * 0.80) - ((quantidadeParafuso * 0.80) * 30) / 100).ToString("c"));
                        }
                        break;

                    //Atividade 7
                    case 7:
                        int menor1, menor2, menor3;

                        Console.WriteLine("Atividade 7");
                        Console.WriteLine("------------");

                        Console.Write("Digite o Primeiro valor inteiro: ");
                        menor1 = int.Parse(Console.ReadLine());
                        Console.Write("Digite o Segundo valor inteiro: ");
                        menor2 = int.Parse(Console.ReadLine());
                        Console.Write("Digite o Terceiro valor inteiro: ");
                        menor3 = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        if (menor1 > menor2 && menor1 > menor3)
                        {
                            Console.WriteLine("A soma dos dois menores numero é {0} + {1} = {2}", menor2, menor3, menor2 + menor3);
                        }
                        else if(menor2 > menor1 && menor2 > menor3)
                        {
                            Console.WriteLine("A soma dos dois menores numero é {0} + {1} = {2}", menor1, menor3, menor1 + menor3);
                        }
                        else
                        {
                            Console.WriteLine("A soma dos dois menores numero é {0} + {1} = {2}", menor1, menor2, menor1 + menor2);
                        }
                        break;

                    //atividade 8
                    case 8:
                        double numero;

                        Console.WriteLine("Atividade 8");
                        Console.WriteLine("------------");

                        Console.Write("Digite um numero: ");
                        numero = double.Parse(Console.ReadLine());

                        if(numero % 2 != 0)
                        {
                            Console.WriteLine("O numero {0} é impar", numero);
                        }
                        else
                        {
                            Console.WriteLine("O numero {0} nao é impar", numero);
                        }

                        if(numero % 5 == 0)
                        {
                            Console.WriteLine("O numero {0} é multiplo de 5", numero);
                        }
                        else
                        {
                            Console.WriteLine("O numero {0} nao é multiplo de 5", numero);
                        }

                        if(numero % 3 != 0)
                        {
                            Console.WriteLine("O numero {0} nao é multiplo de 3", numero);
                        }
                        else
                        {
                            Console.WriteLine("O numero {0} é multiplo de 3", numero);
                        }
                        break;

                    //atividade 9
                    case 9:
                        double N1, N2;

                        Console.WriteLine("Atividade 9");
                        Console.WriteLine("------------");

                        Console.Write("Digite o Primeiro valor: ");
                        N1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o Segundo valor: ");
                        N2 = double.Parse(Console.ReadLine());
                        
                        Console.WriteLine();

                        if(N1 > N2)
                        {
                            Console.WriteLine("{0} + {1} = {2}", N1, N2, N1 + N2);
                        }
                        else if(N1 < N2)
                        {
                            Console.WriteLine("{0} - {1} = {2}", N1, N2, N1 - N2);
                        }
                        else
                        {
                            Console.WriteLine("nao tinha nada na atividade sobre numeros iguais");
                        }
                        break;

                    //Atividade 10
                    case 10:
                        double n1, n2, n3;
                        int codigo;

                        Console.WriteLine("Atividade 10");
                        Console.WriteLine("------------");

                        Console.Write("Digite o Primeiro valor: ");
                        n1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o Segundo valor: ");
                        n2 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o Terceiro valor: ");
                        n3 = double.Parse(Console.ReadLine());

                        Console.WriteLine();

                        Console.WriteLine("Escolha um Codigos");
                        Console.WriteLine("código = 1: multiplicar os três valores\ncódigo = 2: somar os três valores\ncódigo = 3: subtrair os três valores\n" +
                            "código = 4: somar o quadrado dos 3 valores\ncódigo = 5: subtrair o quadrado dos 3 valores.");
                        codigo = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        switch (codigo)
                        {
                            case 1:
                                Console.WriteLine("{0} x {1} x {2} = {3}", n1, n2, n3, n1 * n2 * n3);
                                break;
                            case 2:
                                Console.WriteLine("{0} + {1} + {2} = {3}", n1, n2, n3, n1 + n2 + n3);
                                break;
                            case 3:
                                Console.WriteLine("{0} - {1} - {2} = {3}", n1, n2, n3, n1 - n2 - n3);
                                break;
                            case 4:
                                Console.WriteLine("{0}² + {1}² + {2}² = {3}", n1, n2, n3, Math.Pow(n1, 2) + Math.Pow(n2, 2) + Math.Pow(n3, 2));
                                break;
                            case 5:
                                Console.WriteLine("{0}² - {1}² - {2}² = {3}", n1, n2, n3, Math.Pow(n1, 2) - Math.Pow(n2, 2) - Math.Pow(n3, 2));
                                break;
                            default:
                                Console.Write("CÓDIGO INVÁLIDO");
                                break;
                        }
                        break;
                }

                //while que faz a pergunta se quer continuar no programa ou sair
                Console.WriteLine();
                Console.WriteLine("------------");
                Console.Write("Deseja continuar (s/n): ");
                continuar = char.Parse(Console.ReadLine());
                Console.Clear();
            } while (continuar == 's' || continuar == 'S');
        }
    }
}


