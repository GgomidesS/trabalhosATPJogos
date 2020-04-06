using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            bool vezDoJogador = false;
            byte escolhaDoJogador, escolhaDoJogadorBot;
            Random numerosAleatorios = new Random();
            char continuarJogando;

            do
            {
                //declarei a amatriz e preenchi os numeros que o usuario vai ter que digitar
                char[,] matrizJogo = new char[3, 3];
                matrizJogo[0, 0] = '7';
                matrizJogo[0, 1] = '8';
                matrizJogo[0, 2] = '9';
                matrizJogo[1, 0] = '4';
                matrizJogo[1, 1] = '5';
                matrizJogo[1, 2] = '6';
                matrizJogo[2, 0] = '1';
                matrizJogo[2, 1] = '2';
                matrizJogo[2, 2] = '3';
                bool[,] matrizBool = new bool[3, 3];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        matrizBool[i, j] = false;
                    }
                }

                //escolhe jogar com bot ou amigo
                Console.WriteLine("1 - jogar com bot\n2 - jogar com amigo");
                byte botOuAmigo = byte.Parse(Console.ReadLine());
                while (botOuAmigo != 1 && botOuAmigo != 2)
                {
                    Console.WriteLine("Numero invalido. Digite 1 ou 2");
                    botOuAmigo = byte.Parse(Console.ReadLine());
                }
                Console.Clear();

                do
                {

                    //printa a matriz na tala
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(" {0} ", matrizJogo[i, j]);
                            if (j < 2)
                            {
                                Console.Write('|');
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("----------");
                    }

                    //condiçoes de vitoiras X
                    if (matrizJogo[0, 0] == 'X' && matrizJogo[0, 1] == 'X' && matrizJogo[0, 2] == 'X')
                    {
                        Console.WriteLine("Jogador X gamhou");
                        break;
                    }
                    if (matrizJogo[1, 0] == 'X' && matrizJogo[1, 1] == 'X' && matrizJogo[1, 2] == 'X')
                    {
                        Console.WriteLine("Jogador X gamhou");
                        break;
                    }
                    if (matrizJogo[2, 0] == 'X' && matrizJogo[2, 1] == 'X' && matrizJogo[2, 2] == 'X')
                    {
                        Console.WriteLine("Jogador X gamhou");
                        break;
                    }
                    if (matrizJogo[0, 0] == 'X' && matrizJogo[1, 0] == 'X' && matrizJogo[2, 0] == 'X')
                    {
                        Console.WriteLine("Jogador X gamhou");
                        break;
                    }
                    if (matrizJogo[0, 1] == 'X' && matrizJogo[1, 1] == 'X' && matrizJogo[2, 1] == 'X')
                    {
                        Console.WriteLine("Jogador X gamhou");
                        break;
                    }
                    if (matrizJogo[0, 2] == 'X' && matrizJogo[1, 2] == 'X' && matrizJogo[2, 2] == 'X')
                    {
                        Console.WriteLine("Jogador X gamhou");
                        break;
                    }
                    if (matrizJogo[0, 0] == 'X' && matrizJogo[1, 1] == 'X' && matrizJogo[2, 2] == 'X')
                    {
                        Console.WriteLine("Jogador X gamhou");
                        break;
                    }
                    if (matrizJogo[0, 2] == 'X' && matrizJogo[1, 1] == 'X' && matrizJogo[2, 0] == 'X')
                    {
                        Console.WriteLine("Jogador X gamhou");
                        break;
                    }

                    //condiçoes de vitoiras O
                    if (matrizJogo[0, 0] == 'O' && matrizJogo[0, 1] == 'O' && matrizJogo[0, 2] == 'O')
                    {
                        Console.WriteLine("Jogador O gamhou");
                        break;
                    }
                    if (matrizJogo[1, 0] == 'O' && matrizJogo[1, 1] == 'O' && matrizJogo[1, 2] == 'O')
                    {
                        Console.WriteLine("Jogador O gamhou");
                        break;
                    }
                    if (matrizJogo[2, 0] == 'O' && matrizJogo[2, 1] == 'O' && matrizJogo[2, 2] == 'O')
                    {
                        Console.WriteLine("Jogador O gamhou");
                        break;
                    }
                    if (matrizJogo[0, 0] == 'O' && matrizJogo[1, 0] == 'O' && matrizJogo[2, 0] == 'O')
                    {
                        Console.WriteLine("Jogador O gamhou");
                        break;
                    }
                    if (matrizJogo[0, 1] == 'O' && matrizJogo[1, 1] == 'O' && matrizJogo[2, 1] == 'O')
                    {
                        Console.WriteLine("Jogador O gamhou");
                        break;
                    }
                    if (matrizJogo[0, 2] == 'O' && matrizJogo[1, 2] == 'O' && matrizJogo[2, 2] == 'O')
                    {
                        Console.WriteLine("Jogador O gamhou");
                        break;
                    }
                    if (matrizJogo[0, 0] == 'O' && matrizJogo[1, 1] == 'O' && matrizJogo[2, 2] == 'O')
                    {
                        Console.WriteLine("Jogador O gamhou");
                        break;
                    }
                    if (matrizJogo[0, 2] == 'O' && matrizJogo[1, 1] == 'O' && matrizJogo[2, 0] == 'O')
                    {
                        Console.WriteLine("Jogador O gamhou");
                        break;
                    }

                    //empate
                    int cont = 0;
                    foreach (bool m in matrizBool)
                    {
                        if (m == true)
                        {
                            cont++;
                        }
                    }
                    if (cont == 9)
                    {
                        Console.WriteLine("Velha");
                        break;
                    }

                    //jogadores
                    if (vezDoJogador == false)
                    {
                        //jogador 1
                        //jogador X diz onde quer jogar na matriz
                        Console.Write("Vez do jogador X: ");
                        escolhaDoJogador = byte.Parse(Console.ReadLine());
                        while (escolhaDoJogador < 0 || escolhaDoJogador > 9)
                        {
                            Console.WriteLine("Numero invalido. Digite outro.");
                            escolhaDoJogador = byte.Parse(Console.ReadLine());
                        }

                        //verifica se ja o lugar onde digitou ja foi jogado anteriromente
                        bool verificacao;
                        do
                        {

                            verificacao = false;
                            switch (escolhaDoJogador)
                            {
                                case 9:
                                    if (matrizBool[0, 2] == true)
                                    {
                                        Console.Write("Opção invalida.\nDigite outra: ");
                                        escolhaDoJogador = byte.Parse(Console.ReadLine());
                                    }
                                    else
                                    {
                                        verificacao = true;
                                    }
                                    break;
                                case 8:
                                    if (matrizBool[0, 1] == true)
                                    {
                                        Console.Write("Opção invalida.\nDigite outra: ");
                                        escolhaDoJogador = byte.Parse(Console.ReadLine());
                                    }
                                    else
                                    {
                                        verificacao = true;
                                    }
                                    break;
                                case 7:
                                    if (matrizBool[0, 0] == true)
                                    {
                                        Console.Write("Opção invalida.\nDigite outra: ");
                                        escolhaDoJogador = byte.Parse(Console.ReadLine());
                                    }
                                    else
                                    {
                                        verificacao = true;
                                    }
                                    break;
                                case 6:
                                    if (matrizBool[1, 2] == true)
                                    {
                                        Console.Write("Opção invalida.\nDigite outra: ");
                                        escolhaDoJogador = byte.Parse(Console.ReadLine());
                                    }
                                    else
                                    {
                                        verificacao = true;
                                    }
                                    break;
                                case 5:
                                    if (matrizBool[1, 1] == true)
                                    {
                                        Console.Write("Opção invalida.\nDigite outra: ");
                                        escolhaDoJogador = byte.Parse(Console.ReadLine());
                                    }
                                    else
                                    {
                                        verificacao = true;
                                    }
                                    break;
                                case 4:
                                    if (matrizBool[1, 0] == true)
                                    {
                                        Console.Write("Opção invalida.\nDigite outra: ");
                                        escolhaDoJogador = byte.Parse(Console.ReadLine());
                                    }
                                    else
                                    {
                                        verificacao = true;
                                    }
                                    break;
                                case 3:
                                    if (matrizBool[2, 2] == true)
                                    {
                                        Console.Write("Opção invalida.\nDigite outra: ");
                                        escolhaDoJogador = byte.Parse(Console.ReadLine());
                                    }
                                    else
                                    {
                                        verificacao = true;
                                    }
                                    break;
                                case 2:
                                    if (matrizBool[2, 1] == true)
                                    {
                                        Console.Write("Opção invalida.\nDigite outra: ");
                                        escolhaDoJogador = byte.Parse(Console.ReadLine());
                                    }
                                    else
                                    {
                                        verificacao = true;
                                    }
                                    break;
                                case 1:
                                    if (matrizBool[2, 0] == true)
                                    {
                                        Console.Write("Opção invalida.\nDigite outra: ");
                                        escolhaDoJogador = byte.Parse(Console.ReadLine());
                                    }
                                    else
                                    {
                                        verificacao = true;
                                    }
                                    break;
                            }
                        } while (verificacao != true);

                        //preenche a matriz com os x
                        switch (escolhaDoJogador)
                        {
                            case 9:
                                matrizJogo[0, 2] = 'X';
                                matrizBool[0, 2] = true;
                                break;
                            case 8:
                                matrizJogo[0, 1] = 'X';
                                matrizBool[0, 1] = true;
                                break;
                            case 7:
                                matrizJogo[0, 0] = 'X';
                                matrizBool[0, 0] = true;
                                break;
                            case 6:
                                matrizJogo[1, 2] = 'X';
                                matrizBool[1, 2] = true;
                                break;
                            case 5:
                                matrizJogo[1, 1] = 'X';
                                matrizBool[1, 1] = true;
                                break;
                            case 4:
                                matrizJogo[1, 0] = 'X';
                                matrizBool[1, 0] = true;
                                break;
                            case 3:
                                matrizJogo[2, 2] = 'X';
                                matrizBool[2, 2] = true;
                                break;
                            case 2:
                                matrizJogo[2, 1] = 'X';
                                matrizBool[2, 1] = true;
                                break;
                            case 1:
                                matrizJogo[2, 0] = 'X';
                                matrizBool[2, 0] = true;
                                break;
                        }
                        vezDoJogador = true;
                    }

                    else
                    {
                        //bot
                        if (botOuAmigo == 1)
                        {
                            //bot escolhe onde jogar
                            escolhaDoJogadorBot = (byte)numerosAleatorios.Next(1, 10);

                            //verifica se ja tem X ou O onde o bot queria jogar
                            bool verificacao;
                            do
                            {
                                verificacao = false;
                                switch (escolhaDoJogadorBot)
                                {
                                    case 9:
                                        if (matrizBool[0, 2] == true)
                                        {
                                            escolhaDoJogadorBot = (byte)numerosAleatorios.Next(1, 10);
                                        }
                                        else
                                        {
                                            verificacao = true;
                                        }
                                        break;
                                    case 8:
                                        if (matrizBool[0, 1] == true)
                                        {
                                            escolhaDoJogadorBot = (byte)numerosAleatorios.Next(1, 10);
                                        }
                                        else
                                        {
                                            verificacao = true;
                                        }
                                        break;
                                    case 7:
                                        if (matrizBool[0, 0] == true)
                                        {
                                            escolhaDoJogadorBot = (byte)numerosAleatorios.Next(1, 10);
                                        }
                                        else
                                        {
                                            verificacao = true;
                                        }
                                        break;
                                    case 6:
                                        if (matrizBool[1, 2] == true)
                                        {
                                            escolhaDoJogadorBot = (byte)numerosAleatorios.Next(1, 10);
                                        }
                                        else
                                        {
                                            verificacao = true;
                                        }
                                        break;
                                    case 5:
                                        if (matrizBool[1, 1] == true)
                                        {
                                            escolhaDoJogadorBot = (byte)numerosAleatorios.Next(1, 10);
                                        }
                                        else
                                        {
                                            verificacao = true;
                                        }
                                        break;
                                    case 4:
                                        if (matrizBool[1, 0] == true)
                                        {
                                            escolhaDoJogadorBot = (byte)numerosAleatorios.Next(1, 10);
                                        }
                                        else
                                        {
                                            verificacao = true;
                                        }
                                        break;
                                    case 3:
                                        if (matrizBool[2, 2] == true)
                                        {
                                            escolhaDoJogadorBot = (byte)numerosAleatorios.Next(1, 10);
                                        }
                                        else
                                        {
                                            verificacao = true;
                                        }
                                        break;
                                    case 2:
                                        if (matrizBool[2, 1] == true)
                                        {
                                            escolhaDoJogadorBot = (byte)numerosAleatorios.Next(1, 10);
                                        }
                                        else
                                        {
                                            verificacao = true;
                                        }
                                        break;
                                    case 1:
                                        if (matrizBool[2, 0] == true)
                                        {
                                            escolhaDoJogadorBot = (byte)numerosAleatorios.Next(1, 10);
                                        }
                                        else
                                        {
                                            verificacao = true;
                                        }
                                        break;
                                }
                            } while (verificacao != true);

                            //preenche com O onde o bot escolheu
                            switch (escolhaDoJogadorBot)
                            {
                                case 9:
                                    matrizJogo[0, 2] = 'O';
                                    matrizBool[0, 2] = true;
                                    break;
                                case 8:
                                    matrizJogo[0, 1] = 'O';
                                    matrizBool[0, 1] = true;
                                    break;
                                case 7:
                                    matrizJogo[0, 0] = 'O';
                                    matrizBool[0, 0] = true;
                                    break;
                                case 6:
                                    matrizJogo[1, 2] = 'O';
                                    matrizBool[1, 2] = true;
                                    break;
                                case 5:
                                    matrizJogo[1, 1] = 'O';
                                    matrizBool[1, 1] = true;
                                    break;
                                case 4:
                                    matrizJogo[1, 0] = 'O';
                                    matrizBool[1, 0] = true;
                                    break;
                                case 3:
                                    matrizJogo[2, 2] = 'O';
                                    matrizBool[2, 2] = true;
                                    break;
                                case 2:
                                    matrizJogo[2, 1] = 'O';
                                    matrizBool[2, 1] = true;
                                    break;
                                case 1:
                                    matrizJogo[2, 0] = 'O';
                                    matrizBool[2, 0] = true;
                                    break;
                            }

                            vezDoJogador = false;
                        }
                        //jogador 2
                        else if (botOuAmigo == 2)
                        {
                            if (vezDoJogador == true)
                            {

                                //jogador X diz onde quer jogar na matriz
                                Console.Write("Vez do jogador O: ");
                                escolhaDoJogador = byte.Parse(Console.ReadLine());
                                while (escolhaDoJogador < 0 || escolhaDoJogador > 9)
                                {
                                    Console.WriteLine("Numero invalido. Digite outro.");
                                    escolhaDoJogador = byte.Parse(Console.ReadLine());
                                }

                                //verifica se ja o lugar onde digitou ja foi jogado anteriromente
                                bool verificacao;
                                do
                                {

                                    verificacao = false;
                                    switch (escolhaDoJogador)
                                    {
                                        case 9:
                                            if (matrizBool[0, 2] == true)
                                            {
                                                Console.Write("Opção invalida.\nDigite outra: ");
                                                escolhaDoJogador = byte.Parse(Console.ReadLine());
                                            }
                                            else
                                            {
                                                verificacao = true;
                                            }
                                            break;
                                        case 8:
                                            if (matrizBool[0, 1] == true)
                                            {
                                                Console.Write("Opção invalida.\nDigite outra: ");
                                                escolhaDoJogador = byte.Parse(Console.ReadLine());
                                            }
                                            else
                                            {
                                                verificacao = true;
                                            }
                                            break;
                                        case 7:
                                            if (matrizBool[0, 0] == true)
                                            {
                                                Console.Write("Opção invalida.\nDigite outra: ");
                                                escolhaDoJogador = byte.Parse(Console.ReadLine());
                                            }
                                            else
                                            {
                                                verificacao = true;
                                            }
                                            break;
                                        case 6:
                                            if (matrizBool[1, 2] == true)
                                            {
                                                Console.Write("Opção invalida.\nDigite outra: ");
                                                escolhaDoJogador = byte.Parse(Console.ReadLine());
                                            }
                                            else
                                            {
                                                verificacao = true;
                                            }
                                            break;
                                        case 5:
                                            if (matrizBool[1, 1] == true)
                                            {
                                                Console.Write("Opção invalida.\nDigite outra: ");
                                                escolhaDoJogador = byte.Parse(Console.ReadLine());
                                            }
                                            else
                                            {
                                                verificacao = true;
                                            }
                                            break;
                                        case 4:
                                            if (matrizBool[1, 0] == true)
                                            {
                                                Console.Write("Opção invalida.\nDigite outra: ");
                                                escolhaDoJogador = byte.Parse(Console.ReadLine());
                                            }
                                            else
                                            {
                                                verificacao = true;
                                            }
                                            break;
                                        case 3:
                                            if (matrizBool[2, 2] == true)
                                            {
                                                Console.Write("Opção invalida.\nDigite outra: ");
                                                escolhaDoJogador = byte.Parse(Console.ReadLine());
                                            }
                                            else
                                            {
                                                verificacao = true;
                                            }
                                            break;
                                        case 2:
                                            if (matrizBool[2, 1] == true)
                                            {
                                                Console.Write("Opção invalida.\nDigite outra: ");
                                                escolhaDoJogador = byte.Parse(Console.ReadLine());
                                            }
                                            else
                                            {
                                                verificacao = true;
                                            }
                                            break;
                                        case 1:
                                            if (matrizBool[2, 0] == true)
                                            {
                                                Console.Write("Opção invalida.\nDigite outra: ");
                                                escolhaDoJogador = byte.Parse(Console.ReadLine());
                                            }
                                            else
                                            {
                                                verificacao = true;
                                            }
                                            break;
                                    }
                                } while (verificacao != true);

                                //preenche a matriz com os O
                                switch (escolhaDoJogador)
                                {
                                    case 9:
                                        matrizJogo[0, 2] = 'O';
                                        matrizBool[0, 2] = true;
                                        break;
                                    case 8:
                                        matrizJogo[0, 1] = 'O';
                                        matrizBool[0, 1] = true;
                                        break;
                                    case 7:
                                        matrizJogo[0, 0] = 'O';
                                        matrizBool[0, 0] = true;
                                        break;
                                    case 6:
                                        matrizJogo[1, 2] = 'O';
                                        matrizBool[1, 2] = true;
                                        break;
                                    case 5:
                                        matrizJogo[1, 1] = 'O';
                                        matrizBool[1, 1] = true;
                                        break;
                                    case 4:
                                        matrizJogo[1, 0] = 'O';
                                        matrizBool[1, 0] = true;
                                        break;
                                    case 3:
                                        matrizJogo[2, 2] = 'O';
                                        matrizBool[2, 2] = true;
                                        break;
                                    case 2:
                                        matrizJogo[2, 1] = 'O';
                                        matrizBool[2, 1] = true;
                                        break;
                                    case 1:
                                        matrizJogo[2, 0] = 'O';
                                        matrizBool[2, 0] = true;
                                        break;
                                }
                                vezDoJogador = false;
                            }
                        }
                    }
                    Console.Clear();
                } while (0 != 1);

                //ve se quer jogar novamente
                Console.WriteLine();
                Console.Write("Deseja jogar novamente(s/n): ");
                continuarJogando = char.Parse(Console.ReadLine().ToLower());
                Console.Clear();
            } while (continuarJogando == 's');
            Console.ReadKey();
        }
    }
}
