using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    [Serializable]
    class EspacoRegisto
    {
        private Utilizador utilizador;
        private Espaco espaco;
        private string entrada;
        private string saida;
        private DateTime data;
        private int numpessoas;
        private string adicionais;

        public Utilizador Utilizador { get => utilizador; set => utilizador = value; }
        public Espaco Espaco { get => espaco; set => espaco = value; }
        public string Entrada { get => entrada; set => entrada = value; }
        public string Saida { get => saida; set => saida = value; }
        public DateTime Data { get => data; set => data = value; }
        public int NumPessoas { get => numpessoas; set => numpessoas = value; }
        public string Adicionais { get => adicionais; set => adicionais = value; }
        
        public EspacoRegisto(Utilizador nome, Espaco espaco, string entrada, string saida, DateTime data, int numpessoas, string adicionais)
        {
            this.utilizador = nome;
            this.espaco = espaco;
            this.entrada = entrada;
            this.saida = saida;
            this.data = data;
            this.numpessoas = numpessoas;
            this.adicionais = adicionais;
        }

        public EspacoRegisto(Utilizador nome, Espaco espaco, string entrada, string saida, DateTime data)
        {
            this.utilizador = nome;
            this.espaco = espaco;
            this.entrada = entrada;
            this.saida = saida;
            this.data = data;
        }

        public override string ToString()
        {
            string comentario;

            if (Adicionais != "")
            {
                comentario = "Possui 1 comentário";

            }
            else
            {
                comentario = "Possui 0 comentários";
            }

            return string.Format(" {0,-25}  -  {4}   {5,5} ({1} - {2})   {3,15}", Utilizador.Nome.ToUpper(), entrada, saida, comentario, espaco, data.ToString());
        }
    }
}
