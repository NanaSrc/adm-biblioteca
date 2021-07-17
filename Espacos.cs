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
        public Espacos()
        {
            InitializeComponent();
        }

        private void Salas_Load(object sender, EventArgs e)
        {

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
            tbRegTurma.Text = "";
            nudRegPessoas.Value = 0;
            tbRegEntrada.Text = "";
            tbRegSaida.Text = "";
            dtRegData.Value = DateTime.Today;
            tbRegAdicionais.Text = "";
        }
    }
}
