using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgSenac
{
    public class Jogador
    {
        private int id;
        private int vida;
        private int ataqueP;
        private int ataque;
        private int defesaP;
        private int defesa;

        //CONSTRUTOR
        public Jogador(int id, int vida, int ataqueP, int defesaP)
        {
            this.setId(id);
            this.setVida(vida);
            this.setAtaqueP(ataqueP);
            this.setDefesaP(defesaP);
            this.setDefesa(defesaP);

        }

        public string Jogada()
        {
            string acao = "";
            Console.WriteLine("Jogador " + this.id);
            do
            {
                Console.WriteLine("1.Ataque 2.Defesa");
                acao = Console.ReadLine();
            } while (acao != "1" && acao != "2");
            return acao;
        }

        public int Ataque()
        {
            this.setAtaque((this.getAtaqueP() * this.fAleatorio(50, 151)) / 100);
            return this.getAtaque();
            //Console.WriteLine("ataque: " + this.getAtaque());
        }

        private int fAleatorio(int piso, int teto)
        {
            Random numAleatorio = new Random();
            return numAleatorio.Next(piso, teto);
        }

        public int Defesa()
        {
            this.setDefesa((this.getDefesaP() * this.fAleatorio(100, 151)) / 100);
            return this.getDefesa();
            //Console.WriteLine("defesa: " + this.getDefesa());
        }


        public int getId() { return id; }
        public void setId(int id) { this.id = id; }

        public int getVida() { return vida; }
        public void setVida(int vida) { this.vida = vida; }
        public int getAtaqueP() { return ataqueP; }
        public void setAtaqueP(int ataqueP) { this.ataqueP = ataqueP; }
        public int getAtaque() { return ataque; }
        public void setAtaque(int ataque) { this.ataque = ataque; }
        public int getDefesaP() { return defesaP; }
        public void setDefesaP(int defesaP) { this.defesaP = defesaP; }
        public int getDefesa() { return defesa; }
        public void setDefesa(int defesa) { this.defesa = defesa; }

    }
}
