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

        public string Nome { get => nome; set => nome = value; }
        public Equipamento Equipamento { get => equipamento; set => equipamento = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string Exemplares { get => exemplares; set => exemplares = value; }

        public EquipamentoRegisto(string nome, Equipamento equipamento, int quantidade, string exemplares)
        {
            this.nome = nome;
            this.equipamento = equipamento;
            this.quantidade = quantidade;
            this.exemplares = exemplares;
        }

        public EquipamentoRegisto(string nome, Equipamento equipamento, int quantidade)
        {
            this.nome = nome;
            this.equipamento = equipamento;
            this.quantidade = quantidade;
        }
    }
}
