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
        List<Aluno> alunos;
        List<Professor> professores;
        public Utilizadores()
        {
            InitializeComponent();
            alunos = new List<Aluno>();
            professores = new List<Professor>();
        }

        private void Utilizadores_Load(object sender, EventArgs e)
        {
            tbAluNome.Focus();
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

        private void btSubmeter_Click(object sender, EventArgs e)
        {
            //Adicionar a lista
            //Guardar a lista
            //Atualizar a lista
            //Limpar campos
        }

        private void btAluLimpar_Click(object sender, EventArgs e)
        {
            AluDefaults();
        }

        private void AluDefaults()
        {
            tbAluNome.Text = "";
            tbAluTurma.Text = "";
            tbAluProcesso.Text = "";
            cbAluAno.SelectedIndex = -1;
            tbAluAdicionais.Text = "";
            tbAluNome.Focus();
        }

        private void btProfLimpar_Click(object sender, EventArgs e)
        {
            ProfDefaults();
        }

        private void ProfDefaults()
        {
            tbProfNome.Text = "";
            tbProfProcesso.Text = "";
            tbProfAdicionais.Text = "";
            tbProfNome.Focus();
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
                Aluno novo = new Aluno(tbAluNome.Text, tbAluProcesso.Text, cbAluAno.Text, tbAluTurma.Text, tbAluAdicionais.Text);
                PreencherCampos(novo);
                alunos.Add(novo);

                listUtilizadores.DataSource = null;
                listUtilizadores.DataSource = alunos;
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

        private void PreencherCampos(Aluno aluno)
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
            if (tbAluNome.Text != "")
                return true;
            else
                return false;
        }
    }
}
