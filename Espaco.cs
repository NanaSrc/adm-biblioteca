using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    class Espaco
    {
        private string designacao;
        private int max;
        private int min;
        private string inicio;
        private string fim;
        private string notas;

        public string Designacao { get => designacao; set => designacao = value; }
        public int Max { get => max; set => max = value; }
        public int Min { get => min; set => min = value; }
        public string Inicio { get => inicio; set => inicio = value; }
        public string Fim { get => fim; set => fim = value; }
        public string Notas { get => notas; set => notas = value; }

        public Espaco()
        {

        }
    }
}
