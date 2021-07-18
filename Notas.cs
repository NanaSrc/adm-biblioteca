using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class Notas : MetroFramework.Forms.MetroForm
    {
        List<Nota> notas;
        public Notas()
        {
            InitializeComponent();
        }

        private void Notas_Load(object sender, EventArgs e)
        {
            CarregaNotas();
        }

        private void CarregaNotas()
        {
            //Carregar notas
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            //Limpar os campos
            Defaults();
        }

        private void Defaults()
        {
            tbAutor.Text = "";
            tbConteudo.Text = "";
            tbSubtitulo.Text = "";
            tbTitulo.Text = "";
            tbAutor.Focus();
        }

        private void btSubmeter_Click(object sender, EventArgs e)
        {
            //Adicionar a lista (código)
            //Guardar a lista (código)
            //Atualizar a lista (form)
        }

        private void Notas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Guardar a lista
        }

        private void gridLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mostrar os dados no formulário
            //Mostrar nota
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //Alterar o conteúdo da nota selecionada
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            //Apagar a nota selecionada
        }
    }
}
