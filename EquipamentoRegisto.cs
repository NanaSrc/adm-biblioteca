using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    [Serializable]
    class EquipamentoRegisto
    {
        private Utilizador utilizador;
        private Equipamento equipamento;
        private int quantidade;
        private string exemplares;
        private string adicionais;
        private List<Utilizador> utilizadores;
        private List<Equipamento> equipamentos;
        public Utilizador Utilizador { get => utilizador; set => utilizador = value; }
        public Equipamento Equipamento { get => equipamento; set => equipamento = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string Exemplares { get => exemplares; set => exemplares = value; }
        public string Adicionais { get => adicionais; set => adicionais = value; }
        public List<Utilizador> Utilizadores { get => utilizadores; set => utilizadores = value; }
        public List<Equipamento> Equipamentos { get => equipamentos; set => equipamentos = value; }

        public EquipamentoRegisto(Utilizador utilizador, Equipamento equipamento, int quantidade, string exemplares, string adicionais)
        {
            this.utilizador = utilizador;
            this.equipamento = equipamento;
            this.quantidade = quantidade;
            this.exemplares = exemplares;
            this.adicionais = adicionais;
        }

        public EquipamentoRegisto(Utilizador utilizador, Equipamento equipamento, int quantidade, string adicionais)
        {
            this.utilizador = utilizador;
            this.equipamento = equipamento;
            this.quantidade = quantidade;
            this.adicionais = adicionais;
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

            string exemplar;

            if(exemplares != null)
            {
                exemplar = "Códigos atribuídos";
            }
            else
                exemplar = "Código não atribuído";

            return string.Format(" {0,-30}  -  {1,20}    Quant: {2,20}        ({3,20})", utilizador.Nome.ToUpper(), equipamento.Designacao.ToUpper(), quantidade, exemplar);
        }
    }
}
