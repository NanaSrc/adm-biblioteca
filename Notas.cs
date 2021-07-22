using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
            notas = new List<Nota>();
        }

        private void Notas_Load(object sender, EventArgs e)
        {
            CarregaNotas();
        }

        private void CarregaNotas()
        {
            //Carregar notas
            if (File.Exists("notas.dat"))
            {
                FileStream stream = new FileStream("notas.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bin = new BinaryFormatter();
                notas = (List<Nota>)bin.Deserialize(stream);
                stream.Close();
                listLista.DataSource = null;
                listLista.DataSource = notas;
            }
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

            if (Preenchido())
            {
                Nota novo = new Nota(tbAutor.Text, tbTitulo.Text, tbSubtitulo.Text, tbConteudo.Text);
                notas.Add(novo);

                listLista.DataSource = null;
                listLista.DataSource = notas;
                Defaults();
                GuardarDados();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatórios." + Environment.NewLine + "Campos marcados com o asterisco '⚹'", "Erro ao submeter formulário", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
        }

        private void GuardarDados()
        {
            if (notas != null)
            {
                FileStream stream = new FileStream("notas.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, notas);
                stream.Close();
            }
        }

        private bool Preenchido()
        {
            if (tbAutor.Text != "" && tbTitulo.Text != "" && tbConteudo.Text != "")
                return true;
            else
                return false;
        }

        private void Notas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Guardar a lista
            GuardarDados();
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
