using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string s = Console.ReadLine(); // leitura das palavras escritas + de 1

            string[] vet = s.Split(' '); // comando split pra recortar as palavras escritas, divididas pelo espaço entre elas
            string a = vet[0];
            string b = vet[1];    // cada palavras 'recortada' salva em um vetor de string
            string c = vet[2];


            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);  // saída de dados, inseridas pelo usuário
            Console.WriteLine(z);
            Console.Write(a);
            Console.Write(b);
            Console.Write(c);



        }

    }
}