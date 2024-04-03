using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoPoo
{
    public class Aluno
    {
        private string nome;
        private int id;
        private DateTime dataNasc;
        private string turma;
        private string cpf;
        private double nota1;
        private double nota2;
        private double nota3;

        //CONSTRUTOR (id, cpf, nome)
        public Aluno(int id, string cpf, string nome)
        {
            setId(id);
            setCPF(cpf);
            setNome(nome);
        }
        //metodos get e set dos atributos
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }

        public void setDataNasc(DateTime dataNasc)
        {
            this.dataNasc = dataNasc;
        }
        public DateTime getDataNasc() 
        {
            return this.dataNasc;        
        }

        public void setTurma(string turma)
        {
            this.turma = turma;
        }
        public string getTurma()
        {
            return this.turma;
        }

        public void setCPF(string cpf)
        {
            this.cpf = cpf;
        }
        public string getCPF()
        {
            return this.cpf;
        }

        public void setNota1(double nota1)
        {
            this.nota1 = nota1;
        }
        public double getNota1()
        {
            return this.nota1;
        }

        public void setNota2(double nota2)
        {
            this.nota2 = nota2;
        }
        public double getNota2()
        {
            return this.nota2;
        }

        public void setNota3(double nota3)
        {
            this.nota3 = nota3;
        }
        public double getNota3()
        {
            return this.nota3;
        }

        public void digitarNota1()
        {
            double nota;
            do
            {
                Console.WriteLine("Digite a 1a nota:");
                nota = Convert.ToDouble(Console.ReadLine());
            } while (nota < 0 || nota > 10);
            setNota1(nota);
        }

        public void digitarNota2()
        {
            double nota;
            do
            {
                Console.WriteLine("Digite a 2a nota:");
                nota = Convert.ToDouble(Console.ReadLine());
            } while (nota < 0 || nota > 10);
            setNota2(nota);
        }

        public void digitarNota3()
        {
            double nota;
            do
            {
                Console.WriteLine("Digite a 3a nota:");
                nota = Convert.ToDouble(Console.ReadLine());
            } while (nota < 0 || nota > 10);
            setNota3(nota);
        }
        public double media(double n1, double n2, double n3)
        {
            this.nota1 = n1;
            this.nota2 = n2;
            this.nota3 = n3;
            return (this.nota1 + this.nota2 + this.nota3)/3;
        }
    }
}
