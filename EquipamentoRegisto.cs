using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class EquipamentoRegisto
    {
        private string nome;
        private Equipamento equipamento;
        private int quantidade;
        private string exemplares;
        private string adicionais;

        public string Nome { get => nome; set => nome = value; }
        public Equipamento Equipamento { get => equipamento; set => equipamento = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string Exemplares { get => exemplares; set => exemplares = value; }
        public string Adicionais { get => adicionais; set => adicionais = value; }

        public EquipamentoRegisto(string nome, Equipamento equipamento, int quantidade, string exemplares, string adicionais)
        {
            this.nome = nome;
            this.equipamento = equipamento;
            this.quantidade = quantidade;
            this.exemplares = exemplares;
            this.adicionais = adicionais;
        }

        public EquipamentoRegisto(string nome, Equipamento equipamento, int quantidade)
        {
            this.nome = nome;
            this.equipamento = equipamento;
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

            return string.Format(" {0,-30}    ({1})    {2,20}     {3,20}", nome.ToUpper(), equipamento.Designacao.ToUpper(), quantidade, exemplares);
        }
    }
}
