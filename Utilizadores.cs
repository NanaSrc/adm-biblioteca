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
    public partial class Utilizadores : MetroFramework.Forms.MetroForm
    {
        List<Utilizador> utilizadores;
        public Utilizadores()
        {
            InitializeComponent();
            utilizadores = new List<Utilizador>();;
        }

        private void Utilizadores_Load(object sender, EventArgs e)
        {
            tbNome.Focus();
            CarregaUtilizadores();
            CarregaEmprestimos();
        }

        private void CarregaEmprestimos()
        {
            //Carregar empréstimos
        }

        private void CarregaUtilizadores()
        {
            //Carregar utilizadores
        }

        private void PreencherCampos(Professor professor)
        {
            if (professor.Processo == "")
                professor.Processo = "N/A";
        }

        private bool ProfPreenchido()
        {
            throw new NotImplementedException();
        }

        private void btAluLimpar_Click(object sender, EventArgs e)
        {
            AluDefaults();
        }

        private void AluDefaults()
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

            if (AluPreenchido())
            {
                Utilizador novo = new Utilizador(tbNome.Text, tbProcesso.Text, cbAluAno.Text, tbAluTurma.Text, tbAdicionais.Text);
                PreencherCampos(novo);
                utilizadores.Add(novo);

                listUtilizadores.DataSource = null;
                listUtilizadores.DataSource = utilizadores;
                AluDefaults();
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

        private bool AluPreenchido()
        {
            if (tbNome.Text != "")
                return true;
            else
                return false;
        }

        private void cbFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFuncao.SelectedText == "Aluno")
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
    }
}
