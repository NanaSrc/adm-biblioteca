namespace biblioteca
{
    class Professor
    {
        private string nome;
        private string processo;
        private string adicionais;

        public string Nome { get => nome; set => nome = value; }
        public string Processo { get => processo; set => processo = value; }
        public string Adicionais { get => adicionais; set => adicionais = value; }

        public Professor(string nome, string processo, string adicionais)
        {
            this.nome = nome;
            this.processo = processo;
            this.adicionais = adicionais;
        }

        public Professor(string nome)
        {
            this.nome = nome;
        }
    }
}
