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
    public partial class Equipamentos : MetroFramework.Forms.MetroForm
    {
        List<Equipamento> equipamentos;
        List<EquipamentoRegisto> registos;
        List<Utilizador> utilizadores;
        //List<String> exemplares;
        //List<String> exemplaressel;
        //List<String> nomes;
        public Equipamentos()
        {
            InitializeComponent();
            equipamentos = new List<Equipamento>();
            registos = new List<EquipamentoRegisto>();
        }

        private void Equipamentos_Load(object sender, EventArgs e)
        {
            CarregaEquipamentos();
            CarregaUtilizadores();
            CarregaRegistos();
        }

        private void CarregaRegistos()
        {
            if (File.Exists("equipregistos.dat"))
            {
                FileStream stream = new FileStream("equipregistos.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bin = new BinaryFormatter();
                registos = (List<EquipamentoRegisto>)bin.Deserialize(stream);
                stream.Close();

                listAtivos.DataSource = null;
                listAtivos.DataSource = registos;
            }
        }

        private void CarregaUtilizadores()
        {
            if (File.Exists("utilizadores.dat"))
            {
                FileStream stream = new FileStream("utilizadores.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bin = new BinaryFormatter();
                utilizadores = (List<Utilizador>)bin.Deserialize(stream);
                stream.Close();

                cbRegNome.DataSource = null;
                cbRegNome.DataSource = utilizadores;
                /*for(int i = 0; i <= utilizadores.Count; i++ )
                {
                    nomes.Add(utilizadores.ElementAt(i).Nome);
                }
                cbRegNome.DataSource = null;
                cbRegNome.DataSource = nomes;*/
            }
        }

        private void CarregaEquipamentos()
        {
            if (File.Exists("equipamentos.dat"))
            {
                FileStream stream = new FileStream("equipamentos.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bin = new BinaryFormatter();
                equipamentos = (List<Equipamento>)bin.Deserialize(stream);
                stream.Close();

                listLista.DataSource = null;
                listLista.DataSource = equipamentos;
                cbRegEquipamento.DataSource = equipamentos;
            }
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

        private void btRegSubmeter_Click(object sender, EventArgs e)
        {
            if (RegPreenchido())
            {
                EquipamentoRegisto novo = new EquipamentoRegisto((Utilizador)cbRegNome.SelectedItem, (Equipamento)cbRegEquipamento.SelectedItem, (int)nudEquipQuantidade.Value, tbRegExemplares.Text, tbEquipAdicionais.Text);
                registos.Add(novo);

                listAtivos.DataSource = null;
                listAtivos.DataSource = registos;

                RegDefaults();
                GuardarDados();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatórios." + Environment.NewLine + "Campos marcados com o asterisco '⚹'", "Erro ao submeter formulário", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
        }

        private bool RegPreenchido()
        {
            if (cbRegNome.SelectedIndex != -1 && cbRegEquipamento.SelectedIndex != -1)
                return true;
            else
                return false;
        }

        private bool EquipPreenchido()
        {
            if (tbEquipDesignacao.Text != "" && tbEquipCodigo.Text != "")
                return true;
            else
                return false;
        }

        private void tbEquipAdicionais_Click(object sender, EventArgs e)
        {

        }

        private void Equipamentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarDados();
        }

        private void GuardarDados()
        {
            if (equipamentos != null)
            {
                FileStream stream = new FileStream("equipamentos.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, equipamentos);
                stream.Close();
            }

            /*if (exemplares != null)
            {
                FileStream stream = new FileStream("exemplares.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, exemplares);
                stream.Close();
            }
            */
            if (registos != null)
            {
                FileStream stream = new FileStream("equipregistos.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, registos);
                stream.Close();
            }
        }

        private void btEquipSubmeter_Click(object sender, EventArgs e)
        {
            if (EquipPreenchido())
            {
                if (tgEquipQuantidade.Checked == true)
                {
                    Equipamento novo = new Equipamento(tbEquipDesignacao.Text, tbEquipCodigo.Text, (int)nudEquipQuantidade.Value, tbEquipAdicionais.Text);
                    equipamentos.Add(novo);
                    //exemplares.Add(tbEquipCodigo.Text);   
                }
                else
                {
                    Equipamento novo = new Equipamento(tbEquipDesignacao.Text, tbEquipCodigo.Text, tbEquipAdicionais.Text);
                    equipamentos.Add(novo);
                    //exemplares.Add(tbEquipCodigo.Text);
                }

                listLista.DataSource = null;
                listLista.DataSource = equipamentos;

                EquipDefaults();
                GuardarDados();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatórios." + Environment.NewLine + "Campos marcados com o asterisco '⚹'", "Erro ao submeter formulário", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
        }

        private void listAtivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            EquipamentoRegisto selec = (EquipamentoRegisto)listAtivos.SelectedItem;
            cbRegNome.SelectedItem = selec.Utilizador;
            cbRegEquipamento.SelectedItem = selec.Equipamento;
            tbRegExemplares.Text = selec.Exemplares;
            tbRegAdicionais.Text = selec.Adicionais;
        }

        private void listLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipamento selec = (Equipamento)listAtivos.SelectedItem;

        }
    }
}
