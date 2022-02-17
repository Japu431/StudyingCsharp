using System;

namespace conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Int's
            // int idade = 12;
            // int ano;
            // ano = 2022;
            // // Constante
            // const int meiaDuzia = 6;

            // float v1 = 123123.1f;
            // double v2 = 0.123213213;
            // decimal v3 = 0.21312312321312m;

            // bool aprovado = true;
            // char a = 'a';
            // string linguagem = "C#";

            // // Casting 
            // double n1 = 32.22;
            // int n2 = (int)n1;
            // short n3 = (short)n2;

            // // Convert 

            // double number1 = 55.55;

            // int number2 = Convert.ToInt32(number1); // 56 - Arrendona para o número mais perto


            // string e1 = Console.ReadLine();
            // double nn1 = Convert.ToDouble(e1);

            // string e2 = Console.ReadLine();
            // int nn2 = Convert.ToInt32(e2);

            // ConsoleKeyInfo tecla = Console.ReadKey();
            // Console.WriteLine(tecla.KeyChar); 

            // Operadores de atribuição
            // double x = 9.4;
            // x += 5; //14.4
            // x -= 4; //10.4
            // x *= 5; //52
            // x /= 5.0; //10.4
            // x %= 5; //0.4

            // int y = 5;
            // y &= 3; // x = x & 3;
            // y |= 3; // x = x | 3;
            // y ^= 3; // x = x ^ 3;
            // y >>= 3; // x = x >> 3;
            // y <<= 3; // x = x << 3;

            // string texto = "Este é um texto qualquer.";
            // int tamanho = texto.Length;

            // string maiusculas = texto.ToUpper();
            // string minusculas = texto.ToLower();

            // int adicionaEh = texto.IndexOf("é");

            // string trecho = texto.Substring(0,4);
            // string aspas = "\"" + texto + "\"";

            // string caminho = "C:\\Temp\\Arquivo.txt";
            // string quebraDeLinha = "Fim da Linha. \n";
            // string tabulacao = "Coluna1\t Coluna2 \t Coluna3";
            // string interpolada = $"Frase: {texto}";

            int x = 5;

            if (x > 3)
            {
                Console.Write("Maior");
            }


            if (x > 3)
            {
                Console.WriteLine("Maior");
            }
            else if (x < 3)
            {
                Console.WriteLine("Menor");
            }
            else
            {
                Console.WriteLine("Igual");
            }

            if (expressaoLogica1)
            {
                if (expressaoLogica2) 
                Console.WriteLine("ExLogic 1 e 2 true");
            } else {
                Console.WriteLine("ExLogic false");
            }

            Console.WriteLine("Hello C# !");
            Console.ReadLine();
        }
    }
}
