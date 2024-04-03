using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgSenacPOO
{
    public class Jogador
    {
        private int vida;
        private int ataqueP;
        private int ataque;
        private int defesaP;
        private int defesa;



        public int getVida() {  return vida; }
        public void setVida(int vida) {  this.vida = vida; }
        public int getAtaqueP() {  return ataqueP; }
        public void setAtaqueP(int ataqueP) {  this.ataqueP = ataqueP; }
        public int getAtaque() { return ataque; }
        public void setAtaque(int ataque) { this.ataque = ataque; }
        public int getDefesaP() { return defesaP; }
        public void setDefesaP(int defesaP) { this.defesaP = defesaP; }
        public int getDefesa() { return defesa; }
        public void setDefesa(int defesa) { this.defesa = defesa; }
    }
}
