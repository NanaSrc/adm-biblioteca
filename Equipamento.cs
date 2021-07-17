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
    }
}
