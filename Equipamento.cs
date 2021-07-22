using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Equipamento
    {
        private string designacao;
        private string codigo;
        private int quantidade;
        private string adicionais;

        public string Designacao { get => designacao; set => designacao = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string Adicionais { get => adicionais; set => adicionais = value; }

        public Equipamento(string designacao, string codigo, int quantidade, string adicionais)
        {
            this.designacao = designacao;
            this.codigo = codigo;
            this.quantidade = quantidade;
            this.adicionais = adicionais;
        }

        public Equipamento(string designacao, string codigo, int quantidade)
        {
            this.designacao = designacao;
            this.codigo = codigo;
            this.quantidade = quantidade;
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

            return string.Format(" {0,-30}    ({1})    {2,20}     {3,20}", Designacao.ToUpper(), Codigo.ToUpper(), quantidade, comentario);
        }
    }
}
