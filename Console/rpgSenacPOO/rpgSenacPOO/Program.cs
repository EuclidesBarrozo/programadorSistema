using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgSenacPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador(1, 10, 5, 3);
            Jogador j2 = new Jogador(2, 6, 4, 4);

            while (j1.getVida() > 0 && j2.getVida() > 0)
            {
                string acao = j1.Jogada();
                if (acao == "1")
                {
                    j1.Ataque();
                    if (j1.getAtaque() > j2.getDefesa())
                    {
                        j2.setVida(j2.getVida() - (j1.getAtaque() - j2.getDefesa()));
                        Console.WriteLine("vidaJ2: " + j2.getVida());
                    }
                    else
                    {
                        Console.WriteLine("Ataque falhou");
                    }
                }
                if (acao == "2")
                {
                    j1.Defesa();
                }

                j2.setDefesa(j2.getDefesaP());

                if (j2.getVida() > 0)
                {
                    acao = j2.Jogada();
                    if (acao == "1")
                    {
                        j2.Ataque();
                        if (j2.getAtaque() > j1.getDefesa())
                        {
                            j1.setVida(j1.getVida() - (j2.getAtaque() - j1.getDefesa()));
                            Console.WriteLine("vidaJ1: " + j1.getVida());
                        }
                        else
                        {
                            Console.WriteLine("Ataque falhou");
                        }
                    }
                    if (acao == "2")
                    {
                        j2.Defesa();
                    }
                }
                j1.setDefesa(j1.getDefesaP());
            }
            if (j1.getVida() <= 0)
            {
                Console.WriteLine("O jogador 2 venceu!");
            }
            else
            {
                Console.WriteLine("O jogador 1 venceu!");
            }

        }
    }
}
