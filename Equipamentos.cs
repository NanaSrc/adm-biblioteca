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
    public partial class Equipamentos : MetroFramework.Forms.MetroForm
    {
        public Equipamentos()
        {
            InitializeComponent();
        }

        private void Equipamentos_Load(object sender, EventArgs e)
        {

        }

        private void tgEquipQuantidade_CheckedChanged(object sender, EventArgs e)
        {
            if (tgEquipQuantidade.Checked)
                nudEquipQuantidade.Enabled = true;
            else
                nudEquipQuantidade.Enabled = false;
        }

        private void btRegLimpar_Click(object sender, EventArgs e)
        {
            RegDefaults();
        }

        private void RegDefaults()
        {
            cbRegNome.SelectedIndex = -1;
            cbRegNome.Text = "";
            cbRegEquipamento.Text = "";
            cbRegEquipamento.SelectedIndex = -1;
            listRegSelecionados.Items.Clear();
            listRegLista.SelectedItems.Clear();
            tbRegAdicionais.Text = "";
        }

        private void btEquipLimpar_Click(object sender, EventArgs e)
        {
            EquipDefaults();
        }

        private void EquipDefaults()
        {
            tbEquipDesignacao.Text = "";
            tbEquipCodigo.Text = "";
            nudEquipQuantidade.Value = 1;
            tgEquipQuantidade.Checked = false;
            tbEquipAdicionais.Text = "";
        }
    }
}
