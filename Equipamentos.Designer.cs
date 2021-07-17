
namespace biblioteca
{
    partial class Equipamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabRegisto = new MetroFramework.Controls.MetroTabControl();
            this.tabEquipamentos = new MetroFramework.Controls.MetroTabPage();
            this.btEquipSubmeter = new MetroFramework.Controls.MetroButton();
            this.btEquipLimpar = new MetroFramework.Controls.MetroButton();
            this.tbEquipCodigo = new MetroFramework.Controls.MetroTextBox();
            this.tbEquipAdicionais = new MetroFramework.Controls.MetroTextBox();
            this.tbEquipDesignacao = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tabLista = new MetroFramework.Controls.MetroTabControl();
            this.tabLista1 = new MetroFramework.Controls.MetroTabPage();
            this.btDeletar = new MetroFramework.Controls.MetroButton();
            this.btAlterar = new MetroFramework.Controls.MetroButton();
            this.gridLista = new MetroFramework.Controls.MetroGrid();
            this.tabAtivos = new MetroFramework.Controls.MetroTabPage();
            this.gridAtivos = new MetroFramework.Controls.MetroGrid();
            this.tgEquipQuantidade = new MetroFramework.Controls.MetroToggle();
            this.nudEquipQuantidade = new System.Windows.Forms.NumericUpDown();
            this.tabReg = new MetroFramework.Controls.MetroTabPage();
            this.btRegSubmeter = new MetroFramework.Controls.MetroButton();
            this.btRegLimpar = new MetroFramework.Controls.MetroButton();
            this.tbRegAdicionais = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbRegNome = new System.Windows.Forms.ComboBox();
            this.cbRegEquipamento = new System.Windows.Forms.ComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.listRegLista = new System.Windows.Forms.ListBox();
            this.btRegSelecionar = new MetroFramework.Controls.MetroButton();
            this.btRegDeselecionar = new MetroFramework.Controls.MetroButton();
            this.listRegSelecionados = new System.Windows.Forms.ListBox();
            this.tabRegisto.SuspendLayout();
            this.tabEquipamentos.SuspendLayout();
            this.tabLista.SuspendLayout();
            this.tabLista1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            this.tabAtivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEquipQuantidade)).BeginInit();
            this.tabReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabRegisto
            // 
            this.tabRegisto.Controls.Add(this.tabReg);
            this.tabRegisto.Controls.Add(this.tabEquipamentos);
            this.tabRegisto.Location = new System.Drawing.Point(23, 63);
            this.tabRegisto.Name = "tabRegisto";
            this.tabRegisto.SelectedIndex = 1;
            this.tabRegisto.Size = new System.Drawing.Size(714, 606);
            this.tabRegisto.Style = MetroFramework.MetroColorStyle.Green;
            this.tabRegisto.TabIndex = 1;
            this.tabRegisto.UseSelectable = true;
            // 
            // tabEquipamentos
            // 
            this.tabEquipamentos.Controls.Add(this.tgEquipQuantidade);
            this.tabEquipamentos.Controls.Add(this.nudEquipQuantidade);
            this.tabEquipamentos.Controls.Add(this.btEquipSubmeter);
            this.tabEquipamentos.Controls.Add(this.btEquipLimpar);
            this.tabEquipamentos.Controls.Add(this.tbEquipCodigo);
            this.tabEquipamentos.Controls.Add(this.tbEquipAdicionais);
            this.tabEquipamentos.Controls.Add(this.tbEquipDesignacao);
            this.tabEquipamentos.Controls.Add(this.metroLabel10);
            this.tabEquipamentos.Controls.Add(this.metroLabel9);
            this.tabEquipamentos.Controls.Add(this.metroLabel3);
            this.tabEquipamentos.Controls.Add(this.metroLabel8);
            this.tabEquipamentos.HorizontalScrollbarBarColor = true;
            this.tabEquipamentos.HorizontalScrollbarHighlightOnWheel = false;
            this.tabEquipamentos.HorizontalScrollbarSize = 10;
            this.tabEquipamentos.Location = new System.Drawing.Point(4, 38);
            this.tabEquipamentos.Name = "tabEquipamentos";
            this.tabEquipamentos.Size = new System.Drawing.Size(706, 564);
            this.tabEquipamentos.TabIndex = 1;
            this.tabEquipamentos.Text = "Equipamentos";
            this.tabEquipamentos.VerticalScrollbarBarColor = true;
            this.tabEquipamentos.VerticalScrollbarHighlightOnWheel = false;
            this.tabEquipamentos.VerticalScrollbarSize = 10;
            // 
            // btEquipSubmeter
            // 
            this.btEquipSubmeter.Location = new System.Drawing.Point(412, 518);
            this.btEquipSubmeter.Name = "btEquipSubmeter";
            this.btEquipSubmeter.Size = new System.Drawing.Size(273, 30);
            this.btEquipSubmeter.TabIndex = 54;
            this.btEquipSubmeter.Text = "Submeter";
            this.btEquipSubmeter.UseSelectable = true;
            // 
            // btEquipLimpar
            // 
            this.btEquipLimpar.Location = new System.Drawing.Point(125, 518);
            this.btEquipLimpar.Name = "btEquipLimpar";
            this.btEquipLimpar.Size = new System.Drawing.Size(281, 30);
            this.btEquipLimpar.TabIndex = 55;
            this.btEquipLimpar.Text = "Limpar";
            this.btEquipLimpar.UseSelectable = true;
            this.btEquipLimpar.Click += new System.EventHandler(this.btEquipLimpar_Click);
            // 
            // tbEquipCodigo
            // 
            // 
            // 
            // 
            this.tbEquipCodigo.CustomButton.Image = null;
            this.tbEquipCodigo.CustomButton.Location = new System.Drawing.Point(538, 1);
            this.tbEquipCodigo.CustomButton.Name = "";
            this.tbEquipCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbEquipCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbEquipCodigo.CustomButton.TabIndex = 1;
            this.tbEquipCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbEquipCodigo.CustomButton.UseSelectable = true;
            this.tbEquipCodigo.CustomButton.Visible = false;
            this.tbEquipCodigo.Lines = new string[0];
            this.tbEquipCodigo.Location = new System.Drawing.Point(125, 71);
            this.tbEquipCodigo.MaxLength = 32767;
            this.tbEquipCodigo.Name = "tbEquipCodigo";
            this.tbEquipCodigo.PasswordChar = '\0';
            this.tbEquipCodigo.PromptText = "Código/Etiqueta do exemplar";
            this.tbEquipCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEquipCodigo.SelectedText = "";
            this.tbEquipCodigo.SelectionLength = 0;
            this.tbEquipCodigo.SelectionStart = 0;
            this.tbEquipCodigo.ShortcutsEnabled = true;
            this.tbEquipCodigo.Size = new System.Drawing.Size(560, 23);
            this.tbEquipCodigo.TabIndex = 64;
            this.tbEquipCodigo.UseSelectable = true;
            this.tbEquipCodigo.WaterMark = "Código/Etiqueta do exemplar";
            this.tbEquipCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbEquipCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbEquipAdicionais
            // 
            // 
            // 
            // 
            this.tbEquipAdicionais.CustomButton.Image = null;
            this.tbEquipAdicionais.CustomButton.Location = new System.Drawing.Point(212, 2);
            this.tbEquipAdicionais.CustomButton.Name = "";
            this.tbEquipAdicionais.CustomButton.Size = new System.Drawing.Size(345, 345);
            this.tbEquipAdicionais.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbEquipAdicionais.CustomButton.TabIndex = 1;
            this.tbEquipAdicionais.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbEquipAdicionais.CustomButton.UseSelectable = true;
            this.tbEquipAdicionais.CustomButton.Visible = false;
            this.tbEquipAdicionais.Lines = new string[0];
            this.tbEquipAdicionais.Location = new System.Drawing.Point(125, 145);
            this.tbEquipAdicionais.MaxLength = 32767;
            this.tbEquipAdicionais.Multiline = true;
            this.tbEquipAdicionais.Name = "tbEquipAdicionais";
            this.tbEquipAdicionais.PasswordChar = '\0';
            this.tbEquipAdicionais.PromptText = "Anotações adicionais";
            this.tbEquipAdicionais.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEquipAdicionais.SelectedText = "";
            this.tbEquipAdicionais.SelectionLength = 0;
            this.tbEquipAdicionais.SelectionStart = 0;
            this.tbEquipAdicionais.ShortcutsEnabled = true;
            this.tbEquipAdicionais.Size = new System.Drawing.Size(560, 350);
            this.tbEquipAdicionais.TabIndex = 62;
            this.tbEquipAdicionais.UseSelectable = true;
            this.tbEquipAdicionais.WaterMark = "Anotações adicionais";
            this.tbEquipAdicionais.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbEquipAdicionais.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbEquipDesignacao
            // 
            // 
            // 
            // 
            this.tbEquipDesignacao.CustomButton.Image = null;
            this.tbEquipDesignacao.CustomButton.Location = new System.Drawing.Point(538, 1);
            this.tbEquipDesignacao.CustomButton.Name = "";
            this.tbEquipDesignacao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbEquipDesignacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbEquipDesignacao.CustomButton.TabIndex = 1;
            this.tbEquipDesignacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbEquipDesignacao.CustomButton.UseSelectable = true;
            this.tbEquipDesignacao.CustomButton.Visible = false;
            this.tbEquipDesignacao.Lines = new string[0];
            this.tbEquipDesignacao.Location = new System.Drawing.Point(125, 33);
            this.tbEquipDesignacao.MaxLength = 32767;
            this.tbEquipDesignacao.Name = "tbEquipDesignacao";
            this.tbEquipDesignacao.PasswordChar = '\0';
            this.tbEquipDesignacao.PromptText = "Designação do equipamento";
            this.tbEquipDesignacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEquipDesignacao.SelectedText = "";
            this.tbEquipDesignacao.SelectionLength = 0;
            this.tbEquipDesignacao.SelectionStart = 0;
            this.tbEquipDesignacao.ShortcutsEnabled = true;
            this.tbEquipDesignacao.Size = new System.Drawing.Size(560, 23);
            this.tbEquipDesignacao.TabIndex = 61;
            this.tbEquipDesignacao.UseSelectable = true;
            this.tbEquipDesignacao.WaterMark = "Designação do equipamento";
            this.tbEquipDesignacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbEquipDesignacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(15, 33);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(89, 19);
            this.metroLabel10.TabIndex = 56;
            this.metroLabel10.Text = "Designação: ⁎";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(15, 71);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(66, 19);
            this.metroLabel9.TabIndex = 60;
            this.metroLabel9.Text = "Código: ⁎";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(16, 145);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 57;
            this.metroLabel3.Text = "Adicionais:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(16, 109);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(91, 19);
            this.metroLabel8.TabIndex = 59;
            this.metroLabel8.Text = "Quantidade: ⁎";
            // 
            // tabLista
            // 
            this.tabLista.Controls.Add(this.tabLista1);
            this.tabLista.Controls.Add(this.tabAtivos);
            this.tabLista.Location = new System.Drawing.Point(743, 63);
            this.tabLista.Name = "tabLista";
            this.tabLista.SelectedIndex = 0;
            this.tabLista.Size = new System.Drawing.Size(614, 606);
            this.tabLista.Style = MetroFramework.MetroColorStyle.Green;
            this.tabLista.TabIndex = 15;
            this.tabLista.UseSelectable = true;
            // 
            // tabLista1
            // 
            this.tabLista1.Controls.Add(this.btDeletar);
            this.tabLista1.Controls.Add(this.btAlterar);
            this.tabLista1.Controls.Add(this.gridLista);
            this.tabLista1.HorizontalScrollbarBarColor = true;
            this.tabLista1.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLista1.HorizontalScrollbarSize = 10;
            this.tabLista1.Location = new System.Drawing.Point(4, 38);
            this.tabLista1.Name = "tabLista1";
            this.tabLista1.Size = new System.Drawing.Size(606, 564);
            this.tabLista1.TabIndex = 0;
            this.tabLista1.Text = "Lista";
            this.tabLista1.VerticalScrollbarBarColor = true;
            this.tabLista1.VerticalScrollbarHighlightOnWheel = false;
            this.tabLista1.VerticalScrollbarSize = 10;
            // 
            // btDeletar
            // 
            this.btDeletar.Location = new System.Drawing.Point(312, 518);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(278, 30);
            this.btDeletar.TabIndex = 13;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseSelectable = true;
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(17, 518);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(289, 30);
            this.btAlterar.TabIndex = 12;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseSelectable = true;
            // 
            // gridLista
            // 
            this.gridLista.AllowUserToResizeRows = false;
            this.gridLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridLista.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridLista.EnableHeadersVisualStyles = false;
            this.gridLista.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridLista.Location = new System.Drawing.Point(17, 18);
            this.gridLista.Name = "gridLista";
            this.gridLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridLista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLista.Size = new System.Drawing.Size(573, 477);
            this.gridLista.TabIndex = 0;
            this.gridLista.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tabAtivos
            // 
            this.tabAtivos.Controls.Add(this.gridAtivos);
            this.tabAtivos.HorizontalScrollbarBarColor = true;
            this.tabAtivos.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAtivos.HorizontalScrollbarSize = 10;
            this.tabAtivos.Location = new System.Drawing.Point(4, 38);
            this.tabAtivos.Name = "tabAtivos";
            this.tabAtivos.Size = new System.Drawing.Size(606, 564);
            this.tabAtivos.TabIndex = 1;
            this.tabAtivos.Text = "Empréstimos ativos";
            this.tabAtivos.VerticalScrollbarBarColor = true;
            this.tabAtivos.VerticalScrollbarHighlightOnWheel = false;
            this.tabAtivos.VerticalScrollbarSize = 10;
            // 
            // gridAtivos
            // 
            this.gridAtivos.AllowUserToResizeRows = false;
            this.gridAtivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridAtivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridAtivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridAtivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAtivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridAtivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAtivos.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridAtivos.EnableHeadersVisualStyles = false;
            this.gridAtivos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridAtivos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridAtivos.Location = new System.Drawing.Point(17, 18);
            this.gridAtivos.Name = "gridAtivos";
            this.gridAtivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAtivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridAtivos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridAtivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAtivos.Size = new System.Drawing.Size(573, 477);
            this.gridAtivos.TabIndex = 2;
            this.gridAtivos.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tgEquipQuantidade
            // 
            this.tgEquipQuantidade.AutoSize = true;
            this.tgEquipQuantidade.Location = new System.Drawing.Point(125, 111);
            this.tgEquipQuantidade.Name = "tgEquipQuantidade";
            this.tgEquipQuantidade.Size = new System.Drawing.Size(80, 17);
            this.tgEquipQuantidade.Style = MetroFramework.MetroColorStyle.Green;
            this.tgEquipQuantidade.TabIndex = 67;
            this.tgEquipQuantidade.Text = "Off";
            this.tgEquipQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tgEquipQuantidade.UseSelectable = true;
            this.tgEquipQuantidade.CheckedChanged += new System.EventHandler(this.tgEquipQuantidade_CheckedChanged);
            // 
            // nudEquipQuantidade
            // 
            this.nudEquipQuantidade.Enabled = false;
            this.nudEquipQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEquipQuantidade.Location = new System.Drawing.Point(226, 109);
            this.nudEquipQuantidade.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.nudEquipQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEquipQuantidade.Name = "nudEquipQuantidade";
            this.nudEquipQuantidade.Size = new System.Drawing.Size(459, 22);
            this.nudEquipQuantidade.TabIndex = 66;
            this.nudEquipQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tabReg
            // 
            this.tabReg.Controls.Add(this.listRegSelecionados);
            this.tabReg.Controls.Add(this.btRegDeselecionar);
            this.tabReg.Controls.Add(this.btRegSelecionar);
            this.tabReg.Controls.Add(this.listRegLista);
            this.tabReg.Controls.Add(this.cbRegEquipamento);
            this.tabReg.Controls.Add(this.metroLabel6);
            this.tabReg.Controls.Add(this.cbRegNome);
            this.tabReg.Controls.Add(this.btRegSubmeter);
            this.tabReg.Controls.Add(this.metroLabel1);
            this.tabReg.Controls.Add(this.btRegLimpar);
            this.tabReg.Controls.Add(this.metroLabel4);
            this.tabReg.Controls.Add(this.tbRegAdicionais);
            this.tabReg.Controls.Add(this.metroLabel2);
            this.tabReg.HorizontalScrollbarBarColor = true;
            this.tabReg.HorizontalScrollbarHighlightOnWheel = false;
            this.tabReg.HorizontalScrollbarSize = 10;
            this.tabReg.Location = new System.Drawing.Point(4, 38);
            this.tabReg.Name = "tabReg";
            this.tabReg.Size = new System.Drawing.Size(706, 564);
            this.tabReg.TabIndex = 2;
            this.tabReg.Text = "Registo";
            this.tabReg.VerticalScrollbarBarColor = true;
            this.tabReg.VerticalScrollbarHighlightOnWheel = false;
            this.tabReg.VerticalScrollbarSize = 10;
            // 
            // btRegSubmeter
            // 
            this.btRegSubmeter.Location = new System.Drawing.Point(412, 518);
            this.btRegSubmeter.Name = "btRegSubmeter";
            this.btRegSubmeter.Size = new System.Drawing.Size(271, 30);
            this.btRegSubmeter.TabIndex = 68;
            this.btRegSubmeter.Text = "Submeter";
            this.btRegSubmeter.UseSelectable = true;
            // 
            // btRegLimpar
            // 
            this.btRegLimpar.Location = new System.Drawing.Point(125, 518);
            this.btRegLimpar.Name = "btRegLimpar";
            this.btRegLimpar.Size = new System.Drawing.Size(281, 30);
            this.btRegLimpar.TabIndex = 69;
            this.btRegLimpar.Text = "Limpar";
            this.btRegLimpar.UseSelectable = true;
            this.btRegLimpar.Click += new System.EventHandler(this.btRegLimpar_Click);
            // 
            // tbRegAdicionais
            // 
            // 
            // 
            // 
            this.tbRegAdicionais.CustomButton.Image = null;
            this.tbRegAdicionais.CustomButton.Location = new System.Drawing.Point(384, 1);
            this.tbRegAdicionais.CustomButton.Name = "";
            this.tbRegAdicionais.CustomButton.Size = new System.Drawing.Size(173, 173);
            this.tbRegAdicionais.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbRegAdicionais.CustomButton.TabIndex = 1;
            this.tbRegAdicionais.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbRegAdicionais.CustomButton.UseSelectable = true;
            this.tbRegAdicionais.CustomButton.Visible = false;
            this.tbRegAdicionais.Lines = new string[0];
            this.tbRegAdicionais.Location = new System.Drawing.Point(125, 320);
            this.tbRegAdicionais.MaxLength = 32767;
            this.tbRegAdicionais.Multiline = true;
            this.tbRegAdicionais.Name = "tbRegAdicionais";
            this.tbRegAdicionais.PasswordChar = '\0';
            this.tbRegAdicionais.PromptText = "Anotações adicionais";
            this.tbRegAdicionais.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRegAdicionais.SelectedText = "";
            this.tbRegAdicionais.SelectionLength = 0;
            this.tbRegAdicionais.SelectionStart = 0;
            this.tbRegAdicionais.ShortcutsEnabled = true;
            this.tbRegAdicionais.Size = new System.Drawing.Size(558, 175);
            this.tbRegAdicionais.TabIndex = 75;
            this.tbRegAdicionais.UseSelectable = true;
            this.tbRegAdicionais.WaterMark = "Anotações adicionais";
            this.tbRegAdicionais.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbRegAdicionais.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 70;
            this.metroLabel1.Text = "Nome: ⁎";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(16, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 19);
            this.metroLabel2.TabIndex = 73;
            this.metroLabel2.Text = "Exemplar(es): ⁎";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(16, 320);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 71;
            this.metroLabel4.Text = "Adicionais:";
            // 
            // cbRegNome
            // 
            this.cbRegNome.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRegNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRegNome.FormattingEnabled = true;
            this.cbRegNome.Location = new System.Drawing.Point(125, 33);
            this.cbRegNome.Name = "cbRegNome";
            this.cbRegNome.Size = new System.Drawing.Size(558, 21);
            this.cbRegNome.TabIndex = 79;
            // 
            // cbRegEquipamento
            // 
            this.cbRegEquipamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRegEquipamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRegEquipamento.FormattingEnabled = true;
            this.cbRegEquipamento.Location = new System.Drawing.Point(125, 70);
            this.cbRegEquipamento.Name = "cbRegEquipamento";
            this.cbRegEquipamento.Size = new System.Drawing.Size(558, 21);
            this.cbRegEquipamento.TabIndex = 81;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(16, 70);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(100, 19);
            this.metroLabel6.TabIndex = 80;
            this.metroLabel6.Text = "Equipamento: ⁎";
            // 
            // listRegLista
            // 
            this.listRegLista.Font = new System.Drawing.Font("Cascadia Code Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRegLista.FormattingEnabled = true;
            this.listRegLista.ItemHeight = 17;
            this.listRegLista.Items.AddRange(new object[] {
            "ESHNT101",
            "ESHNT102",
            "ESHNT103",
            "ESHNT104",
            "ESHNT105",
            "ESHNT108",
            "ESHNT120",
            "ESHNT111"});
            this.listRegLista.Location = new System.Drawing.Point(125, 113);
            this.listRegLista.Name = "listRegLista";
            this.listRegLista.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listRegLista.Size = new System.Drawing.Size(252, 191);
            this.listRegLista.TabIndex = 83;
            // 
            // btRegSelecionar
            // 
            this.btRegSelecionar.Location = new System.Drawing.Point(383, 164);
            this.btRegSelecionar.Name = "btRegSelecionar";
            this.btRegSelecionar.Size = new System.Drawing.Size(39, 29);
            this.btRegSelecionar.TabIndex = 84;
            this.btRegSelecionar.Text = "»";
            this.btRegSelecionar.UseSelectable = true;
            // 
            // btRegDeselecionar
            // 
            this.btRegDeselecionar.Location = new System.Drawing.Point(383, 218);
            this.btRegDeselecionar.Name = "btRegDeselecionar";
            this.btRegDeselecionar.Size = new System.Drawing.Size(39, 29);
            this.btRegDeselecionar.TabIndex = 85;
            this.btRegDeselecionar.Text = "«";
            this.btRegDeselecionar.UseSelectable = true;
            // 
            // listRegSelecionados
            // 
            this.listRegSelecionados.Font = new System.Drawing.Font("Cascadia Code Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRegSelecionados.FormattingEnabled = true;
            this.listRegSelecionados.ItemHeight = 17;
            this.listRegSelecionados.Location = new System.Drawing.Point(428, 113);
            this.listRegSelecionados.Name = "listRegSelecionados";
            this.listRegSelecionados.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listRegSelecionados.Size = new System.Drawing.Size(255, 191);
            this.listRegSelecionados.TabIndex = 86;
            // 
            // Equipamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 698);
            this.ControlBox = false;
            this.Controls.Add(this.tabLista);
            this.Controls.Add(this.tabRegisto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Equipamentos";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Equipamentos";
            this.Load += new System.EventHandler(this.Equipamentos_Load);
            this.tabRegisto.ResumeLayout(false);
            this.tabEquipamentos.ResumeLayout(false);
            this.tabEquipamentos.PerformLayout();
            this.tabLista.ResumeLayout(false);
            this.tabLista1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            this.tabAtivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAtivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEquipQuantidade)).EndInit();
            this.tabReg.ResumeLayout(false);
            this.tabReg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabRegisto;
        private MetroFramework.Controls.MetroTabPage tabEquipamentos;
        private MetroFramework.Controls.MetroTabControl tabLista;
        private MetroFramework.Controls.MetroTabPage tabLista1;
        private MetroFramework.Controls.MetroButton btDeletar;
        private MetroFramework.Controls.MetroButton btAlterar;
        private MetroFramework.Controls.MetroGrid gridLista;
        private MetroFramework.Controls.MetroTabPage tabAtivos;
        private MetroFramework.Controls.MetroGrid gridAtivos;
        private MetroFramework.Controls.MetroButton btEquipSubmeter;
        private MetroFramework.Controls.MetroButton btEquipLimpar;
        private MetroFramework.Controls.MetroTextBox tbEquipCodigo;
        private MetroFramework.Controls.MetroTextBox tbEquipAdicionais;
        private MetroFramework.Controls.MetroTextBox tbEquipDesignacao;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroToggle tgEquipQuantidade;
        private System.Windows.Forms.NumericUpDown nudEquipQuantidade;
        private MetroFramework.Controls.MetroTabPage tabReg;
        private MetroFramework.Controls.MetroButton btRegSubmeter;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btRegLimpar;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbRegAdicionais;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox cbRegNome;
        private System.Windows.Forms.ComboBox cbRegEquipamento;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ListBox listRegLista;
        private MetroFramework.Controls.MetroButton btRegDeselecionar;
        private MetroFramework.Controls.MetroButton btRegSelecionar;
        private System.Windows.Forms.ListBox listRegSelecionados;
    }
}