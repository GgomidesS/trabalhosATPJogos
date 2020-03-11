using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_exercícios_2_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            char escolha;
            int atividade;

            do
            {
                Console.Write("Escolha o numero da atividade: ");
                atividade = int.Parse(Console.ReadLine());
                Console.WriteLine("------------");
                Console.WriteLine();

                switch (atividade)
                {
                    case 1:
                        //Atividade 1
                        for(int i = 1001; i <= 5000; i += 2)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case 2:
                        //Atividade 2
                        for (int i = 3000; i >= 1999; i--)
                        {
                            if(i % 11 == 5)
                            {
                                Console.WriteLine(i % 11);
                            }
                            else
                            {
                                Console.WriteLine(i);
                            }
                        }
                        break;

                    case 3:
                        //Atividade 3
                        double N, G = 0, H = 0;

                        Console.Write("Digite \"N\": ");
                        N = double.Parse(Console.ReadLine());

                        for(double i = 1; i <= N; i++)
                        {
                            H += 1 / i;
                        }
                        for(double i = 1, j = 1; j<=99; i++, j += 2)
                        {
                            G += (i / j);
                        }

                        Console.WriteLine("H = {0}", H.ToString("F4"));
                        Console.WriteLine("G = {0}", G.ToString("F4"));
                            break;
   
                    case 4:
                        //atividade 4
                        double pesoValor, alturaValor;
                        int idadeValor, somaIdade = 0, pessoasComMaisDe90Kg = 0, alturaMenorQue150 = 0, pessoaEntra10e30 = 0;

                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine("Pessoa {0}", i);
                            Console.Write("Digite sua Idade: ");
                            idadeValor = int.Parse(Console.ReadLine());
                            Console.Write("Digite seu peso: ");
                            pesoValor = double.Parse(Console.ReadLine());
                            Console.Write("Digite seu Altura: ");
                            alturaValor = double.Parse(Console.ReadLine());

                            somaIdade += idadeValor;

                            if(pesoValor > 90)
                            {
                                pessoasComMaisDe90Kg++;
                            }
                            if(alturaValor < 1.50)
                            {
                                alturaMenorQue150++;
                            }
                            if(idadeValor >= 10 && idadeValor <= 30 && alturaValor > 1.90)
                            {
                                pessoaEntra10e30++;
                            }

                        }
                        Console.WriteLine("Media das idades: {0}", somaIdade / 10);
                        Console.WriteLine("Pessoas com mais de 90 kg: {0}", pessoasComMaisDe90Kg);
                        Console.WriteLine("Pessoa menos de 1,50 de altura: {0}", alturaMenorQue150);
                        Console.WriteLine("Pessoas com idade maior que 10 menos que 30 maior que 1,90: {0}", pessoaEntra10e30);
                        break;

                    case 5:
                        //Atividade 5
                        int somapares = 0;
                        for(int i = 0; i <= 50; i += 2)
                        {
                            somapares += i;
                        }

                        Console.WriteLine("A soma dos numeros pares entre 0 e 50 = {0}", somapares);
                        break;

                    case 6:
                        //Atividade 6
                        int numeroEntrada;

                        Console.WriteLine("Digite um numero inteiro: ");
                        numeroEntrada = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Os 20 numeros subsequentes de {0} são...", numeroEntrada);

                        for(int i = 1; i <= 20; i++)
                        {
                            Console.WriteLine(numeroEntrada += 1);
                        }
                        break;

                    case 7:
                        //Atividade 7
                        int valorInicial, valorFinal;

                        Console.Write("Digite o valor Inicial: ");
                        valorInicial = int.Parse(Console.ReadLine());
                        Console.Write("Digite o valor Final: ");
                        valorFinal = int.Parse(Console.ReadLine());

                        if(valorInicial < valorFinal)
                        {
                            for(int i = valorInicial + 1; i <= valorFinal; i++)
                            {
                                valorInicial += i;
                            }
                            Console.WriteLine(valorInicial);
                        }
                        else
                        {
                            for (int i = valorFinal + 1; i <= valorInicial; i++)
                            {
                                valorFinal += i;
                            }
                            Console.WriteLine(valorFinal);
                        }
                        break;

                    case 8:
                        //Atividade 8
                        double numeroDeEntrada, soma100Primeiros = 0, soma101A200 = 0, soma201A300 = 0;

                        for(int i = 1; i <= 300; i++)
                        {
                           Console.Write("Digite {0}º numero: ", i);
                           numeroDeEntrada = double.Parse(Console.ReadLine());

                            if(i <= 100)
                            {
                                soma100Primeiros += numeroDeEntrada;
                            }
                            else if(i >= 101 && i <= 200)
                            {
                                soma101A200 += numeroDeEntrada;
                            }
                            else
                            {
                                soma201A300 += numeroDeEntrada;
                            }
                        }

                        Console.WriteLine("Soma dos 100 Primeiros: {0}", soma100Primeiros);
                        Console.WriteLine("Soma do 101 a 200: {0}", soma101A200);
                        Console.WriteLine("Soma do 201 a 300: {0}", soma201A300);
                        break;

                    case 9:
                        //Atividade 9
                        double _base, expoente, basefixo;

                        Console.Write("Digite a Base: ");
                        _base = int.Parse(Console.ReadLine());
                        Console.Write("Digite o Expoente: ");
                        expoente = int.Parse(Console.ReadLine());
                        basefixo = _base;

                        for (int i = 1; i < expoente; i++ )
                        {
                           _base *= basefixo;
                        }
                        Console.WriteLine("resultado = {0}", _base);
                        break;
                }

                Console.WriteLine();
                Console.Write("Quer continuar no Programa(s/n): ");
                escolha = char.Parse(Console.ReadLine().ToLower());
                Console.Clear();
            } while (escolha == 's');
        }
    }
}
