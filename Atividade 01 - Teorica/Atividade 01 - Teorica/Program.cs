using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_01___Teorica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Nome: Gabriel Gomides Surjus
             Data: 05 / 03 / 2020
            */
            char continuar;
            int escolhaAtividade;

            Console.WriteLine("1ª LISTA DE EXERCÍCIOS\nNome: Gabriel Gomides Surjus\nData: 05 / 03 / 2020");
            Console.WriteLine();
            do
            {
                Console.Write("Digite o Numero da Atividade de 5 a 20: ");
                escolhaAtividade = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (escolhaAtividade)
                {
                    case 5:
                        //Atividade 5
                        Console.WriteLine("5) Faça um programa que peça ao usuário a base e a altura de um triângulo e calcule e imprima a sua área.");
                        Console.WriteLine("------------");
                        Console.WriteLine();

                        double alturaTriangulo, baseTriangulo, areaTriangulo;

                        Console.Write("Digite a altura do triângulo: ");
                        alturaTriangulo = int.Parse(Console.ReadLine());
                        Console.Write("Difgite a base do triângulo: ");
                        baseTriangulo = int.Parse(Console.ReadLine());

                        areaTriangulo = alturaTriangulo * baseTriangulo / 2.0;

                        Console.WriteLine("A área do triângulo é {0}", areaTriangulo);
                        break;

                    case 6:
                        //Atividade 6
                        Console.WriteLine("6) Faça um programa que leia um número N pelo teclado e imprima o resto da sua divisão por 7.");
                        Console.WriteLine("------------");
                        Console.WriteLine();

                        double numeroDivididoPor7;

                        Console.Write("Digite um numero para ser dividido por 7: ");
                        numeroDivididoPor7 = double.Parse(Console.ReadLine());

                        Console.WriteLine("{0} / 7 = {1}", numeroDivididoPor7, numeroDivididoPor7 / 7.0);
                        break;

                    case 7:
                        //Atividade 7
                        Console.WriteLine("7) Faça um programa que leia a temperatura da água e mostre se ela está no estado sólido, líquido ou gasoso.Considere que a água congela a 0 °C e ferve a 100 °C.");
                        Console.WriteLine("------------");
                        Console.WriteLine();

                        double temperaturaDaAgua;

                        Console.Write("Digite a temperatura da agua: ");
                        temperaturaDaAgua = double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (temperaturaDaAgua <= 0)
                        {
                            Console.WriteLine("A agua esta no estado Solido");
                        }
                        else if (temperaturaDaAgua > 0 && temperaturaDaAgua < 100)
                        {
                            Console.WriteLine("A agua esta no estado Liquido");
                        }
                        else
                        {
                            Console.WriteLine("A agua esta no estado Gasoso");
                        }
                        break;

                    case 8:
                        //Atividade 8
                        Console.WriteLine("8) Faça um programa que efetue as operações de adição, subtração, multiplicação e divisão dos números 17.4 e 3.5 e apresente, ao final, os quatro resultados obtidos.");
                        Console.WriteLine("------------");
                        Console.WriteLine();

                        Console.WriteLine("{0} + {1} = {2}", 17.4, 3.5, 17.4 + 3.5);
                        Console.WriteLine("{0} - {1} = {2}", 17.4, 3.5, 17.4 - 3.5);
                        Console.WriteLine("{0} x {1} = {2}", 17.4, 3.5, 17.4 * 3.5);
                        Console.WriteLine("{0} / {1} = {2}", 17.4, 3.5, (17.4 / 3.5).ToString("F"));
                        break;

                    case 9:
                        //Atividade 9
                        Console.WriteLine("9) Faça um programa que calcule a soma dos termos de uma progressão aritmética (P.A.), lendo os valores do primeiro termo, do segundo termo e do número de termos.");
                        Console.WriteLine("     Fórmulas:\n     Sn = n * (a1 + an) / 2, onde Sn é a soma dos termos, a1 o primeiro termo e an o último termo.\n     O n - ésimo termo de uma progressão aritmética é dado por: an = a1 + (n - 1).r, onde r é a razão da P.A.");
                        Console.WriteLine("------------");
                        Console.WriteLine();

                        double primeiroTermo, QuantidadeDeTermos, razao, termoGeral, somaDosTermos;

                        Console.Write("Digite o Primeiro Termo: ");
                        primeiroTermo = double.Parse(Console.ReadLine());
                        Console.Write("Digite a Quantidade de Termos: ");
                        QuantidadeDeTermos = double.Parse(Console.ReadLine());
                        Console.Write("Digite a razão: ");
                        razao = double.Parse(Console.ReadLine());

                        termoGeral = primeiroTermo + (QuantidadeDeTermos - 1) * razao;
                        somaDosTermos = (primeiroTermo + termoGeral) * QuantidadeDeTermos / 2;

                        Console.WriteLine("Termo Geral = {0}", termoGeral);
                        Console.WriteLine("Soma dos Termos = {0}", somaDosTermos);
                        break;

                    case 10:
                        //Atividade 10
                        Console.WriteLine("10) Faça um programa que leia um valor x e, se ele for menor que 0, calcule e imprima o valor de y, utilizando aequação y = x2 + 4. Se x for maior que ou igual a 0, y = x3- 3.");
                        Console.WriteLine("------------");
                        Console.WriteLine();

                        double x;

                        Console.Write("Digite um valor: ");
                        x = double.Parse(Console.ReadLine());

                        if (x < 0)
                        {
                            Console.WriteLine("y =  {0}² + 4 => y = {1} ", x, Math.Pow(x, 2) + 4);
                        }
                        else
                        {
                            Console.WriteLine("y = {0}³ - 3 => y = {1}", x, Math.Pow(x, 3) - 3);
                        }
                        break;

                    case 11:
                        //Atividade 11                        
                        Console.WriteLine("11) Construa um programa que receba, como entrada, três valores, armazenando-os nas variáveis A,B e C. Em seguida, o programa deve reorganizar os valores dentro dessas variáveis, de forma que o menor valor deverá ficar em A, o valor intermediário em B e o maior valor em C.Em seguida deve imprimir os conteúdos das variáveis A, B e C.");
                        Console.WriteLine("------------");
                        Console.WriteLine();

                        float A, B, C, D = 0, E = 0, F = 0;

                        Console.Write("Digite o primeiro valor: ");
                        A = float.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo valor: ");
                        B = float.Parse(Console.ReadLine());
                        Console.Write("Digite o terceiro valor: ");
                        C = float.Parse(Console.ReadLine());
                        //Quando C é o maior numero
                        if (C > A && C > B)
                        {
                            if (A > B)
                            {
                                D = A;
                                E = B;

                                A = E;
                                B = D;

                                Console.WriteLine("A = {0}\nB = {1}\nC = {2}", A, B, C);
                            }
                            else
                            {
                                Console.WriteLine("A = {0}\nB = {1}\nC = {2}", A, B, C);
                            }
                        }
                        //Qunado B é o maior numero
                        else if (B > A && B > C)
                        {
                            if (C > A)
                            {
                                E = B;
                                F = C;

                                B = F;
                                C = E;

                                Console.WriteLine("A = {0}\nB = {1}\nC = {2}", A, B, C);
                            }
                            else
                            {
                                D = A;
                                E = B;
                                F = C;

                                A = F;
                                B = D;
                                C = E;

                                Console.WriteLine("A = {0}\nB = {1}\nC = {2}", A, B, C);
                            }
                        }
                        //Quando A é maior numero
                        else
                        {
                            if (B > C)
                            {
                                D = A;
                                E = C;

                                A = E;
                                C = D;

                                Console.WriteLine("A = {0}\nB = {1}\nC = {2}", A, B, C);
                            }
                            else
                            {
                                D = A;
                                E = B;
                                F = C;

                                A = E;
                                B = F;
                                C = D;

                                Console.WriteLine("A = {0}\nB = {1}\nC = {2}", A, B, C);
                            }
                        }
                        break;

                    case 12:
                        //Atividade 12
                        Console.WriteLine("12) Desenvolva um programa que leia três números inteiros (X, Y e Z) e verifique se o número X é divisível por Y e por Z.O programa deverá apresentar uma das possíveis mensagens:\n O número é divisível por Y e por Z.\n O número é divisível por Y mas não por Z.\n O número é divisível por Z mas não por Y.\n O número não é divisível nem Y nem por Z.");
                        Console.WriteLine("------------");
                        Console.WriteLine();
                        int X, Y, Z;

                        Console.Write("Digite o valor \"X\": ");
                        X = int.Parse(Console.ReadLine());
                        Console.Write("Digite o  valor \"Y\": ");
                        Y = int.Parse(Console.ReadLine());
                        Console.Write("Digite o valor \"Z\": ");
                        Z = int.Parse(Console.ReadLine());

                        if (X % Y == 0 && X % Z == 0)
                        {
                            Console.WriteLine("O número é divisível por Y e por Z");
                        }
                        if (X % Y == 0 && X % Z != 0)
                        {
                            Console.WriteLine("O número é divisível por Y mas não por Z.");
                        }
                        if (X % Y != 0 && X % Z == 0)
                        {
                            Console.WriteLine("O número é divisível por Z mas não por Y.");
                        }
                        if (X % Y != 0 && X % Z != 0)
                        {
                            Console.WriteLine("O número não é divisível nem Y nem por Z.");
                        }
                        break;

                    case 13:
                        //Atividade 13
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

                    case 14:
                        //atividade 14
                        Console.WriteLine(" Suponha que um caixa disponha apenas de notas de R$ 1,00, R$ 10,00 e R$ 100,00. Considerando que alguém está pagando uma compra, escreva um programa que calcule o número mínimo de notas que o caixa deve fornecer como troco.Mostre na tela o valor da compra, o valor do troco e a quantidade de cada tipo de nota do troco.");
                        Console.WriteLine("------------");
                        Console.WriteLine();

                        double compra, dinheiro, subtracao, resto;

                        Console.Write("Digite a o valor da compra: ");
                        compra = double.Parse(Console.ReadLine());
                        Console.Write("Digite com quando dinheiro voce vai pagar: ");
                        dinheiro = double.Parse(Console.ReadLine());

                        subtracao = dinheiro - compra;

                        if (subtracao < 0)
                        {
                            Console.WriteLine("ERROR");
                        }
                        else
                        {
                            Console.WriteLine((int)subtracao / 100 + " Notas de R$ 100,00");
                            resto = subtracao % 100;
                            Console.WriteLine((int)resto / 10 + " Notas de R$ 10,00");
                            resto %= 10;
                            Console.WriteLine(resto / 1 + " Notas de R$ 1,00");
                        }
                        break;

                    case 15:
                        //Atividade 15
                        Console.WriteLine("15) Desenvolva um programa para calcular a conta de água para a COPASA. O custo da água varia dependendo do tipo do consumidor - residencial, comercial ou industrial.A regra para calcular a conta é:\nResidencial: R$ 0,50 por m3 gasto mais uma taxa fixa de R$ 15,00;\nComercial: R$ 500,00 para os primeiros 80 m3 gastos mais R$ 2,50 por m3 gasto acima dos 80 m3;\nIndustrial: R$ 800,00 para os primeiros 100 m3 gastos mais R$ 4,00 por m3 gasto acima dos 100 m3.\nO programa deverá ler as informações da conta do cliente: seu tipo(residencial, comercial ou industrial) e seu consumo de água em metros cúbicos.Em seguida deverá calcular e imprimir o valor a ser pago pelo consumidor.");
                        Console.WriteLine("------------");
                        Console.WriteLine();

                        int tipo;
                        double consumo;

                        Console.Write("Digite seu consumo de agua: ");
                        consumo = double.Parse(Console.ReadLine());

                        Console.WriteLine("escolha o tipo: ");
                        Console.WriteLine("1 - Residencial");
                        Console.WriteLine("2 - Comercial");
                        Console.WriteLine("3 - Industrial");
                        tipo = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        switch (tipo)
                        {
                            case 1:
                                Console.WriteLine("Residencial");
                                Console.WriteLine("Valor da conta {0}", (consumo * 0.50 + 15).ToString("c"));
                                break;
                            case 2:
                                Console.WriteLine("Comercial");
                                if (consumo <= 80)
                                {
                                    Console.WriteLine("Valor da conta {0}", 500.ToString("c"));
                                }
                                else
                                {
                                    Console.WriteLine("Valor da conta {0}", (500 + (consumo - 80) * 2.50).ToString("c"));
                                }
                                break;
                            case 3:
                                Console.WriteLine("Industrial");
                                if (consumo <= 100)
                                {
                                    Console.WriteLine("Valor da conta {0}", 800.ToString("c"));
                                }
                                else
                                {
                                    Console.WriteLine("Valor da conta {0}", (800 + (consumo - 100) * 4.0).ToString("c"));
                                }
                                break;
                        }

                        break;

                    case 16:
                        //Atividade 16
                        Console.WriteLine("16) IMC é a sigla para Índice de Massa Corpórea, parâmetro adotado pela Organização Mundial de Saúde para calcular o peso ideal de cada pessoa.O índice é calculado da seguinte maneira: divide - se o peso(em kg) da pessoa pela sua altura(em m) elevada ao quadrado.Diz - se que o indivíduo tem peso normal quando o resultado do IMC está entre 18,5 e 24,9.Escreva um programa que leia o peso e a altura da pessoa e calcule e apresente o valor do seu IMC.");
                        Console.WriteLine("------------");
                        Console.WriteLine();

                        double pesoIdeal, pesoKG, alturaM;

                        Console.Write("Digite seu peso em Kg: ");
                        pesoKG = double.Parse(Console.ReadLine());
                        Console.Write("Digite sua altura: ");
                        alturaM = Double.Parse(Console.ReadLine());

                        pesoIdeal = pesoKG / Math.Pow(alturaM, 2.0);

                        Console.WriteLine("Seu IMC: {0}", (pesoIdeal).ToString("F"));
                        break;

                    case 17:
                        //atividade 17
                        Console.WriteLine("17) Faça um programa que leia 3 números reais do teclado e que os imprima em ordem decrescente (admita que os 3 números são diferentes).");
                        Console.WriteLine("------------");
                        Console.WriteLine();

                        float numeroReal1, numeroReal2, numeroReal3;

                        Console.Write("Digite o primeiro numero: ");
                        numeroReal1 = float.Parse(Console.ReadLine());
                        Console.Write("Digite o Segundo numero: ");
                        numeroReal2 = float.Parse(Console.ReadLine());
                        Console.Write("Digite o Terceiro numero: ");
                        numeroReal3 = float.Parse(Console.ReadLine());

                        if (numeroReal1 > numeroReal2 && numeroReal1 > numeroReal3)
                        {
                            if (numeroReal2 > numeroReal3)
                            {
                                Console.WriteLine(numeroReal1);
                                Console.WriteLine(numeroReal2);
                                Console.WriteLine(numeroReal3);
                            }
                            else
                            {
                                Console.WriteLine(numeroReal1);
                                Console.WriteLine(numeroReal3);
                                Console.WriteLine(numeroReal2);
                            }
                        }
                        else if (numeroReal2 > numeroReal1 && numeroReal2 > numeroReal3)
                        {
                            if (numeroReal1 > numeroReal3)
                            {
                                Console.WriteLine(numeroReal2);
                                Console.WriteLine(numeroReal1);
                                Console.WriteLine(numeroReal3);
                            }
                            else
                            {
                                Console.WriteLine(numeroReal2);
                                Console.WriteLine(numeroReal3);
                                Console.WriteLine(numeroReal1);
                            }
                        }
                        else
                        {
                            if (numeroReal1 > numeroReal2)
                            {
                                Console.WriteLine(numeroReal3);
                                Console.WriteLine(numeroReal1);
                                Console.WriteLine(numeroReal2);
                            }
                            else
                            {
                                Console.WriteLine(numeroReal3);
                                Console.WriteLine(numeroReal2);
                                Console.WriteLine(numeroReal1);
                            }
                        }

                        break;

                    case 18:
                        //Atividade 18
                        Console.WriteLine("18) Escreva um programa para ler o número de lados de um polígono regular e a medida do lado (em cm). Calcule e imprima o seguinte:");
                        Console.WriteLine(" Se o número de lados for igual a 3 escrever TRIÂNGULO e o valor da sua área.");
                        Console.WriteLine(" Se o número de lados for igual a 4 escrever QUADRADO e o valor da sua área.");
                        Console.WriteLine(" Se o número de lados for igual a 5 escrever PENTÁGONO.");
                        Console.WriteLine("------------");
                        Console.WriteLine();

                        int quantidadesDeLados;
                        double ladosConta = 0;

                        Console.Write("Quantos Lados tem a área: ");
                        quantidadesDeLados = int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        if (quantidadesDeLados == 3)
                        {
                            Console.WriteLine("Triangulo");

                            for (int i = 1; i <= quantidadesDeLados; i++)
                            {
                                Console.Write("Lado {0} em cm: ", i);
                                ladosConta += int.Parse(Console.ReadLine());
                            }

                            Console.WriteLine();
                            Console.WriteLine("Área Do triangulo = {0}", ladosConta);
                        }
                        else if (quantidadesDeLados == 4)
                        {
                            Console.WriteLine("Quadrado");

                            for (int i = 1; i <= quantidadesDeLados; i++)
                            {
                                Console.Write("Lado {0} em cm: ", i);
                                ladosConta += int.Parse(Console.ReadLine());
                            }

                            Console.WriteLine();
                            Console.WriteLine("Área do quadrado = {0}", ladosConta);
                        }
                        else if (quantidadesDeLados == 5)
                        {
                            Console.WriteLine("PENTÁGONO");
                        }
                        else
                        {
                            Console.WriteLine("ERROR");
                        }

                        break;

                    case 19:
                        //atividade 19
                        Console.WriteLine("19) Escreva um programa que leia 5 números inteiros e mostre qual é o menor deles.");
                        Console.WriteLine("------------");
                        Console.WriteLine();

                        int menorNumero, salvarMenor = 0, key1 = 0, key2 = 0;

                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write("Digite um valor: ");
                            menorNumero = int.Parse(Console.ReadLine());
                            if (key1 == key2 || menorNumero < salvarMenor)
                            {
                                key1 = 1;
                                salvarMenor = menorNumero;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("O menor numero foi {0}", salvarMenor);
                        break;

                    case 20:
                        //Atividade 20
                        Console.WriteLine("20) Faça um programa que leia o raio de um círculo e calcule seu perímetro e sua área.");
                        Console.WriteLine("------------");
                        Console.WriteLine();

                        double raio, calculoPerimetro, calculoArea;

                        Console.Write("Digite a circunferencia do raio: ");
                        raio = double.Parse(Console.ReadLine());

                        calculoPerimetro = 2 * Math.PI * raio;
                        calculoArea = Math.PI * Math.Pow(raio, 2);

                        Console.WriteLine("Perimetro: {0}\nArea: {1}", (calculoPerimetro).ToString("F4"), (calculoArea).ToString("F4"));

                        break;
                }

                Console.WriteLine();
                Console.WriteLine("------------");
                Console.Write("Deseja continuaar no programa ou sair (s/n): ");
                continuar = char.Parse(Console.ReadLine().ToLower());
                Console.Clear();
            } while (continuar == 's');
        }
    }
}
