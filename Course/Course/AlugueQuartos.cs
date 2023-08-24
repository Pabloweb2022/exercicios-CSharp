using System;
using System.Globalization;

namespace Course
{
    internal class AlugueQuartos
    {
        public string Nome;
        public string Email;
        public int Quarto;
        public AlugueQuartos(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        Console.Write("Quantos quartos serão alugados?: ");

            int quantidade = int.Parse(Console.ReadLine());

        AlugueQuartos[] array = new AlugueQuartos[9];

            for (int a = 0; a<quantidade; a++)
            {
                Console.Write("Digite seu nome: ");
                string nome = Console.ReadLine();

        Console.Write("digite seu email: ");
                string email = Console.ReadLine();

        Console.Write("Numero do quarto: ");
                int quarto = int.Parse(Console.ReadLine());

        array[quarto] = new AlugueQuartos(nome, email);

    }

            for (int i = 0; i<array.Length; i++)
            {
                if (array[i] != null)

                {
                    Console.WriteLine("Numero do quarto Alugado: " + i);
                    Console.WriteLine("Nome: " + array[i].Nome);
                    Console.WriteLine("Email: " + array[i].Email);
                }
            }



    }
}
