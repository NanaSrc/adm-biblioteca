
namespace biblioteca
{
    partial class Espacos
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
            this.btDeletar = new MetroFramework.Controls.MetroButton();
            this.btAlterar = new MetroFramework.Controls.MetroButton();
            this.gridLista = new MetroFramework.Controls.MetroGrid();
            this.tbNotas = new MetroFramework.Controls.MetroTextBox();
            this.tbDesignacao = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.tbInicio = new MetroFramework.Controls.MetroTextBox();
            this.tbFim = new MetroFramework.Controls.MetroTextBox();
            this.btLimpar = new MetroFramework.Controls.MetroButton();
            this.btSubmeter = new MetroFramework.Controls.MetroButton();
            this.tabLista = new MetroFramework.Controls.MetroTabControl();
            this.tabLista1 = new MetroFramework.Controls.MetroTabPage();
            this.tabAtivos = new MetroFramework.Controls.MetroTabPage();
            this.gridAtivos = new MetroFramework.Controls.MetroGrid();
            this.tabRegisto.SuspendLayout();
            this.pageRegisto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            this.tabLista.SuspendLayout();
            this.tabLista1.SuspendLayout();
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
            this.tabRegisto.Style = MetroFramework.MetroColorStyle.Teal;
            this.tabRegisto.TabIndex = 0;
            this.tabRegisto.UseSelectable = true;
            // 
            // pageRegisto
            // 
            this.pageRegisto.Controls.Add(this.btSubmeter);
            this.pageRegisto.Controls.Add(this.btLimpar);
            this.pageRegisto.Controls.Add(this.tbFim);
            this.pageRegisto.Controls.Add(this.tbInicio);
            this.pageRegisto.Controls.Add(this.nudMax);
            this.pageRegisto.Controls.Add(this.tbNotas);
            this.pageRegisto.Controls.Add(this.tbDesignacao);
            this.pageRegisto.Controls.Add(this.metroLabel10);
            this.pageRegisto.Controls.Add(this.metroLabel9);
            this.pageRegisto.Controls.Add(this.metroLabel3);
            this.pageRegisto.Controls.Add(this.metroLabel8);
            this.pageRegisto.Controls.Add(this.metroLabel6);
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
            // tbNotas
            // 
            // 
            // 
            // 
            this.tbNotas.CustomButton.Image = null;
            this.tbNotas.CustomButton.Location = new System.Drawing.Point(275, 1);
            this.tbNotas.CustomButton.Name = "";
            this.tbNotas.CustomButton.Size = new System.Drawing.Size(291, 291);
            this.tbNotas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNotas.CustomButton.TabIndex = 1;
            this.tbNotas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNotas.CustomButton.UseSelectable = true;
            this.tbNotas.CustomButton.Visible = false;
            this.tbNotas.Lines = new string[0];
            this.tbNotas.Location = new System.Drawing.Point(113, 202);
            this.tbNotas.MaxLength = 32767;
            this.tbNotas.Multiline = true;
            this.tbNotas.Name = "tbNotas";
            this.tbNotas.PasswordChar = '\0';
            this.tbNotas.PromptText = "Anotações adicionais";
            this.tbNotas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNotas.SelectedText = "";
            this.tbNotas.SelectionLength = 0;
            this.tbNotas.SelectionStart = 0;
            this.tbNotas.ShortcutsEnabled = true;
            this.tbNotas.Size = new System.Drawing.Size(567, 293);
            this.tbNotas.TabIndex = 50;
            this.tbNotas.UseSelectable = true;
            this.tbNotas.WaterMark = "Anotações adicionais";
            this.tbNotas.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNotas.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbDesignacao
            // 
            // 
            // 
            // 
            this.tbDesignacao.CustomButton.Image = null;
            this.tbDesignacao.CustomButton.Location = new System.Drawing.Point(545, 1);
            this.tbDesignacao.CustomButton.Name = "";
            this.tbDesignacao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDesignacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDesignacao.CustomButton.TabIndex = 1;
            this.tbDesignacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDesignacao.CustomButton.UseSelectable = true;
            this.tbDesignacao.CustomButton.Visible = false;
            this.tbDesignacao.Lines = new string[0];
            this.tbDesignacao.Location = new System.Drawing.Point(113, 46);
            this.tbDesignacao.MaxLength = 32767;
            this.tbDesignacao.Name = "tbDesignacao";
            this.tbDesignacao.PasswordChar = '\0';
            this.tbDesignacao.PromptText = "Designação do espaço";
            this.tbDesignacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDesignacao.SelectedText = "";
            this.tbDesignacao.SelectionLength = 0;
            this.tbDesignacao.SelectionStart = 0;
            this.tbDesignacao.ShortcutsEnabled = true;
            this.tbDesignacao.Size = new System.Drawing.Size(567, 23);
            this.tbDesignacao.TabIndex = 47;
            this.tbDesignacao.UseSelectable = true;
            this.tbDesignacao.WaterMark = "Designação do espaço";
            this.tbDesignacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDesignacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(3, 46);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(89, 19);
            this.metroLabel10.TabIndex = 42;
            this.metroLabel10.Text = "Designação: ⁎";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 202);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 43;
            this.metroLabel3.Text = "Adicionais:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(4, 119);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(94, 19);
            this.metroLabel8.TabIndex = 45;
            this.metroLabel8.Text = "Hora de início:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(4, 159);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(83, 19);
            this.metroLabel6.TabIndex = 44;
            this.metroLabel6.Text = "Hora de fim:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(3, 81);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(88, 19);
            this.metroLabel9.TabIndex = 46;
            this.metroLabel9.Text = "Máx. Pessoas:";
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(113, 81);
            this.nudMax.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.nudMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(151, 20);
            this.nudMax.TabIndex = 51;
            this.nudMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbInicio
            // 
            // 
            // 
            // 
            this.tbInicio.CustomButton.Image = null;
            this.tbInicio.CustomButton.Location = new System.Drawing.Point(545, 1);
            this.tbInicio.CustomButton.Name = "";
            this.tbInicio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbInicio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbInicio.CustomButton.TabIndex = 1;
            this.tbInicio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbInicio.CustomButton.UseSelectable = true;
            this.tbInicio.CustomButton.Visible = false;
            this.tbInicio.Lines = new string[0];
            this.tbInicio.Location = new System.Drawing.Point(113, 119);
            this.tbInicio.MaxLength = 32767;
            this.tbInicio.Name = "tbInicio";
            this.tbInicio.PasswordChar = '\0';
            this.tbInicio.PromptText = "Horário de abertura";
            this.tbInicio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbInicio.SelectedText = "";
            this.tbInicio.SelectionLength = 0;
            this.tbInicio.SelectionStart = 0;
            this.tbInicio.ShortcutsEnabled = true;
            this.tbInicio.Size = new System.Drawing.Size(567, 23);
            this.tbInicio.TabIndex = 52;
            this.tbInicio.UseSelectable = true;
            this.tbInicio.WaterMark = "Horário de abertura";
            this.tbInicio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbInicio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbFim
            // 
            // 
            // 
            // 
            this.tbFim.CustomButton.Image = null;
            this.tbFim.CustomButton.Location = new System.Drawing.Point(545, 1);
            this.tbFim.CustomButton.Name = "";
            this.tbFim.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbFim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbFim.CustomButton.TabIndex = 1;
            this.tbFim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbFim.CustomButton.UseSelectable = true;
            this.tbFim.CustomButton.Visible = false;
            this.tbFim.Lines = new string[0];
            this.tbFim.Location = new System.Drawing.Point(113, 159);
            this.tbFim.MaxLength = 32767;
            this.tbFim.Name = "tbFim";
            this.tbFim.PasswordChar = '\0';
            this.tbFim.PromptText = "Horário de encerramento";
            this.tbFim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFim.SelectedText = "";
            this.tbFim.SelectionLength = 0;
            this.tbFim.SelectionStart = 0;
            this.tbFim.ShortcutsEnabled = true;
            this.tbFim.Size = new System.Drawing.Size(567, 23);
            this.tbFim.TabIndex = 53;
            this.tbFim.UseSelectable = true;
            this.tbFim.WaterMark = "Horário de encerramento";
            this.tbFim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbFim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(112, 518);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(281, 30);
            this.btLimpar.TabIndex = 13;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseSelectable = true;
            // 
            // btSubmeter
            // 
            this.btSubmeter.Location = new System.Drawing.Point(400, 518);
            this.btSubmeter.Name = "btSubmeter";
            this.btSubmeter.Size = new System.Drawing.Size(280, 30);
            this.btSubmeter.TabIndex = 12;
            this.btSubmeter.Text = "Submeter";
            this.btSubmeter.UseSelectable = true;
            // 
            // tabLista
            // 
            this.tabLista.Controls.Add(this.tabLista1);
            this.tabLista.Controls.Add(this.tabAtivos);
            this.tabLista.Location = new System.Drawing.Point(743, 63);
            this.tabLista.Name = "tabLista";
            this.tabLista.SelectedIndex = 0;
            this.tabLista.Size = new System.Drawing.Size(614, 606);
            this.tabLista.Style = MetroFramework.MetroColorStyle.Teal;
            this.tabLista.TabIndex = 14;
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
            // Espacos
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
            this.Name = "Espacos";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Espaços";
            this.Load += new System.EventHandler(this.Salas_Load);
            this.tabRegisto.ResumeLayout(false);
            this.pageRegisto.ResumeLayout(false);
            this.pageRegisto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            this.tabLista.ResumeLayout(false);
            this.tabLista1.ResumeLayout(false);
            this.tabAtivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAtivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabRegisto;
        private MetroFramework.Controls.MetroTabPage pageRegisto;
        private MetroFramework.Controls.MetroButton btDeletar;
        private MetroFramework.Controls.MetroButton btAlterar;
        private MetroFramework.Controls.MetroGrid gridLista;
        private MetroFramework.Controls.MetroTextBox tbNotas;
        private MetroFramework.Controls.MetroTextBox tbDesignacao;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox tbFim;
        private MetroFramework.Controls.MetroTextBox tbInicio;
        private System.Windows.Forms.NumericUpDown nudMax;
        private MetroFramework.Controls.MetroButton btLimpar;
        private MetroFramework.Controls.MetroButton btSubmeter;
        private MetroFramework.Controls.MetroTabControl tabLista;
        private MetroFramework.Controls.MetroTabPage tabLista1;
        private MetroFramework.Controls.MetroTabPage tabAtivos;
        private MetroFramework.Controls.MetroGrid gridAtivos;
    }
}