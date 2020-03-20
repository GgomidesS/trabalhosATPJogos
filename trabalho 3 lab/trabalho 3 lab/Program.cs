using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_3_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            char opçaoContinuar;
            int numeroAtividade;

            do
            {
                Console.Write("Escolha o numero da atividade: ");
                numeroAtividade = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (numeroAtividade)
                {
                    case 1:
                        //Atividade 1
                        int[] vetor = new int[9];
                        int indice, contador;

                        Console.write
                        break;
                    case 2:
                        //Atividade 2
                        byte idade_, candidatosFemininos = 0, candidatosMasculinos = 0, homensIdadeMaior35 = 0, homensComExperiencia = 0, somaIdadeHomensExperiencia = 0,
                            homensEntre40e55 = 0, mulheresMenor30SemEsperiencia = 0, menoridadeMulherEsperiencia = 255;
                        char sexo, experiencia;

                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write("Digite sua idade: ");
                            idade_ = byte.Parse(Console.ReadLine());
                            Console.Write("Digite seu sexo(F/M): ");
                            sexo = char.Parse(Console.ReadLine().ToUpper()); ;
                            Console.Write("Digite se tem  experiência no serviço(S/N): ");
                            experiencia = char.Parse(Console.ReadLine().ToUpper());

                            if (sexo == 'F')
                            {
                                candidatosFemininos++;
                            }
                            else
                            {
                                candidatosMasculinos++;
                            }
                            if (sexo == 'M' && idade_ > 35)
                            {
                                homensIdadeMaior35++;
                            }
                            if(sexo == 'M' && experiencia == 'S')
                            {
                                somaIdadeHomensExperiencia += idade_; 
                                homensComExperiencia++;
                            }
                            if (sexo == 'M' && idade_ > 40 && idade_ < 55)
                            {
                                homensEntre40e55++; 
                            }
                            if (sexo == 'F' && idade_ < 30 && experiencia == 'N')
                            {
                                mulheresMenor30SemEsperiencia++;
                            }
                            if (sexo == 'F' && experiencia == 'S' && idade_ < menoridadeMulherEsperiencia)
                            {
                                menoridadeMulherEsperiencia = idade_;
                            }
                            Console.Clear();
                        }
                        Console.WriteLine("Candidatas femininas: {0}", candidatosFemininos);
                        Console.WriteLine("número de candidatos do sexo masculino maiores de 35 anos: {0}", homensIdadeMaior35);
                        Console.WriteLine("idade média dos homens que já têm experiência no serviço: {0}", somaIdadeHomensExperiencia / homensComExperiencia);
                        Console.WriteLine("porcentagem dos homens com mais de 40 anos e menos de 55 entre o total dos homens: {0}", homensEntre40e55 * 100 / candidatosMasculinos);
                        Console.WriteLine("número de mulheres com idade inferior a 30 anos e sem experiência no serviço: {0}", mulheresMenor30SemEsperiencia);
                        Console.WriteLine("menor idade entre as mulheres que já têm experiência no serviço: {0}", menoridadeMulherEsperiencia);

                        break;
                    case 3:
                        //Atividade 3
                        uint[] vetor1 = new uint[10];
                        uint[] vetor2 = new uint[10];
                        uint[] vetor3 = new uint[20];

                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("Digite o 10 primeiros numeros separados por \" \"(espaço)");
                            vetor1[i] = uint.Parse(Console.ReadLine());
                            Console.Clear();
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("Digite o 10 segundos numeros separados por \" \"(espaço)");
                            vetor2[i] = uint.Parse(Console.ReadLine());
                            Console.Clear();
                        }

                        vetor3[0] = vetor1[0];
                        vetor3[1] = vetor1[1];
                        vetor3[2] = vetor1[2];
                        vetor3[3] = vetor1[3];
                        vetor3[4] = vetor1[4];
                        vetor3[5] = vetor1[5];
                        vetor3[6] = vetor1[6];
                        vetor3[7] = vetor1[7];
                        vetor3[8] = vetor1[8];
                        vetor3[9] = vetor1[9];
                        vetor3[10] = vetor2[0];
                        vetor3[11] = vetor2[1];
                        vetor3[12] = vetor2[2];
                        vetor3[13] = vetor2[3];
                        vetor3[14] = vetor2[4];
                        vetor3[15] = vetor2[5];
                        vetor3[16] = vetor2[6];
                        vetor3[17] = vetor2[7];
                        vetor3[18] = vetor2[8];
                        vetor3[19] = vetor2[9];

                        for(int i = 0; i < 20; i++)
                        {
                            Console.WriteLine(vetor3[i]);
                        }
                        break;
                    case 4:
                        //Atividade 4
                        string palavra_, palavras2;
                        char[] vetorc1;

                        Console.WriteLine("Digite a palavra: ");
                        palavra_ = Console.ReadLine();

                        vetorc1 = palavra_.ToCharArray(); //transformei em um vetor de char

                        Array.Reverse(vetorc1); // inverti o vetor

                        palavras2 = new string(vetorc1); //salvei o vetor em outra string

                        if (palavra_ == palavras2) // comparei elas
                        {
                            Console.Write("palíndromo");
                        }
                        else
                        {
                            Console.WriteLine("não palíndromo");
                        }

                        break;
                    case 5:
                        //Atividade 5
                        char[] vetorC;
                        char letra;
                        string palavra;
                        int contador = 0;

                        Console.Write("Digite palavra: ");
                        palavra = Console.ReadLine().ToLower();
                        Console.Write("Digite a letra: ");
                        letra = char.Parse(Console.ReadLine().ToLower());

                        vetorC = palavra.ToCharArray();

                        for (int i = 0; i < palavra.Length; i++)
                        {
                            if (vetorC[i] == letra)
                            {
                                contador++;
                            }
                        }
                        Console.WriteLine("Existem {0} letra {1} na palavra {2}", contador, letra, palavra);
                        break;
                    case 6:
                        //Atividade 6
                        string s1, s2;
                        Console.Write("Digite a string s1: ");
                        s1 = Console.ReadLine();
                        Console.Write("Digite a string s2: ");
                        s2 = s1 + Console.ReadLine();

                        Console.WriteLine(s2);

                        break;
                    case 7:
                        //Atividade 7
                        string numeroEmString;
                        char[] vetorChar;

                        Console.Write("Digite o numero: ");
                        numeroEmString = Console.ReadLine();

                        vetorChar = numeroEmString.ToCharArray();

                        for (int i = numeroEmString.Length; i > 0; i--)
                        {
                            Console.Write(vetorChar[i - 1]);
                        }
                        break;
                    case 8:
                        //Atividade 8
                        int idadeMaisVelha = 0, idade;
                        float idadeMedia = 0, porcentagem30e45 = 0;

                        for (int i = 1; i <= 20; i++)
                        {
                            Console.Write("Digite a idade da {0}º pessoa: ", i);
                            idade = int.Parse(Console.ReadLine());

                            if (idade > idadeMaisVelha)
                            {
                                idadeMaisVelha = idade;
                            }

                            idadeMedia += idade;

                            if (30 <= idade && idade <= 45)
                            {
                                porcentagem30e45++;
                            }
                            Console.Clear();
                        }
                        Console.WriteLine("Idade Mais Velha: {0}", idadeMaisVelha);
                        Console.WriteLine("Media das Idades: {0}", idadeMedia / 20);
                        Console.WriteLine("Porcentagem de pessoas com idadeentre 30 e 45: {0}%", porcentagem30e45 * 100 / 20);
                        break;
                }

                Console.WriteLine();
                Console.Write("Deseja continuar(s/n)");
                opçaoContinuar = char.Parse(Console.ReadLine().ToLower());
                Console.Clear();
            } while (opçaoContinuar == 's');
        }
    }
}
