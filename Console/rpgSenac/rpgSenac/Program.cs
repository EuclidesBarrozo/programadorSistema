using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgSenac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //configuração 1o jogador
            int vidaJ1 = 100;
            int ataqueJ1 = 5;
            int defesaJ1 = 3;
            //configuração 2o jogador
            int vidaJ2 = 60;
            int ataqueJ2 = 4;
            int defesaJ2 = 4;
            //inicio da repetição
            while(vidaJ1 > 0 && vidaJ2 > 0)
            {
                //ação do jogador 1
                string acao = "";
                do
                {
                    Console.WriteLine("1. Ataque 2.Defesa");
                    acao = Console.ReadLine();
                } while (acao != "1" && acao != "2");
                //verificar ação
                if(acao == "1")
                {
                    //se ataque calcular poder de ataque
                    //calcular fator aleatório (1 a 10)
                    Random numAleatorio = new Random();
                    int fAleatorio = numAleatorio.Next(50, 151);
                    int ataqueJ1T = (ataqueJ1 * fAleatorio) / 100;
                    Console.WriteLine("aleatorio " + fAleatorio);
                    Console.WriteLine("ataque temporario " + ataqueJ1T);
                    //verificar se poder de ataque J1 > Defesa J2
                    //depois mudar para defesaJ2T
                    if( ataqueJ1T > defesaJ2)
                    {
                        //Se sim, diminuir vida
                        vidaJ2 = vidaJ2 - (ataqueJ1T - defesaJ2);
                        Console.WriteLine("vidaJ2 " + vidaJ2);
                    }
                }

                
                //Se sim, diminuir vida
                //se defesa calcular o poder de defesa
                //volta aos valores padrões
                //verificar se os jogadores possuem pontos de vida 
                //próximo turno
            }
        }
    }
}
