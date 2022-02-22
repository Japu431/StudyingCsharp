// using System;

// namespace conceitos
// {
//     enum Semaforo
//     {
//         Vermelho, Amarelo, Verde
//     }
//     class Sintaxes {
//           // Int's
//             int idade = 12;
//             int ano;
//             ano = 2022;
//             // Constante
//             const int meiaDuzia = 6;

//             float v1 = 123123.1f;
//             double v2 = 0.123213213;
//             decimal v3 = 0.21312312321312m;

//             bool aprovado = true;
//             char a = 'a';
//             string linguagem = "C#";

//             // Casting 
//             double n1 = 32.22;
//             int n2 = (int)n1;
//             short n3 = (short)n2;

//             // Convert 

//             double number1 = 55.55;

//             int number2 = Convert.ToInt32(number1); // 56 - Arrendona para o número mais perto


//             string e1 = Console.ReadLine();
//             double nn1 = Convert.ToDouble(e1);

//             string e2 = Console.ReadLine();
//             int nn2 = Convert.ToInt32(e2);

//             ConsoleKeyInfo tecla = Console.ReadKey();
//             Console.WriteLine(tecla.KeyChar);

//             // Operadores de atribuição
//             double x = 9.4;
//             x += 5; //14.4
//             x -= 4; //10.4
//             x *= 5; //52
//             x /= 5.0; //10.4
//             x %= 5; //0.4

//             int y = 5;
//             y &= 3; // x = x & 3;
//             y |= 3; // x = x | 3;
//             y ^= 3; // x = x ^ 3;
//             y >>= 3; // x = x >> 3;
//             y <<= 3; // x = x << 3;

//             string texto = "Este é um texto qualquer.";
//             int tamanho = texto.Length;

//             string maiusculas = texto.ToUpper();
//             string minusculas = texto.ToLower();

//             int adicionaEh = texto.IndexOf("é");

//             string trecho = texto.Substring(0, 4);
//             string aspas = "\"" + texto + "\"";

//             string caminho = "C:\\Temp\\Arquivo.txt";
//             string quebraDeLinha = "Fim da Linha. \n";
//             string tabulacao = "Coluna1\t Coluna2 \t Coluna3";
//             string interpolada = $"Frase: {texto}";

//             int x = 5;

//             if (x > 3)
//             {
//                 Console.Write("Maior");
//             }


//             if (x > 3)
//             {
//                 Console.WriteLine("Maior");
//             }
//             else if (x < 3)
//             {
//                 Console.WriteLine("Menor");
//             }
//             else
//             {
//                 Console.WriteLine("Igual");
//             }

//             if (expressaoLogica1)
//             {
//                 if (expressaoLogica2)
//                     Console.WriteLine("ExLogic 1 e 2 true");
//             }
//             else
//             {
//                 Console.WriteLine("ExLogic false");
//             }

//             Random randNum = new Random();
//             int diaDaSemana = randNum.Next(1, 8);


//             switch (diaDaSemana)
//             {
//                 case 1:
//                     Console.WriteLine("Domingo");
//                     break;

//                 case 2:
//                     Console.WriteLine("Segunda");
//                     break;

//                 case 3:
//                     Console.WriteLine("Terça");
//                     break;


//                 case 4:
//                     Console.WriteLine("Quarta");
//                     break;


//                 case 5:
//                     Console.WriteLine("Quinta");
//                     break;


//                 case 6:
//                     Console.WriteLine("Sexta");
//                     break;

//                 case 7:
//                     Console.WriteLine("Sabado");
//                     break;

//                 default:
//                     Console.WriteLine("Inválida");
//                     break;
//             }

//             int x = 0;
//             while (x <= 3)
//             {
//                 Console.WriteLine($"x menor q 3 => x: {x}");
//                 x++;
//             }

//             do
//             {
//                 Console.WriteLine($"x menor q 3 => x: {x}");
//                 x++;
//             } while (x <= 3);

//             for (int i = 0; i < 10; i++)
//             {
//                 Console.WriteLine(i);
//             }

//             string[] tags = { "C#", ".net", "vscode" };

//             foreach (string tag in tags)
//             {
//                 Console.WriteLine(tag);
//             }

//             for (int i = 0; i <= 10; i++)
//             {
//                 if (i == 5)
//                     break;
//                 Console.WriteLine(i); // 1,2,3,4
//             }


//             for (int i = 0; i <= 10; i++)
//             {
//                 if (i == 5)
//                     continue;
//                 Console.WriteLine(i); // 1,2,3,4,6,7,8,9,10
//             }

//             int[] primos = { 2, 3, 5, 7, 11, 13, 17, 19 };

//             string[] tags = { "C#", ".net", "vscode", "js" };
//             string[] tags2 = new string[] { "C#", ".net", "vscode", "js" };
//             string[] tags3 = new string[4] { "C#", ".net", "vscode", "js" };
//             string[] tags4 = new string[4];

//             tags4 = new string[] { "C#", ".net", "vscode", "js" };
//             tags4 = new string[4] { "C#", ".net", "vscode", "js" };



//             // # Acessar elementos

//             // no debug console o ".net" será imprimido 5 vezes pois ele faz uma repetição tags.Length(valor todo array) e imprime tag[1] = ".net"  
//             for (int i = 0; i < tags.Length; i++)
//             {
//                 Console.WriteLine(tags[1]);
//             }
//             foreach (string tag in tags)
//             {
//                 Console.WriteLine(tag);
//             }

//             Array.Sort(tags);
//             // // using System.LINQ;
//             Console.WriteLine(primos.Max()); // Maior elemento
//             Console.WriteLine(primos.Min()); //Menor Elemento
//             Console.WriteLine(primos.Sum()); // Soma dos vetores
//             Console.WriteLine(primos.Average()); // Media Aritmética
//             Console.WriteLine(primos.Count()); // Quantidade de Elementos


//             Semaforo s1 = Semaforo.Verde;

//             foreach (Semaforo item in Enum.GetValues(typeof(Semaforo)))
//             {
//                 Console.WriteLine((int)item);
//             }

//     }    
// }