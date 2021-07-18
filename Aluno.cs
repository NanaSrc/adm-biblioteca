using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Aluno
    {
        private string nome;
        private string processo;
        private string ano;
        private string turma;
        private string adicionais;

        public string Nome { get => nome; set => nome = value; }
        public string Processo { get => processo; set => processo = value; }
        public string Ano { get => ano; set => ano = value; }
        public string Turma { get => turma; set => turma = value; }
        public string Adicionais { get => adicionais; set => adicionais = value; }

        public Aluno(string nome, string processo, string ano, string turma, string adicionais)
        {
            this.nome = nome;
            this.processo = processo;
            this.ano = ano;
            this.turma = turma;
            this.adicionais = adicionais;
        }

        public Aluno(string nome)
        {
            this.nome = nome;
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

            return string.Format("[A] {0,-30}    ({1})    {3,20}{2}     {4,20}", Nome.ToUpper(), Processo.ToUpper(), Turma.ToUpper(), Ano, comentario);
        }
    }
}
