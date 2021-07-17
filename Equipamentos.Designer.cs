
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabRegisto = new MetroFramework.Controls.MetroTabControl();
            this.pageRegisto = new MetroFramework.Controls.MetroTabPage();
            this.btEquipSubmeter = new MetroFramework.Controls.MetroButton();
            this.btEquipLimpar = new MetroFramework.Controls.MetroButton();
            this.tbEquipCodigo = new MetroFramework.Controls.MetroTextBox();
            this.nudEquipQuant = new System.Windows.Forms.NumericUpDown();
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
            this.tabRegisto.SuspendLayout();
            this.pageRegisto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEquipQuant)).BeginInit();
            this.tabLista.SuspendLayout();
            this.tabLista1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            this.tabAtivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtivos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRegisto
            // 
            this.tabRegisto.Controls.Add(this.pageRegisto);
            this.tabRegisto.Location = new System.Drawing.Point(23, 63);
            this.tabRegisto.Name = "tabRegisto";
            this.tabRegisto.SelectedIndex = 0;
            this.tabRegisto.Size = new System.Drawing.Size(714, 606);
            this.tabRegisto.Style = MetroFramework.MetroColorStyle.Green;
            this.tabRegisto.TabIndex = 1;
            this.tabRegisto.UseSelectable = true;
            // 
            // pageRegisto
            // 
            this.pageRegisto.Controls.Add(this.btEquipSubmeter);
            this.pageRegisto.Controls.Add(this.btEquipLimpar);
            this.pageRegisto.Controls.Add(this.tbEquipCodigo);
            this.pageRegisto.Controls.Add(this.nudEquipQuant);
            this.pageRegisto.Controls.Add(this.tbEquipAdicionais);
            this.pageRegisto.Controls.Add(this.tbEquipDesignacao);
            this.pageRegisto.Controls.Add(this.metroLabel10);
            this.pageRegisto.Controls.Add(this.metroLabel9);
            this.pageRegisto.Controls.Add(this.metroLabel3);
            this.pageRegisto.Controls.Add(this.metroLabel8);
            this.pageRegisto.HorizontalScrollbarBarColor = true;
            this.pageRegisto.HorizontalScrollbarHighlightOnWheel = false;
            this.pageRegisto.HorizontalScrollbarSize = 10;
            this.pageRegisto.Location = new System.Drawing.Point(4, 38);
            this.pageRegisto.Name = "pageRegisto";
            this.pageRegisto.Size = new System.Drawing.Size(706, 564);
            this.pageRegisto.TabIndex = 1;
            this.pageRegisto.Text = "Registo";
            this.pageRegisto.VerticalScrollbarBarColor = true;
            this.pageRegisto.VerticalScrollbarHighlightOnWheel = false;
            this.pageRegisto.VerticalScrollbarSize = 10;
            // 
            // btEquipSubmeter
            // 
            this.btEquipSubmeter.Location = new System.Drawing.Point(412, 518);
            this.btEquipSubmeter.Name = "btEquipSubmeter";
            this.btEquipSubmeter.Size = new System.Drawing.Size(280, 30);
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
            // 
            // tbEquipCodigo
            // 
            // 
            // 
            // 
            this.tbEquipCodigo.CustomButton.Image = null;
            this.tbEquipCodigo.CustomButton.Location = new System.Drawing.Point(545, 1);
            this.tbEquipCodigo.CustomButton.Name = "";
            this.tbEquipCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbEquipCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbEquipCodigo.CustomButton.TabIndex = 1;
            this.tbEquipCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbEquipCodigo.CustomButton.UseSelectable = true;
            this.tbEquipCodigo.CustomButton.Visible = false;
            this.tbEquipCodigo.Lines = new string[0];
            this.tbEquipCodigo.Location = new System.Drawing.Point(125, 68);
            this.tbEquipCodigo.MaxLength = 32767;
            this.tbEquipCodigo.Name = "tbEquipCodigo";
            this.tbEquipCodigo.PasswordChar = '\0';
            this.tbEquipCodigo.PromptText = "Código/Etiqueta do exemplar";
            this.tbEquipCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEquipCodigo.SelectedText = "";
            this.tbEquipCodigo.SelectionLength = 0;
            this.tbEquipCodigo.SelectionStart = 0;
            this.tbEquipCodigo.ShortcutsEnabled = true;
            this.tbEquipCodigo.Size = new System.Drawing.Size(567, 23);
            this.tbEquipCodigo.TabIndex = 64;
            this.tbEquipCodigo.UseSelectable = true;
            this.tbEquipCodigo.WaterMark = "Código/Etiqueta do exemplar";
            this.tbEquipCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbEquipCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nudEquipQuant
            // 
            this.nudEquipQuant.Location = new System.Drawing.Point(125, 106);
            this.nudEquipQuant.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudEquipQuant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEquipQuant.Name = "nudEquipQuant";
            this.nudEquipQuant.Size = new System.Drawing.Size(151, 20);
            this.nudEquipQuant.TabIndex = 63;
            this.nudEquipQuant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbEquipAdicionais
            // 
            // 
            // 
            // 
            this.tbEquipAdicionais.CustomButton.Image = null;
            this.tbEquipAdicionais.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.tbEquipAdicionais.CustomButton.Name = "";
            this.tbEquipAdicionais.CustomButton.Size = new System.Drawing.Size(345, 345);
            this.tbEquipAdicionais.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbEquipAdicionais.CustomButton.TabIndex = 1;
            this.tbEquipAdicionais.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbEquipAdicionais.CustomButton.UseSelectable = true;
            this.tbEquipAdicionais.CustomButton.Visible = false;
            this.tbEquipAdicionais.Lines = new string[0];
            this.tbEquipAdicionais.Location = new System.Drawing.Point(125, 148);
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
            this.tbEquipAdicionais.Size = new System.Drawing.Size(567, 347);
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
            this.tbEquipDesignacao.CustomButton.Location = new System.Drawing.Point(545, 1);
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
            this.tbEquipDesignacao.Size = new System.Drawing.Size(567, 23);
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
            this.metroLabel9.Location = new System.Drawing.Point(15, 68);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(56, 19);
            this.metroLabel9.TabIndex = 60;
            this.metroLabel9.Text = "Código:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(16, 148);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 57;
            this.metroLabel3.Text = "Adicionais:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(16, 106);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 19);
            this.metroLabel8.TabIndex = 59;
            this.metroLabel8.Text = "Quantidade:";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridLista.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridLista.EnableHeadersVisualStyles = false;
            this.gridLista.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridLista.Location = new System.Drawing.Point(17, 18);
            this.gridLista.Name = "gridLista";
            this.gridLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAtivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridAtivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAtivos.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridAtivos.EnableHeadersVisualStyles = false;
            this.gridAtivos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridAtivos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridAtivos.Location = new System.Drawing.Point(17, 18);
            this.gridAtivos.Name = "gridAtivos";
            this.gridAtivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAtivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridAtivos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridAtivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAtivos.Size = new System.Drawing.Size(573, 477);
            this.gridAtivos.TabIndex = 2;
            this.gridAtivos.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.pageRegisto.ResumeLayout(false);
            this.pageRegisto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEquipQuant)).EndInit();
            this.tabLista.ResumeLayout(false);
            this.tabLista1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            this.tabAtivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAtivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabRegisto;
        private MetroFramework.Controls.MetroTabPage pageRegisto;
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
        private System.Windows.Forms.NumericUpDown nudEquipQuant;
        private MetroFramework.Controls.MetroTextBox tbEquipAdicionais;
        private MetroFramework.Controls.MetroTextBox tbEquipDesignacao;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}