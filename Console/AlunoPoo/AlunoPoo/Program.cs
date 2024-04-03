using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciar um objeto
            Console.WriteLine("Digite o id do aluno:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o cpf do aluno:");
            string cpf = Console.ReadLine();
            Console.WriteLine("Digite o nome do aluno:");
            string nome = Console.ReadLine();
            Aluno a1 = new Aluno(id, cpf, nome);

            //Console.WriteLine("Digite a 1a nota:");
            //a1.nota1 = Convert.ToDouble(Console.ReadLine());
            a1.digitarNota1();
            a1.digitarNota2();
            a1.digitarNota3();
            //Console.WriteLine("Digite a 2a nota:");
            //a1.nota2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite a 3a nota:");
            //a1.nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sua média é:" + 
                a1.media(a1.getNota1(), a1.getNota2(), a1.getNota3()));
        }
    }
}
