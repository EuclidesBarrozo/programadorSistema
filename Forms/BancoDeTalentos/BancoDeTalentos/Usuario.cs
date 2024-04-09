using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeTalentos
{
    public class Usuario
    {
        private string usuario = "Euclides";
        private string senha   = "123";

        //métodos (get e set)
        public string getUsuario()
        {
            return this.usuario;
        }
        public void setUsuario(string usuario)
        {
            this.usuario = usuario;
        }
        public string getSenha()
        {
            return this.senha;
        }
        public void setSenha(string senha)
        {
            this.senha = senha;
        }

    }
}
