using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista
{
    internal class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employe(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void NewSalary(double salary)
        {
            double porcentagem = salary * 10 / 100;
            Salary = salary + porcentagem;
        }


        public override string ToString()
        {
            return "";
        }


    }
}
