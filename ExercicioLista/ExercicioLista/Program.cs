using System;
using System.Collections.Generic;
using System.Globalization;
namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Olá, ");

            List<Employe> funcionarios = new List<Employe>();
   
            Console.Write("Quantos funcionarios vc deseja registrar  ?");

            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Funcionario " + (i + 1));
                Console.Write("Digite o id do fucionário: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Digite o nome do fucionário: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o salário do funcionário: ");
                double salary = double.Parse(Console.ReadLine());

                funcionarios.Add(new Employe(id, nome, salary));
            }

            foreach (Employe funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Name + " " + " " + funcionario.Salary);
            }

            Console.Write("Entre com o id do funcionario que vc quer dar o almento de salario: ");
            int idAlmento = int.Parse(Console.ReadLine());

            Employe emp = funcionarios.Find(x => x.Id == idAlmento);

            if (emp != null)
            {
                emp.NewSalary(emp.Salary);
            }
            else
            {
                Console.WriteLine("ID nao existe!");
            }

            foreach (Employe funcionario in funcionarios)
            {

                Console.WriteLine(funcionario.Name + " " + " " + funcionario.Salary);
            }


        }
    }
}
