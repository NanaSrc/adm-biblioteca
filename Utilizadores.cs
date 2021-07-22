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
    public partial class Utilizadores : MetroFramework.Forms.MetroForm
    {
        List<Utilizador> utilizadores;
        public Utilizadores()
        {
            InitializeComponent();
            utilizadores = new List<Utilizador>();
        }

        private void Utilizadores_Load(object sender, EventArgs e)
        {
            tbNome.Focus();
            CarregaUtilizadores();
            //CarregaEmprestimos();
        }

        /*private void CarregaEmprestimos()
        {
            //Carregar empréstimos
        }*/

        private void CarregaUtilizadores()
        {
            //Carregar utilizadores
            if (File.Exists("utilizadores.dat"))
            {
                FileStream stream = new FileStream("utilizadores.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bin = new BinaryFormatter();
                utilizadores = (List<Utilizador>)bin.Deserialize(stream);
                stream.Close();
                ListRefresh();
            }
        }

        private bool ProfPreenchido()
        {
            throw new NotImplementedException();
        }

        private void btAluLimpar_Click(object sender, EventArgs e)
        {
            Defaults();
        }

        private void Defaults()
        {
            tbNome.Text = "";
            tbAluTurma.Text = "";
            tbProcesso.Text = "";
            cbAluAno.SelectedIndex = -1;
            tbAdicionais.Text = "";
            tbNome.Focus();
        }

        private void Utilizadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Guardar listas
            GuardarDados();
        }

        private void GuardarDados()
        {
            if (utilizadores != null)
            {
                FileStream stream = new FileStream("utilizadores.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, utilizadores);
                stream.Close();
            }
        }

        private void gridLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mostrar os dados do item selecionado
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //Alterar os dados do item selecionado
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            //Deletar os dados do item selecionado
            Utilizador selec = (Utilizador)listUtilizadores.SelectedItem;
            utilizadores.Remove(selec);

            ListRefresh();
            Defaults();
            GuardarDados();
        }

        private void ListRefresh()
        {
            listUtilizadores.DataSource = null;
            listUtilizadores.DataSource = utilizadores;
        }

        private void gridAtivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mostrar os dados do item selecionado
        }

        private void btEmpAlterar_Click(object sender, EventArgs e)
        {
            //Alterar os dados do item selecionado
        }

        private void btEmpDeletar_Click(object sender, EventArgs e)
        {
            //Deletar os dados do item selecionado
        }

        private void btAluSubmeter_Click(object sender, EventArgs e)
        {
            //Adicionar a lista

            if (Preenchido())
            {
                Utilizador novo = new Utilizador(tbNome.Text, tbProcesso.Text, (String)cbFuncao.SelectedItem, cbAluAno.Text, tbAluTurma.Text, tbAdicionais.Text);
                PreencherCampos(novo);
                utilizadores.Add(novo);

                listUtilizadores.DataSource = null;
                listUtilizadores.DataSource = utilizadores;
                Defaults();
                GuardarDados();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatórios." + Environment.NewLine + "Campos marcados com o asterisco '⚹'", "Erro ao submeter formulário", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }

            //Guardar a lista
            //Atualizar a lista
            //Limpar campos
        }

        private void PreencherCampos(Utilizador aluno)
        {
            if (aluno.Processo == "")
                aluno.Processo = "N/A";

            if (aluno.Ano == "")
                aluno.Ano = "-";

            if (aluno.Turma == "")
                aluno.Turma = "-";
        }

        private bool Preenchido()
        {
            if (tbNome.Text != "" && cbFuncao.SelectedIndex != -1)
                return true;
            else
                return false;
        }

        private void cbFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cbFuncao.SelectedItem == "Aluno")
            {
                tbAluTurma.Enabled = true;
                cbAluAno.Enabled = true;
            }
            else
            {
                tbAluTurma.Enabled = false;
                cbAluAno.Enabled = false;
            }
        }

        private void cbAluAno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pageReg_Click(object sender, EventArgs e)
        {

        }

        private void listUtilizadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utilizador selec = (Utilizador)listUtilizadores.SelectedItem;

            if (selec != null)
            {
                tbNome.Text = selec.Nome;
                cbFuncao.SelectedItem = selec.Funcao;
                tbProcesso.Text = selec.Processo;
                tbAluTurma.Text = selec.Turma;
                cbAluAno.SelectedItem = selec.Ano;
                tbAdicionais.Text = selec.Adicionais;
            }
        }
    }
}
