using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    [Serializable]
    class Utilizador
    {
        private string nome;
        private string processo;
        private string funcao;
        private string ano;
        private string turma;
        private string adicionais;

        public string Nome { get => nome; set => nome = value; }
        public string Processo { get => processo; set => processo = value; }
        public string Funcao { get => funcao; set => funcao = value; }
        public string Ano { get => ano; set => ano = value; }
        public string Turma { get => turma; set => turma = value; }
        public string Adicionais { get => adicionais; set => adicionais = value; }

        public Utilizador(string nome, string processo, string funcao, string ano, string turma, string adicionais)
        {
            this.nome = nome;
            this.processo = processo;
            this.funcao = funcao;
            this.ano = ano;
            this.turma = turma;
            this.adicionais = adicionais;
        }

        public Utilizador(string nome)
        {
            this.nome = nome;
        }

        public Utilizador(string nome, string processo, string adicionais)
        {
            this.nome = nome;
            this.processo = processo;
            this.adicionais = adicionais;
        }

        public override string ToString()
        {
            string letra;

            if (Funcao == "Aluno")
                letra = "A";
            else
                letra = "P";

            string comentario;

            if (Adicionais != "")
            {
                comentario = "Possui 1 comentário";
                
            }
            else
            {
                comentario = "Possui 0 comentários";
            }

            return string.Format("[{5}] {0,-30}    ({1})    {3,20}{2}     {4,20}", Nome.ToUpper(), Processo.ToUpper(), Turma.ToUpper(), Ano, comentario, letra);
        }
    }
}
