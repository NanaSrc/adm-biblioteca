using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    [Serializable]
    class Nota
    {
        private string autor;
        private string titulo;
        private string subtitulo;
        private string conteudo;

        public string Autor { get => autor; set => autor = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Subtitulo { get => subtitulo; set => subtitulo = value; }
        public string Conteudo { get => conteudo; set => conteudo = value; }

        public Nota(string autor, string titulo, string subtitulo, string conteudo)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.subtitulo = subtitulo;
            this.conteudo = conteudo;
        }

        public Nota(string autor, string titulo, string conteudo)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.conteudo = conteudo;
        }

        public override string ToString()
        {
            return string.Format(" {0,-30}   ({1})   Por: {2}", Titulo.ToUpper(), Subtitulo, Autor.ToUpper());
        }
    }
}
