
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabRegisto = new MetroFramework.Controls.MetroTabControl();
            this.tabNovoRegisto = new MetroFramework.Controls.MetroTabPage();
            this.dtRegData = new MetroFramework.Controls.MetroDateTime();
            this.lbRegData = new MetroFramework.Controls.MetroLabel();
            this.tbRegSaida = new MetroFramework.Controls.MetroTextBox();
            this.lbSaida = new MetroFramework.Controls.MetroLabel();
            this.cbRegNome = new System.Windows.Forms.ComboBox();
            this.btRegSubmeter = new MetroFramework.Controls.MetroButton();
            this.btRegLimpar = new MetroFramework.Controls.MetroButton();
            this.tbRegTurma = new MetroFramework.Controls.MetroTextBox();
            this.tbRegEntrada = new MetroFramework.Controls.MetroTextBox();
            this.nudRegPessoas = new System.Windows.Forms.NumericUpDown();
            this.tbRegAdicionais = new MetroFramework.Controls.MetroTextBox();
            this.lbRegNome = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lbEntrada = new MetroFramework.Controls.MetroLabel();
            this.lbRegTurma = new MetroFramework.Controls.MetroLabel();
            this.tabEspaco = new MetroFramework.Controls.MetroTabPage();
            this.tgEspPessoas = new MetroFramework.Controls.MetroToggle();
            this.nudEspMax = new System.Windows.Forms.NumericUpDown();
            this.btEspSubmeter = new MetroFramework.Controls.MetroButton();
            this.btEspLimpar = new MetroFramework.Controls.MetroButton();
            this.tbEspEncerramento = new MetroFramework.Controls.MetroTextBox();
            this.tbEspAbertura = new MetroFramework.Controls.MetroTextBox();
            this.tbEspAdicionais = new MetroFramework.Controls.MetroTextBox();
            this.tbEspDesignacao = new MetroFramework.Controls.MetroTextBox();
            this.lbDesignacao = new MetroFramework.Controls.MetroLabel();
            this.lbMax = new MetroFramework.Controls.MetroLabel();
            this.lbAdicionais = new MetroFramework.Controls.MetroLabel();
            this.lbInicio = new MetroFramework.Controls.MetroLabel();
            this.lbFim = new MetroFramework.Controls.MetroLabel();
            this.btDeletar = new MetroFramework.Controls.MetroButton();
            this.btAlterar = new MetroFramework.Controls.MetroButton();
            this.gridLista = new MetroFramework.Controls.MetroGrid();
            this.tabLista = new MetroFramework.Controls.MetroTabControl();
            this.tabLista1 = new MetroFramework.Controls.MetroTabPage();
            this.tabAtivos = new MetroFramework.Controls.MetroTabPage();
            this.gridAtivos = new MetroFramework.Controls.MetroGrid();
            this.tabRegisto.SuspendLayout();
            this.tabNovoRegisto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegPessoas)).BeginInit();
            this.tabEspaco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEspMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            this.tabLista.SuspendLayout();
            this.tabLista1.SuspendLayout();
            this.tabAtivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtivos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRegisto
            // 
            this.tabRegisto.Controls.Add(this.tabNovoRegisto);
            this.tabRegisto.Controls.Add(this.tabEspaco);
            this.tabRegisto.Location = new System.Drawing.Point(23, 63);
            this.tabRegisto.Name = "tabRegisto";
            this.tabRegisto.SelectedIndex = 0;
            this.tabRegisto.Size = new System.Drawing.Size(714, 606);
            this.tabRegisto.Style = MetroFramework.MetroColorStyle.Teal;
            this.tabRegisto.TabIndex = 0;
            this.tabRegisto.UseSelectable = true;
            // 
            // tabNovoRegisto
            // 
            this.tabNovoRegisto.Controls.Add(this.dtRegData);
            this.tabNovoRegisto.Controls.Add(this.lbRegData);
            this.tabNovoRegisto.Controls.Add(this.tbRegSaida);
            this.tabNovoRegisto.Controls.Add(this.lbSaida);
            this.tabNovoRegisto.Controls.Add(this.cbRegNome);
            this.tabNovoRegisto.Controls.Add(this.btRegSubmeter);
            this.tabNovoRegisto.Controls.Add(this.btRegLimpar);
            this.tabNovoRegisto.Controls.Add(this.tbRegTurma);
            this.tabNovoRegisto.Controls.Add(this.tbRegEntrada);
            this.tabNovoRegisto.Controls.Add(this.nudRegPessoas);
            this.tabNovoRegisto.Controls.Add(this.tbRegAdicionais);
            this.tabNovoRegisto.Controls.Add(this.lbRegNome);
            this.tabNovoRegisto.Controls.Add(this.metroLabel2);
            this.tabNovoRegisto.Controls.Add(this.metroLabel4);
            this.tabNovoRegisto.Controls.Add(this.lbEntrada);
            this.tabNovoRegisto.Controls.Add(this.lbRegTurma);
            this.tabNovoRegisto.HorizontalScrollbarBarColor = true;
            this.tabNovoRegisto.HorizontalScrollbarHighlightOnWheel = false;
            this.tabNovoRegisto.HorizontalScrollbarSize = 10;
            this.tabNovoRegisto.Location = new System.Drawing.Point(4, 38);
            this.tabNovoRegisto.Name = "tabNovoRegisto";
            this.tabNovoRegisto.Size = new System.Drawing.Size(706, 564);
            this.tabNovoRegisto.TabIndex = 2;
            this.tabNovoRegisto.Text = "Novo registo";
            this.tabNovoRegisto.VerticalScrollbarBarColor = true;
            this.tabNovoRegisto.VerticalScrollbarHighlightOnWheel = false;
            this.tabNovoRegisto.VerticalScrollbarSize = 10;
            // 
            // dtRegData
            // 
            this.dtRegData.Location = new System.Drawing.Point(125, 152);
            this.dtRegData.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtRegData.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtRegData.Name = "dtRegData";
            this.dtRegData.Size = new System.Drawing.Size(231, 29);
            this.dtRegData.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtRegData.TabIndex = 70;
            // 
            // lbRegData
            // 
            this.lbRegData.AutoSize = true;
            this.lbRegData.Location = new System.Drawing.Point(15, 152);
            this.lbRegData.Name = "lbRegData";
            this.lbRegData.Size = new System.Drawing.Size(49, 19);
            this.lbRegData.TabIndex = 69;
            this.lbRegData.Text = "Data: ⁎";
            // 
            // tbRegSaida
            // 
            // 
            // 
            // 
            this.tbRegSaida.CustomButton.Image = null;
            this.tbRegSaida.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.tbRegSaida.CustomButton.Name = "";
            this.tbRegSaida.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbRegSaida.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbRegSaida.CustomButton.TabIndex = 1;
            this.tbRegSaida.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbRegSaida.CustomButton.UseSelectable = true;
            this.tbRegSaida.CustomButton.Visible = false;
            this.tbRegSaida.Lines = new string[0];
            this.tbRegSaida.Location = new System.Drawing.Point(461, 109);
            this.tbRegSaida.MaxLength = 32767;
            this.tbRegSaida.Name = "tbRegSaida";
            this.tbRegSaida.PasswordChar = '\0';
            this.tbRegSaida.PromptText = "Saída";
            this.tbRegSaida.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRegSaida.SelectedText = "";
            this.tbRegSaida.SelectionLength = 0;
            this.tbRegSaida.SelectionStart = 0;
            this.tbRegSaida.ShortcutsEnabled = true;
            this.tbRegSaida.Size = new System.Drawing.Size(231, 23);
            this.tbRegSaida.TabIndex = 68;
            this.tbRegSaida.UseSelectable = true;
            this.tbRegSaida.WaterMark = "Saída";
            this.tbRegSaida.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbRegSaida.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbSaida
            // 
            this.lbSaida.AutoSize = true;
            this.lbSaida.Location = new System.Drawing.Point(362, 109);
            this.lbSaida.Name = "lbSaida";
            this.lbSaida.Size = new System.Drawing.Size(93, 19);
            this.lbSaida.TabIndex = 67;
            this.lbSaida.Text = "Hora de fim: ⁎";
            // 
            // cbRegNome
            // 
            this.cbRegNome.FormattingEnabled = true;
            this.cbRegNome.Location = new System.Drawing.Point(125, 28);
            this.cbRegNome.Name = "cbRegNome";
            this.cbRegNome.Size = new System.Drawing.Size(567, 21);
            this.cbRegNome.TabIndex = 66;
            // 
            // btRegSubmeter
            // 
            this.btRegSubmeter.Location = new System.Drawing.Point(412, 518);
            this.btRegSubmeter.Name = "btRegSubmeter";
            this.btRegSubmeter.Size = new System.Drawing.Size(280, 30);
            this.btRegSubmeter.TabIndex = 54;
            this.btRegSubmeter.Text = "Submeter";
            this.btRegSubmeter.UseSelectable = true;
            // 
            // btRegLimpar
            // 
            this.btRegLimpar.Location = new System.Drawing.Point(125, 518);
            this.btRegLimpar.Name = "btRegLimpar";
            this.btRegLimpar.Size = new System.Drawing.Size(281, 30);
            this.btRegLimpar.TabIndex = 55;
            this.btRegLimpar.Text = "Limpar";
            this.btRegLimpar.UseSelectable = true;
            this.btRegLimpar.Click += new System.EventHandler(this.btRegLimpar_Click);
            // 
            // tbRegTurma
            // 
            // 
            // 
            // 
            this.tbRegTurma.CustomButton.Image = null;
            this.tbRegTurma.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.tbRegTurma.CustomButton.Name = "";
            this.tbRegTurma.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbRegTurma.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbRegTurma.CustomButton.TabIndex = 1;
            this.tbRegTurma.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbRegTurma.CustomButton.UseSelectable = true;
            this.tbRegTurma.CustomButton.Visible = false;
            this.tbRegTurma.Lines = new string[0];
            this.tbRegTurma.Location = new System.Drawing.Point(125, 67);
            this.tbRegTurma.MaxLength = 32767;
            this.tbRegTurma.Name = "tbRegTurma";
            this.tbRegTurma.PasswordChar = '\0';
            this.tbRegTurma.PromptText = "Turma que vai utilizar o espaço";
            this.tbRegTurma.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRegTurma.SelectedText = "";
            this.tbRegTurma.SelectionLength = 0;
            this.tbRegTurma.SelectionStart = 0;
            this.tbRegTurma.ShortcutsEnabled = true;
            this.tbRegTurma.Size = new System.Drawing.Size(231, 23);
            this.tbRegTurma.TabIndex = 65;
            this.tbRegTurma.UseSelectable = true;
            this.tbRegTurma.WaterMark = "Turma que vai utilizar o espaço";
            this.tbRegTurma.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbRegTurma.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbRegEntrada
            // 
            // 
            // 
            // 
            this.tbRegEntrada.CustomButton.Image = null;
            this.tbRegEntrada.CustomButton.Location = new System.Drawing.Point(209, 1);
            this.tbRegEntrada.CustomButton.Name = "";
            this.tbRegEntrada.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbRegEntrada.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbRegEntrada.CustomButton.TabIndex = 1;
            this.tbRegEntrada.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbRegEntrada.CustomButton.UseSelectable = true;
            this.tbRegEntrada.CustomButton.Visible = false;
            this.tbRegEntrada.Lines = new string[0];
            this.tbRegEntrada.Location = new System.Drawing.Point(125, 109);
            this.tbRegEntrada.MaxLength = 32767;
            this.tbRegEntrada.Name = "tbRegEntrada";
            this.tbRegEntrada.PasswordChar = '\0';
            this.tbRegEntrada.PromptText = "Entrada";
            this.tbRegEntrada.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRegEntrada.SelectedText = "";
            this.tbRegEntrada.SelectionLength = 0;
            this.tbRegEntrada.SelectionStart = 0;
            this.tbRegEntrada.ShortcutsEnabled = true;
            this.tbRegEntrada.Size = new System.Drawing.Size(231, 23);
            this.tbRegEntrada.TabIndex = 64;
            this.tbRegEntrada.UseSelectable = true;
            this.tbRegEntrada.WaterMark = "Entrada";
            this.tbRegEntrada.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbRegEntrada.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nudRegPessoas
            // 
            this.nudRegPessoas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRegPessoas.Location = new System.Drawing.Point(461, 67);
            this.nudRegPessoas.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.nudRegPessoas.Name = "nudRegPessoas";
            this.nudRegPessoas.Size = new System.Drawing.Size(231, 22);
            this.nudRegPessoas.TabIndex = 63;
            this.nudRegPessoas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbRegAdicionais
            // 
            // 
            // 
            // 
            this.tbRegAdicionais.CustomButton.Image = null;
            this.tbRegAdicionais.CustomButton.Location = new System.Drawing.Point(277, 2);
            this.tbRegAdicionais.CustomButton.Name = "";
            this.tbRegAdicionais.CustomButton.Size = new System.Drawing.Size(287, 287);
            this.tbRegAdicionais.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbRegAdicionais.CustomButton.TabIndex = 1;
            this.tbRegAdicionais.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbRegAdicionais.CustomButton.UseSelectable = true;
            this.tbRegAdicionais.CustomButton.Visible = false;
            this.tbRegAdicionais.Lines = new string[0];
            this.tbRegAdicionais.Location = new System.Drawing.Point(125, 203);
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
            this.tbRegAdicionais.Size = new System.Drawing.Size(567, 292);
            this.tbRegAdicionais.TabIndex = 62;
            this.tbRegAdicionais.UseSelectable = true;
            this.tbRegAdicionais.WaterMark = "Anotações adicionais";
            this.tbRegAdicionais.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbRegAdicionais.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbRegNome
            // 
            this.lbRegNome.AutoSize = true;
            this.lbRegNome.Location = new System.Drawing.Point(15, 31);
            this.lbRegNome.Name = "lbRegNome";
            this.lbRegNome.Size = new System.Drawing.Size(59, 19);
            this.lbRegNome.TabIndex = 56;
            this.lbRegNome.Text = "Nome: ⁎";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(376, 67);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 60;
            this.metroLabel2.Text = "Nº. Pessoas:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(15, 203);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 57;
            this.metroLabel4.Text = "Adicionais:";
            // 
            // lbEntrada
            // 
            this.lbEntrada.AutoSize = true;
            this.lbEntrada.Location = new System.Drawing.Point(15, 109);
            this.lbEntrada.Name = "lbEntrada";
            this.lbEntrada.Size = new System.Drawing.Size(104, 19);
            this.lbEntrada.TabIndex = 59;
            this.lbEntrada.Text = "Hora de início: ⁎";
            // 
            // lbRegTurma
            // 
            this.lbRegTurma.AutoSize = true;
            this.lbRegTurma.Location = new System.Drawing.Point(15, 71);
            this.lbRegTurma.Name = "lbRegTurma";
            this.lbRegTurma.Size = new System.Drawing.Size(48, 19);
            this.lbRegTurma.TabIndex = 58;
            this.lbRegTurma.Text = "Turma:";
            // 
            // tabEspaco
            // 
            this.tabEspaco.Controls.Add(this.tgEspPessoas);
            this.tabEspaco.Controls.Add(this.nudEspMax);
            this.tabEspaco.Controls.Add(this.btEspSubmeter);
            this.tabEspaco.Controls.Add(this.btEspLimpar);
            this.tabEspaco.Controls.Add(this.tbEspEncerramento);
            this.tabEspaco.Controls.Add(this.tbEspAbertura);
            this.tabEspaco.Controls.Add(this.tbEspAdicionais);
            this.tabEspaco.Controls.Add(this.tbEspDesignacao);
            this.tabEspaco.Controls.Add(this.lbDesignacao);
            this.tabEspaco.Controls.Add(this.lbMax);
            this.tabEspaco.Controls.Add(this.lbAdicionais);
            this.tabEspaco.Controls.Add(this.lbInicio);
            this.tabEspaco.Controls.Add(this.lbFim);
            this.tabEspaco.HorizontalScrollbarBarColor = true;
            this.tabEspaco.HorizontalScrollbarHighlightOnWheel = false;
            this.tabEspaco.HorizontalScrollbarSize = 10;
            this.tabEspaco.Location = new System.Drawing.Point(4, 38);
            this.tabEspaco.Name = "tabEspaco";
            this.tabEspaco.Size = new System.Drawing.Size(706, 564);
            this.tabEspaco.TabIndex = 1;
            this.tabEspaco.Text = "Novo espaço";
            this.tabEspaco.VerticalScrollbarBarColor = true;
            this.tabEspaco.VerticalScrollbarHighlightOnWheel = false;
            this.tabEspaco.VerticalScrollbarSize = 10;
            // 
            // tgEspPessoas
            // 
            this.tgEspPessoas.AutoSize = true;
            this.tgEspPessoas.Location = new System.Drawing.Point(125, 163);
            this.tgEspPessoas.Name = "tgEspPessoas";
            this.tgEspPessoas.Size = new System.Drawing.Size(80, 17);
            this.tgEspPessoas.Style = MetroFramework.MetroColorStyle.Teal;
            this.tgEspPessoas.TabIndex = 65;
            this.tgEspPessoas.Text = "Off";
            this.tgEspPessoas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tgEspPessoas.UseSelectable = true;
            this.tgEspPessoas.CheckedChanged += new System.EventHandler(this.tgEspPessoas_CheckedChanged);
            // 
            // nudEspMax
            // 
            this.nudEspMax.Enabled = false;
            this.nudEspMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEspMax.Location = new System.Drawing.Point(226, 161);
            this.nudEspMax.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.nudEspMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEspMax.Name = "nudEspMax";
            this.nudEspMax.Size = new System.Drawing.Size(466, 22);
            this.nudEspMax.TabIndex = 64;
            this.nudEspMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btEspSubmeter
            // 
            this.btEspSubmeter.Location = new System.Drawing.Point(412, 518);
            this.btEspSubmeter.Name = "btEspSubmeter";
            this.btEspSubmeter.Size = new System.Drawing.Size(280, 30);
            this.btEspSubmeter.TabIndex = 12;
            this.btEspSubmeter.Text = "Submeter";
            this.btEspSubmeter.UseSelectable = true;
            // 
            // btEspLimpar
            // 
            this.btEspLimpar.Location = new System.Drawing.Point(125, 518);
            this.btEspLimpar.Name = "btEspLimpar";
            this.btEspLimpar.Size = new System.Drawing.Size(281, 30);
            this.btEspLimpar.TabIndex = 13;
            this.btEspLimpar.Text = "Limpar";
            this.btEspLimpar.UseSelectable = true;
            this.btEspLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // tbEspEncerramento
            // 
            // 
            // 
            // 
            this.tbEspEncerramento.CustomButton.Image = null;
            this.tbEspEncerramento.CustomButton.Location = new System.Drawing.Point(545, 1);
            this.tbEspEncerramento.CustomButton.Name = "";
            this.tbEspEncerramento.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbEspEncerramento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbEspEncerramento.CustomButton.TabIndex = 1;
            this.tbEspEncerramento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbEspEncerramento.CustomButton.UseSelectable = true;
            this.tbEspEncerramento.CustomButton.Visible = false;
            this.tbEspEncerramento.Lines = new string[0];
            this.tbEspEncerramento.Location = new System.Drawing.Point(125, 117);
            this.tbEspEncerramento.MaxLength = 32767;
            this.tbEspEncerramento.Name = "tbEspEncerramento";
            this.tbEspEncerramento.PasswordChar = '\0';
            this.tbEspEncerramento.PromptText = "Horário de encerramento";
            this.tbEspEncerramento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEspEncerramento.SelectedText = "";
            this.tbEspEncerramento.SelectionLength = 0;
            this.tbEspEncerramento.SelectionStart = 0;
            this.tbEspEncerramento.ShortcutsEnabled = true;
            this.tbEspEncerramento.Size = new System.Drawing.Size(567, 23);
            this.tbEspEncerramento.TabIndex = 53;
            this.tbEspEncerramento.UseSelectable = true;
            this.tbEspEncerramento.WaterMark = "Horário de encerramento";
            this.tbEspEncerramento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbEspEncerramento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbEspAbertura
            // 
            // 
            // 
            // 
            this.tbEspAbertura.CustomButton.Image = null;
            this.tbEspAbertura.CustomButton.Location = new System.Drawing.Point(545, 1);
            this.tbEspAbertura.CustomButton.Name = "";
            this.tbEspAbertura.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbEspAbertura.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbEspAbertura.CustomButton.TabIndex = 1;
            this.tbEspAbertura.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbEspAbertura.CustomButton.UseSelectable = true;
            this.tbEspAbertura.CustomButton.Visible = false;
            this.tbEspAbertura.Lines = new string[0];
            this.tbEspAbertura.Location = new System.Drawing.Point(125, 75);
            this.tbEspAbertura.MaxLength = 32767;
            this.tbEspAbertura.Name = "tbEspAbertura";
            this.tbEspAbertura.PasswordChar = '\0';
            this.tbEspAbertura.PromptText = "Horário de abertura";
            this.tbEspAbertura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEspAbertura.SelectedText = "";
            this.tbEspAbertura.SelectionLength = 0;
            this.tbEspAbertura.SelectionStart = 0;
            this.tbEspAbertura.ShortcutsEnabled = true;
            this.tbEspAbertura.Size = new System.Drawing.Size(567, 23);
            this.tbEspAbertura.TabIndex = 52;
            this.tbEspAbertura.UseSelectable = true;
            this.tbEspAbertura.WaterMark = "Horário de abertura";
            this.tbEspAbertura.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbEspAbertura.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbEspAdicionais
            // 
            // 
            // 
            // 
            this.tbEspAdicionais.CustomButton.Image = null;
            this.tbEspAdicionais.CustomButton.Location = new System.Drawing.Point(279, 2);
            this.tbEspAdicionais.CustomButton.Name = "";
            this.tbEspAdicionais.CustomButton.Size = new System.Drawing.Size(285, 285);
            this.tbEspAdicionais.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbEspAdicionais.CustomButton.TabIndex = 1;
            this.tbEspAdicionais.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbEspAdicionais.CustomButton.UseSelectable = true;
            this.tbEspAdicionais.CustomButton.Visible = false;
            this.tbEspAdicionais.Lines = new string[0];
            this.tbEspAdicionais.Location = new System.Drawing.Point(125, 205);
            this.tbEspAdicionais.MaxLength = 32767;
            this.tbEspAdicionais.Multiline = true;
            this.tbEspAdicionais.Name = "tbEspAdicionais";
            this.tbEspAdicionais.PasswordChar = '\0';
            this.tbEspAdicionais.PromptText = "Anotações adicionais";
            this.tbEspAdicionais.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEspAdicionais.SelectedText = "";
            this.tbEspAdicionais.SelectionLength = 0;
            this.tbEspAdicionais.SelectionStart = 0;
            this.tbEspAdicionais.ShortcutsEnabled = true;
            this.tbEspAdicionais.Size = new System.Drawing.Size(567, 290);
            this.tbEspAdicionais.TabIndex = 50;
            this.tbEspAdicionais.UseSelectable = true;
            this.tbEspAdicionais.WaterMark = "Anotações adicionais";
            this.tbEspAdicionais.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbEspAdicionais.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbEspDesignacao
            // 
            // 
            // 
            // 
            this.tbEspDesignacao.CustomButton.Image = null;
            this.tbEspDesignacao.CustomButton.Location = new System.Drawing.Point(545, 1);
            this.tbEspDesignacao.CustomButton.Name = "";
            this.tbEspDesignacao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbEspDesignacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbEspDesignacao.CustomButton.TabIndex = 1;
            this.tbEspDesignacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbEspDesignacao.CustomButton.UseSelectable = true;
            this.tbEspDesignacao.CustomButton.Visible = false;
            this.tbEspDesignacao.Lines = new string[0];
            this.tbEspDesignacao.Location = new System.Drawing.Point(125, 31);
            this.tbEspDesignacao.MaxLength = 32767;
            this.tbEspDesignacao.Name = "tbEspDesignacao";
            this.tbEspDesignacao.PasswordChar = '\0';
            this.tbEspDesignacao.PromptText = "Designação do espaço";
            this.tbEspDesignacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEspDesignacao.SelectedText = "";
            this.tbEspDesignacao.SelectionLength = 0;
            this.tbEspDesignacao.SelectionStart = 0;
            this.tbEspDesignacao.ShortcutsEnabled = true;
            this.tbEspDesignacao.Size = new System.Drawing.Size(567, 23);
            this.tbEspDesignacao.TabIndex = 47;
            this.tbEspDesignacao.UseSelectable = true;
            this.tbEspDesignacao.WaterMark = "Designação do espaço";
            this.tbEspDesignacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbEspDesignacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbDesignacao
            // 
            this.lbDesignacao.AutoSize = true;
            this.lbDesignacao.Location = new System.Drawing.Point(15, 31);
            this.lbDesignacao.Name = "lbDesignacao";
            this.lbDesignacao.Size = new System.Drawing.Size(89, 19);
            this.lbDesignacao.TabIndex = 42;
            this.lbDesignacao.Text = "Designação: ⁎";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(15, 161);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(88, 19);
            this.lbMax.TabIndex = 46;
            this.lbMax.Text = "Máx. Pessoas:";
            // 
            // lbAdicionais
            // 
            this.lbAdicionais.AutoSize = true;
            this.lbAdicionais.Location = new System.Drawing.Point(15, 205);
            this.lbAdicionais.Name = "lbAdicionais";
            this.lbAdicionais.Size = new System.Drawing.Size(71, 19);
            this.lbAdicionais.TabIndex = 43;
            this.lbAdicionais.Text = "Adicionais:";
            // 
            // lbInicio
            // 
            this.lbInicio.AutoSize = true;
            this.lbInicio.Location = new System.Drawing.Point(15, 75);
            this.lbInicio.Name = "lbInicio";
            this.lbInicio.Size = new System.Drawing.Size(94, 19);
            this.lbInicio.TabIndex = 45;
            this.lbInicio.Text = "Hora de início:";
            // 
            // lbFim
            // 
            this.lbFim.AutoSize = true;
            this.lbFim.Location = new System.Drawing.Point(15, 117);
            this.lbFim.Name = "lbFim";
            this.lbFim.Size = new System.Drawing.Size(83, 19);
            this.lbFim.TabIndex = 44;
            this.lbFim.Text = "Hora de fim:";
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
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridLista.DefaultCellStyle = dataGridViewCellStyle38;
            this.gridLista.EnableHeadersVisualStyles = false;
            this.gridLista.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridLista.Location = new System.Drawing.Point(17, 18);
            this.gridLista.Name = "gridLista";
            this.gridLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.gridLista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLista.Size = new System.Drawing.Size(573, 477);
            this.gridLista.TabIndex = 0;
            this.gridLista.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // tabLista
            // 
            this.tabLista.Controls.Add(this.tabLista1);
            this.tabLista.Controls.Add(this.tabAtivos);
            this.tabLista.Location = new System.Drawing.Point(743, 63);
            this.tabLista.Name = "tabLista";
            this.tabLista.SelectedIndex = 0;
            this.tabLista.Size = new System.Drawing.Size(618, 606);
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
            this.tabLista1.Size = new System.Drawing.Size(610, 564);
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
            this.tabAtivos.Size = new System.Drawing.Size(610, 564);
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
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAtivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.gridAtivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAtivos.DefaultCellStyle = dataGridViewCellStyle41;
            this.gridAtivos.EnableHeadersVisualStyles = false;
            this.gridAtivos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridAtivos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridAtivos.Location = new System.Drawing.Point(17, 18);
            this.gridAtivos.Name = "gridAtivos";
            this.gridAtivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAtivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle42;
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
            this.tabNovoRegisto.ResumeLayout(false);
            this.tabNovoRegisto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegPessoas)).EndInit();
            this.tabEspaco.ResumeLayout(false);
            this.tabEspaco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEspMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            this.tabLista.ResumeLayout(false);
            this.tabLista1.ResumeLayout(false);
            this.tabAtivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAtivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabRegisto;
        private MetroFramework.Controls.MetroTabPage tabEspaco;
        private MetroFramework.Controls.MetroButton btDeletar;
        private MetroFramework.Controls.MetroButton btAlterar;
        private MetroFramework.Controls.MetroGrid gridLista;
        private MetroFramework.Controls.MetroTextBox tbEspAdicionais;
        private MetroFramework.Controls.MetroTextBox tbEspDesignacao;
        private MetroFramework.Controls.MetroLabel lbDesignacao;
        private MetroFramework.Controls.MetroLabel lbAdicionais;
        private MetroFramework.Controls.MetroLabel lbInicio;
        private MetroFramework.Controls.MetroLabel lbFim;
        private MetroFramework.Controls.MetroLabel lbMax;
        private MetroFramework.Controls.MetroTextBox tbEspEncerramento;
        private MetroFramework.Controls.MetroTextBox tbEspAbertura;
        private MetroFramework.Controls.MetroButton btEspLimpar;
        private MetroFramework.Controls.MetroButton btEspSubmeter;
        private MetroFramework.Controls.MetroTabControl tabLista;
        private MetroFramework.Controls.MetroTabPage tabLista1;
        private MetroFramework.Controls.MetroTabPage tabAtivos;
        private MetroFramework.Controls.MetroGrid gridAtivos;
        private MetroFramework.Controls.MetroTabPage tabNovoRegisto;
        private MetroFramework.Controls.MetroButton btRegSubmeter;
        private MetroFramework.Controls.MetroButton btRegLimpar;
        private MetroFramework.Controls.MetroTextBox tbRegTurma;
        private MetroFramework.Controls.MetroTextBox tbRegEntrada;
        private System.Windows.Forms.NumericUpDown nudRegPessoas;
        private MetroFramework.Controls.MetroTextBox tbRegAdicionais;
        private MetroFramework.Controls.MetroLabel lbRegNome;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lbEntrada;
        private MetroFramework.Controls.MetroLabel lbRegTurma;
        private System.Windows.Forms.ComboBox cbRegNome;
        private MetroFramework.Controls.MetroTextBox tbRegSaida;
        private MetroFramework.Controls.MetroLabel lbSaida;
        private MetroFramework.Controls.MetroDateTime dtRegData;
        private MetroFramework.Controls.MetroLabel lbRegData;
        private System.Windows.Forms.NumericUpDown nudEspMax;
        private MetroFramework.Controls.MetroToggle tgEspPessoas;
    }
}