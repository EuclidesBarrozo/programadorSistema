using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO1
{
    public class Calculadora
    {
        //atributos ou propriedades
        public double n1;
        public double n2;
        public double resultado;
        public string operador;

        //métodos
        public double somar()
        {
            this.resultado = this.n1 + this.n2;
            return this.resultado;
        }

        public double subtrair()
        {
            this.resultado = this.n1 - this.n2;
            return this.resultado;
        }

        public double multiplicar()
        {
            this.resultado = this.n1 * this.n2;
            return this.resultado;
        }

        public double dividir()
        {
            this.resultado = this.n1 / this.n2;
            return this.resultado;
        }
    }
}
