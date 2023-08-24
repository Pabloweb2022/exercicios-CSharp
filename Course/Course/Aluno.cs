using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Aluno
    {
        public string Nome;
        public double NotaA;
        public double NotaB;
        public double NotaC;

        public double NotaFinal()
        {
            return NotaA + NotaB + NotaC;
        }

        public string Aprovacao()
        {
            if (NotaFinal() >= 60.00)
            {
                return "Aprovado";
            }
            else
            {
                return "reprovado";
            }
        }

        public override string ToString()
        {
            string result = "Nome do Aluno: " + Nome
                  + ", Nota final = " + NotaFinal() + ", Situação: " 
                  + Aprovacao();
            if(Aprovacao() == "reprovado")
            {
                result += ", Faltaram " + (60.00 - NotaFinal()) + "pontos";
            }
            return result;  
        }
    }
}
