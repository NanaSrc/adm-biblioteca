using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class EspacoRegisto
    {
        private string nome;
        private Espaco espaco;
        private string turma;
        private string entrada;
        private string saida;
        private DateTime data;
        private int numpessoas;
        private string adicionais;

        public string Nome { get => nome; set => nome = value; }
        public Espaco Espaco { get => espaco; set => espaco = value; }
        public string Turma { get => turma; set => turma = value; }
        public string Entrada { get => entrada; set => entrada = value; }
        public string Saida { get => saida; set => saida = value; }
        public DateTime Data { get => data; set => data = value; }
        public int NumPessoas { get => numpessoas; set => numpessoas = value; }
        public string Adicionais { get => adicionais; set => adicionais = value; }
        
        public EspacoRegisto(string nome, Espaco espaco, string turma, string entrada, string saida, DateTime data, int numpessoas, string adicionais)
        {
            this.nome = nome;
            this.espaco = espaco;
            this.turma = turma;
            this.entrada = entrada;
            this.saida = saida;
            this.data = data;
            this.numpessoas = numpessoas;
            this.adicionais = adicionais;
        }

        public EspacoRegisto(string nome, Espaco espaco, string entrada, string saida, DateTime data)
        {
            this.nome = nome;
            this.espaco = espaco;
            this.entrada = entrada;
            this.saida = saida;
            this.data = data;
        }
    }
}
