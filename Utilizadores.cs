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
        public Utilizadores()
        {
            InitializeComponent();
        }

        private void Utilizadores_Load(object sender, EventArgs e)
        {

        }

        private void btSubmeter_Click(object sender, EventArgs e)
        {

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
        }

        private void btProfLimpar_Click(object sender, EventArgs e)
        {
            tbProfNome.Text = "";
            tbProfProcesso.Text = "";
            tbProfAdicionais.Text = "";
        }
    }
}
