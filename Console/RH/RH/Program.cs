using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH
{
    internal class Program
    {
        static double FGTS(double salario)
        {
            return (salario * 8) / 100;
        }

        static double Ferias(double salario)
        {
            return salario + (salario / 3);
        }

        static double SalarioFamilia(double salario)
        {
            if(salario <= 1819.26)
            {
                Console.WriteLine("Digite a quantidade de dependentes:");
                int dependentes = Convert.ToInt32(Console.ReadLine());
                return dependentes * 62.04;
            }
            return 0;
        }

        static double DecimoTerceiro(double salario)
        {
            return salario / 2;
        }

        static void Main(string[] args)
        {
            string op = "";
            
            Console.WriteLine("Digite o salário:");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1.FGTS\n 2.FERIAS\n 3.SALARIO FAMÍLIA\n 4.DECIMO TERCEIRO\n 5.SAIR");
            op  = Console.ReadLine();

            Console.WriteLine("FGTS:\t" + FGTS(salario));
            Console.WriteLine("Férias:\t" + Ferias(salario));
            Console.WriteLine("Salario Família:\t" + SalarioFamilia(salario));
            Console.WriteLine("Decimo Terceiro:\t" + DecimoTerceiro(salario));
        }
    }
}
