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
    public partial class Espacos : MetroFramework.Forms.MetroForm
    {
        List<Espaco> espacos;
        List<EspacoRegisto> registos;
        public Espacos()
        {
            InitializeComponent();
            espacos = new List<Espaco>();
            registos = new List<EspacoRegisto>();
        }

        private void Salas_Load(object sender, EventArgs e)
        {
            CarregaEspacos();
            CarregaEmprestimos();
        }

        private void CarregaEmprestimos()
        {
            //Carrega a lista de empréstimos ativos
        }

        private void CarregaEspacos()
        {
            //Carrega a lista de espaços disponíveis
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            EspDefaults();
        }

        private void EspDefaults()
        {
            tbEspDesignacao.Text = "";
            nudEspMax.Value = 1;
            tbEspAbertura.Text = "";
            tbEspEncerramento.Text = "";
            tbEspAdicionais.Text = "";
            tgEspPessoas.Checked = false;
        }

        private void tgEspPessoas_CheckedChanged(object sender, EventArgs e)
        {
            if(tgEspPessoas.Checked)
                nudEspMax.Enabled = true;
            else
                nudEspMax.Enabled = false;
        }

        private void btRegLimpar_Click(object sender, EventArgs e)
        {
            RegDefaults();
        }

        private void RegDefaults()
        {
            cbRegNome.SelectedIndex = -1;
            cbRegNome.Text = "";
            cbRegEspaco.Text = "";
            cbRegEspaco.SelectedIndex = -1;
            tbRegTurma.Text = "";
            nudRegPessoas.Value = 0;
            tbRegEntrada.Text = "";
            tbRegSaida.Text = "";
            dtRegData.Value = DateTime.Today;
            tbRegAdicionais.Text = "";
        }

        private void tabNovoRegisto_Click(object sender, EventArgs e)
        {
            //Deletar função
        }

        private void nudEspMax_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btEspSubmeter_Click(object sender, EventArgs e)
        {
            //Adicionar a lista
            //Guardar a lista
            //Atualizar a lista
            //Limpar campos
        }

        private void btRegSubmeter_Click(object sender, EventArgs e)
        {
            //Adicionar a lista
            //Guardar a lista
            //Atualizar a lista
            //Limpar campos

            if (RegPreenchido())
            {
                EspacoRegisto novo = new EspacoRegisto((string)cbRegNome.SelectedItem, (Espaco)cbRegEspaco.SelectedItem, tbRegEntrada.Text, tbRegSaida.Text, dtRegData.Value);
                //PreencherCampos(novo);
                registos.Add(novo);

                listRegistos.DataSource = null;
                listRegistos.DataSource = registos;
                RegDefaults();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatórios." + Environment.NewLine + "Campos marcados com o asterisco '⚹'", "Erro ao submeter formulário", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
        }

        private bool RegPreenchido()
        {
            throw new NotImplementedException();
        }

        private void gridLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mostrar no formulário os dados do item selecionado
        }

        private void gridAtivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Mostrar no formulário os dados do item selecionado
        }

        private void btListaAlterar_Click(object sender, EventArgs e)
        {
            //Alterar os dados do item selecionado
        }
    }
}
