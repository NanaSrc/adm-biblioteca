
namespace biblioteca
{
    partial class Utilizadores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabRegisto = new MetroFramework.Controls.MetroTabControl();
            this.pageAluno = new MetroFramework.Controls.MetroTabPage();
            this.btAluLimpar = new MetroFramework.Controls.MetroButton();
            this.btAluSubmeter = new MetroFramework.Controls.MetroButton();
            this.cbAluAno = new MetroFramework.Controls.MetroComboBox();
            this.tbAluAdicionais = new MetroFramework.Controls.MetroTextBox();
            this.tbAluTurma = new MetroFramework.Controls.MetroTextBox();
            this.tbAluProcesso = new MetroFramework.Controls.MetroTextBox();
            this.tbAluNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.pageProfessor = new MetroFramework.Controls.MetroTabPage();
            this.btProfLimpar = new MetroFramework.Controls.MetroButton();
            this.tbProfAdicionais = new MetroFramework.Controls.MetroTextBox();
            this.btProfSubmeter = new MetroFramework.Controls.MetroButton();
            this.tbProfProcesso = new MetroFramework.Controls.MetroTextBox();
            this.tbProfNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabLista = new MetroFramework.Controls.MetroTabControl();
            this.tabLista1 = new MetroFramework.Controls.MetroTabPage();
            this.listUtilizadores = new System.Windows.Forms.ListBox();
            this.btListaDeletar = new MetroFramework.Controls.MetroButton();
            this.btListaAlterar = new MetroFramework.Controls.MetroButton();
            this.gridLista = new MetroFramework.Controls.MetroGrid();
            this.tabAtivos = new MetroFramework.Controls.MetroTabPage();
            this.listAtivos = new System.Windows.Forms.ListBox();
            this.btEmpDeletar = new MetroFramework.Controls.MetroButton();
            this.btEmpAlterar = new MetroFramework.Controls.MetroButton();
            this.gridAtivos = new MetroFramework.Controls.MetroGrid();
            this.tabRegisto.SuspendLayout();
            this.pageAluno.SuspendLayout();
            this.pageProfessor.SuspendLayout();
            this.tabLista.SuspendLayout();
            this.tabLista1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            this.tabAtivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtivos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRegisto
            // 
            this.tabRegisto.Controls.Add(this.pageAluno);
            this.tabRegisto.Controls.Add(this.pageProfessor);
            this.tabRegisto.Location = new System.Drawing.Point(38, 63);
            this.tabRegisto.Name = "tabRegisto";
            this.tabRegisto.SelectedIndex = 0;
            this.tabRegisto.Size = new System.Drawing.Size(569, 540);
            this.tabRegisto.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabRegisto.TabIndex = 1;
            this.tabRegisto.UseSelectable = true;
            // 
            // pageAluno
            // 
            this.pageAluno.Controls.Add(this.btAluLimpar);
            this.pageAluno.Controls.Add(this.btAluSubmeter);
            this.pageAluno.Controls.Add(this.cbAluAno);
            this.pageAluno.Controls.Add(this.tbAluAdicionais);
            this.pageAluno.Controls.Add(this.tbAluTurma);
            this.pageAluno.Controls.Add(this.tbAluProcesso);
            this.pageAluno.Controls.Add(this.tbAluNome);
            this.pageAluno.Controls.Add(this.metroLabel3);
            this.pageAluno.Controls.Add(this.metroLabel6);
            this.pageAluno.Controls.Add(this.metroLabel8);
            this.pageAluno.Controls.Add(this.metroLabel9);
            this.pageAluno.Controls.Add(this.metroLabel10);
            this.pageAluno.HorizontalScrollbarBarColor = true;
            this.pageAluno.HorizontalScrollbarHighlightOnWheel = false;
            this.pageAluno.HorizontalScrollbarSize = 10;
            this.pageAluno.Location = new System.Drawing.Point(4, 38);
            this.pageAluno.Name = "pageAluno";
            this.pageAluno.Size = new System.Drawing.Size(561, 498);
            this.pageAluno.TabIndex = 0;
            this.pageAluno.Text = "Aluno";
            this.pageAluno.VerticalScrollbarBarColor = true;
            this.pageAluno.VerticalScrollbarHighlightOnWheel = false;
            this.pageAluno.VerticalScrollbarSize = 10;
            // 
            // btAluLimpar
            // 
            this.btAluLimpar.Location = new System.Drawing.Point(101, 465);
            this.btAluLimpar.Name = "btAluLimpar";
            this.btAluLimpar.Size = new System.Drawing.Size(218, 30);
            this.btAluLimpar.TabIndex = 27;
            this.btAluLimpar.Text = "Limpar campos";
            this.btAluLimpar.UseSelectable = true;
            this.btAluLimpar.Click += new System.EventHandler(this.btAluLimpar_Click);
            // 
            // btAluSubmeter
            // 
            this.btAluSubmeter.Location = new System.Drawing.Point(325, 465);
            this.btAluSubmeter.Name = "btAluSubmeter";
            this.btAluSubmeter.Size = new System.Drawing.Size(218, 30);
            this.btAluSubmeter.TabIndex = 26;
            this.btAluSubmeter.Text = "Submeter";
            this.btAluSubmeter.UseSelectable = true;
            this.btAluSubmeter.Click += new System.EventHandler(this.btAluSubmeter_Click);
            // 
            // cbAluAno
            // 
            this.cbAluAno.FormattingEnabled = true;
            this.cbAluAno.ItemHeight = 23;
            this.cbAluAno.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "Outro"});
            this.cbAluAno.Location = new System.Drawing.Point(393, 101);
            this.cbAluAno.Name = "cbAluAno";
            this.cbAluAno.Size = new System.Drawing.Size(150, 29);
            this.cbAluAno.TabIndex = 21;
            this.cbAluAno.UseSelectable = true;
            // 
            // tbAluAdicionais
            // 
            // 
            // 
            // 
            this.tbAluAdicionais.CustomButton.Image = null;
            this.tbAluAdicionais.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.tbAluAdicionais.CustomButton.Name = "";
            this.tbAluAdicionais.CustomButton.Size = new System.Drawing.Size(307, 307);
            this.tbAluAdicionais.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAluAdicionais.CustomButton.TabIndex = 1;
            this.tbAluAdicionais.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAluAdicionais.CustomButton.UseSelectable = true;
            this.tbAluAdicionais.CustomButton.Visible = false;
            this.tbAluAdicionais.Lines = new string[0];
            this.tbAluAdicionais.Location = new System.Drawing.Point(101, 150);
            this.tbAluAdicionais.MaxLength = 32767;
            this.tbAluAdicionais.Multiline = true;
            this.tbAluAdicionais.Name = "tbAluAdicionais";
            this.tbAluAdicionais.PasswordChar = '\0';
            this.tbAluAdicionais.PromptText = "Anotações adicionais";
            this.tbAluAdicionais.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAluAdicionais.SelectedText = "";
            this.tbAluAdicionais.SelectionLength = 0;
            this.tbAluAdicionais.SelectionStart = 0;
            this.tbAluAdicionais.ShortcutsEnabled = true;
            this.tbAluAdicionais.Size = new System.Drawing.Size(442, 306);
            this.tbAluAdicionais.TabIndex = 20;
            this.tbAluAdicionais.UseSelectable = true;
            this.tbAluAdicionais.WaterMark = "Anotações adicionais";
            this.tbAluAdicionais.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAluAdicionais.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbAluTurma
            // 
            // 
            // 
            // 
            this.tbAluTurma.CustomButton.Image = null;
            this.tbAluTurma.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.tbAluTurma.CustomButton.Name = "";
            this.tbAluTurma.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAluTurma.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAluTurma.CustomButton.TabIndex = 1;
            this.tbAluTurma.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAluTurma.CustomButton.UseSelectable = true;
            this.tbAluTurma.CustomButton.Visible = false;
            this.tbAluTurma.Lines = new string[0];
            this.tbAluTurma.Location = new System.Drawing.Point(101, 104);
            this.tbAluTurma.MaxLength = 32767;
            this.tbAluTurma.Name = "tbAluTurma";
            this.tbAluTurma.PasswordChar = '\0';
            this.tbAluTurma.PromptText = "Designação da turma";
            this.tbAluTurma.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAluTurma.SelectedText = "";
            this.tbAluTurma.SelectionLength = 0;
            this.tbAluTurma.SelectionStart = 0;
            this.tbAluTurma.ShortcutsEnabled = true;
            this.tbAluTurma.Size = new System.Drawing.Size(240, 23);
            this.tbAluTurma.TabIndex = 19;
            this.tbAluTurma.UseSelectable = true;
            this.tbAluTurma.WaterMark = "Designação da turma";
            this.tbAluTurma.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAluTurma.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbAluProcesso
            // 
            // 
            // 
            // 
            this.tbAluProcesso.CustomButton.Image = null;
            this.tbAluProcesso.CustomButton.Location = new System.Drawing.Point(502, 1);
            this.tbAluProcesso.CustomButton.Name = "";
            this.tbAluProcesso.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAluProcesso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAluProcesso.CustomButton.TabIndex = 1;
            this.tbAluProcesso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAluProcesso.CustomButton.UseSelectable = true;
            this.tbAluProcesso.CustomButton.Visible = false;
            this.tbAluProcesso.Lines = new string[0];
            this.tbAluProcesso.Location = new System.Drawing.Point(101, 63);
            this.tbAluProcesso.MaxLength = 32767;
            this.tbAluProcesso.Name = "tbAluProcesso";
            this.tbAluProcesso.PasswordChar = '\0';
            this.tbAluProcesso.PromptText = "Número do processo escolar";
            this.tbAluProcesso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAluProcesso.SelectedText = "";
            this.tbAluProcesso.SelectionLength = 0;
            this.tbAluProcesso.SelectionStart = 0;
            this.tbAluProcesso.ShortcutsEnabled = true;
            this.tbAluProcesso.Size = new System.Drawing.Size(442, 23);
            this.tbAluProcesso.TabIndex = 18;
            this.tbAluProcesso.UseSelectable = true;
            this.tbAluProcesso.WaterMark = "Número do processo escolar";
            this.tbAluProcesso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAluProcesso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbAluNome
            // 
            // 
            // 
            // 
            this.tbAluNome.CustomButton.Image = null;
            this.tbAluNome.CustomButton.Location = new System.Drawing.Point(502, 1);
            this.tbAluNome.CustomButton.Name = "";
            this.tbAluNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAluNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAluNome.CustomButton.TabIndex = 1;
            this.tbAluNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAluNome.CustomButton.UseSelectable = true;
            this.tbAluNome.CustomButton.Visible = false;
            this.tbAluNome.Lines = new string[0];
            this.tbAluNome.Location = new System.Drawing.Point(101, 23);
            this.tbAluNome.MaxLength = 32767;
            this.tbAluNome.Name = "tbAluNome";
            this.tbAluNome.PasswordChar = '\0';
            this.tbAluNome.PromptText = "Nome completo";
            this.tbAluNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAluNome.SelectedText = "";
            this.tbAluNome.SelectionLength = 0;
            this.tbAluNome.SelectionStart = 0;
            this.tbAluNome.ShortcutsEnabled = true;
            this.tbAluNome.Size = new System.Drawing.Size(442, 23);
            this.tbAluNome.TabIndex = 17;
            this.tbAluNome.UseSelectable = true;
            this.tbAluNome.WaterMark = "Nome completo";
            this.tbAluNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAluNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 150);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Adicionais:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(15, 106);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(52, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Turma: ";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(347, 106);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(40, 19);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "Ano: ";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(15, 63);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(64, 19);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Processo:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(15, 23);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(59, 19);
            this.metroLabel10.TabIndex = 12;
            this.metroLabel10.Text = "Nome: ⁎";
            // 
            // pageProfessor
            // 
            this.pageProfessor.Controls.Add(this.btProfLimpar);
            this.pageProfessor.Controls.Add(this.tbProfAdicionais);
            this.pageProfessor.Controls.Add(this.btProfSubmeter);
            this.pageProfessor.Controls.Add(this.tbProfProcesso);
            this.pageProfessor.Controls.Add(this.tbProfNome);
            this.pageProfessor.Controls.Add(this.metroLabel7);
            this.pageProfessor.Controls.Add(this.metroLabel2);
            this.pageProfessor.Controls.Add(this.metroLabel1);
            this.pageProfessor.HorizontalScrollbarBarColor = true;
            this.pageProfessor.HorizontalScrollbarHighlightOnWheel = false;
            this.pageProfessor.HorizontalScrollbarSize = 10;
            this.pageProfessor.Location = new System.Drawing.Point(4, 38);
            this.pageProfessor.Name = "pageProfessor";
            this.pageProfessor.Size = new System.Drawing.Size(561, 498);
            this.pageProfessor.TabIndex = 1;
            this.pageProfessor.Text = "Professor";
            this.pageProfessor.VerticalScrollbarBarColor = true;
            this.pageProfessor.VerticalScrollbarHighlightOnWheel = false;
            this.pageProfessor.VerticalScrollbarSize = 10;
            // 
            // btProfLimpar
            // 
            this.btProfLimpar.Location = new System.Drawing.Point(101, 462);
            this.btProfLimpar.Name = "btProfLimpar";
            this.btProfLimpar.Size = new System.Drawing.Size(218, 30);
            this.btProfLimpar.TabIndex = 11;
            this.btProfLimpar.Text = "Limpar campos";
            this.btProfLimpar.UseSelectable = true;
            this.btProfLimpar.Click += new System.EventHandler(this.btProfLimpar_Click);
            // 
            // tbProfAdicionais
            // 
            // 
            // 
            // 
            this.tbProfAdicionais.CustomButton.Image = null;
            this.tbProfAdicionais.CustomButton.Location = new System.Drawing.Point(187, 2);
            this.tbProfAdicionais.CustomButton.Name = "";
            this.tbProfAdicionais.CustomButton.Size = new System.Drawing.Size(377, 377);
            this.tbProfAdicionais.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbProfAdicionais.CustomButton.TabIndex = 1;
            this.tbProfAdicionais.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbProfAdicionais.CustomButton.UseSelectable = true;
            this.tbProfAdicionais.CustomButton.Visible = false;
            this.tbProfAdicionais.Lines = new string[0];
            this.tbProfAdicionais.Location = new System.Drawing.Point(101, 103);
            this.tbProfAdicionais.MaxLength = 32767;
            this.tbProfAdicionais.Multiline = true;
            this.tbProfAdicionais.Name = "tbProfAdicionais";
            this.tbProfAdicionais.PasswordChar = '\0';
            this.tbProfAdicionais.PromptText = "Anotações adicionais";
            this.tbProfAdicionais.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProfAdicionais.SelectedText = "";
            this.tbProfAdicionais.SelectionLength = 0;
            this.tbProfAdicionais.SelectionStart = 0;
            this.tbProfAdicionais.ShortcutsEnabled = true;
            this.tbProfAdicionais.Size = new System.Drawing.Size(443, 343);
            this.tbProfAdicionais.TabIndex = 8;
            this.tbProfAdicionais.UseSelectable = true;
            this.tbProfAdicionais.WaterMark = "Anotações adicionais";
            this.tbProfAdicionais.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbProfAdicionais.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btProfSubmeter
            // 
            this.btProfSubmeter.Location = new System.Drawing.Point(325, 462);
            this.btProfSubmeter.Name = "btProfSubmeter";
            this.btProfSubmeter.Size = new System.Drawing.Size(218, 30);
            this.btProfSubmeter.TabIndex = 10;
            this.btProfSubmeter.Text = "Submeter";
            this.btProfSubmeter.UseSelectable = true;
            this.btProfSubmeter.Click += new System.EventHandler(this.btSubmeter_Click);
            // 
            // tbProfProcesso
            // 
            // 
            // 
            // 
            this.tbProfProcesso.CustomButton.Image = null;
            this.tbProfProcesso.CustomButton.Location = new System.Drawing.Point(545, 1);
            this.tbProfProcesso.CustomButton.Name = "";
            this.tbProfProcesso.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbProfProcesso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbProfProcesso.CustomButton.TabIndex = 1;
            this.tbProfProcesso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbProfProcesso.CustomButton.UseSelectable = true;
            this.tbProfProcesso.CustomButton.Visible = false;
            this.tbProfProcesso.Lines = new string[0];
            this.tbProfProcesso.Location = new System.Drawing.Point(101, 62);
            this.tbProfProcesso.MaxLength = 32767;
            this.tbProfProcesso.Name = "tbProfProcesso";
            this.tbProfProcesso.PasswordChar = '\0';
            this.tbProfProcesso.PromptText = "Número do processo escolar";
            this.tbProfProcesso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProfProcesso.SelectedText = "";
            this.tbProfProcesso.SelectionLength = 0;
            this.tbProfProcesso.SelectionStart = 0;
            this.tbProfProcesso.ShortcutsEnabled = true;
            this.tbProfProcesso.Size = new System.Drawing.Size(443, 23);
            this.tbProfProcesso.TabIndex = 5;
            this.tbProfProcesso.UseSelectable = true;
            this.tbProfProcesso.WaterMark = "Número do processo escolar";
            this.tbProfProcesso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbProfProcesso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbProfNome
            // 
            // 
            // 
            // 
            this.tbProfNome.CustomButton.Image = null;
            this.tbProfNome.CustomButton.Location = new System.Drawing.Point(545, 1);
            this.tbProfNome.CustomButton.Name = "";
            this.tbProfNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbProfNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbProfNome.CustomButton.TabIndex = 1;
            this.tbProfNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbProfNome.CustomButton.UseSelectable = true;
            this.tbProfNome.CustomButton.Visible = false;
            this.tbProfNome.Lines = new string[0];
            this.tbProfNome.Location = new System.Drawing.Point(101, 23);
            this.tbProfNome.MaxLength = 32767;
            this.tbProfNome.Name = "tbProfNome";
            this.tbProfNome.PasswordChar = '\0';
            this.tbProfNome.PromptText = "Nome completo";
            this.tbProfNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProfNome.SelectedText = "";
            this.tbProfNome.SelectionLength = 0;
            this.tbProfNome.SelectionStart = 0;
            this.tbProfNome.ShortcutsEnabled = true;
            this.tbProfNome.Size = new System.Drawing.Size(442, 23);
            this.tbProfNome.TabIndex = 4;
            this.tbProfNome.UseSelectable = true;
            this.tbProfNome.WaterMark = "Nome completo";
            this.tbProfNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbProfNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(17, 103);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(71, 19);
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "Adicionais:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Processo: ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nome: ⁎";
            // 
            // tabLista
            // 
            this.tabLista.Controls.Add(this.tabLista1);
            this.tabLista.Controls.Add(this.tabAtivos);
            this.tabLista.Location = new System.Drawing.Point(613, 63);
            this.tabLista.Name = "tabLista";
            this.tabLista.SelectedIndex = 0;
            this.tabLista.Size = new System.Drawing.Size(614, 544);
            this.tabLista.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabLista.TabIndex = 15;
            this.tabLista.UseSelectable = true;
            // 
            // tabLista1
            // 
            this.tabLista1.Controls.Add(this.listUtilizadores);
            this.tabLista1.Controls.Add(this.btListaDeletar);
            this.tabLista1.Controls.Add(this.btListaAlterar);
            this.tabLista1.Controls.Add(this.gridLista);
            this.tabLista1.HorizontalScrollbarBarColor = true;
            this.tabLista1.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLista1.HorizontalScrollbarSize = 10;
            this.tabLista1.Location = new System.Drawing.Point(4, 38);
            this.tabLista1.Name = "tabLista1";
            this.tabLista1.Size = new System.Drawing.Size(606, 502);
            this.tabLista1.TabIndex = 0;
            this.tabLista1.Text = "Lista";
            this.tabLista1.VerticalScrollbarBarColor = true;
            this.tabLista1.VerticalScrollbarHighlightOnWheel = false;
            this.tabLista1.VerticalScrollbarSize = 10;
            // 
            // listUtilizadores
            // 
            this.listUtilizadores.FormattingEnabled = true;
            this.listUtilizadores.Location = new System.Drawing.Point(17, 23);
            this.listUtilizadores.Name = "listUtilizadores";
            this.listUtilizadores.Size = new System.Drawing.Size(573, 433);
            this.listUtilizadores.TabIndex = 14;
            // 
            // btListaDeletar
            // 
            this.btListaDeletar.Location = new System.Drawing.Point(312, 465);
            this.btListaDeletar.Name = "btListaDeletar";
            this.btListaDeletar.Size = new System.Drawing.Size(278, 30);
            this.btListaDeletar.TabIndex = 13;
            this.btListaDeletar.Text = "Deletar";
            this.btListaDeletar.UseSelectable = true;
            this.btListaDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btListaAlterar
            // 
            this.btListaAlterar.Location = new System.Drawing.Point(17, 465);
            this.btListaAlterar.Name = "btListaAlterar";
            this.btListaAlterar.Size = new System.Drawing.Size(289, 30);
            this.btListaAlterar.TabIndex = 12;
            this.btListaAlterar.Text = "Alterar";
            this.btListaAlterar.UseSelectable = true;
            this.btListaAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // gridLista
            // 
            this.gridLista.AllowUserToResizeRows = false;
            this.gridLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridLista.DefaultCellStyle = dataGridViewCellStyle32;
            this.gridLista.EnableHeadersVisualStyles = false;
            this.gridLista.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridLista.Location = new System.Drawing.Point(17, 18);
            this.gridLista.Name = "gridLista";
            this.gridLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.gridLista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLista.Size = new System.Drawing.Size(573, 477);
            this.gridLista.TabIndex = 0;
            this.gridLista.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gridLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLista_CellContentClick);
            // 
            // tabAtivos
            // 
            this.tabAtivos.Controls.Add(this.listAtivos);
            this.tabAtivos.Controls.Add(this.btEmpDeletar);
            this.tabAtivos.Controls.Add(this.btEmpAlterar);
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
            // listAtivos
            // 
            this.listAtivos.FormattingEnabled = true;
            this.listAtivos.Location = new System.Drawing.Point(17, 23);
            this.listAtivos.Name = "listAtivos";
            this.listAtivos.Size = new System.Drawing.Size(573, 433);
            this.listAtivos.TabIndex = 16;
            // 
            // btEmpDeletar
            // 
            this.btEmpDeletar.Location = new System.Drawing.Point(312, 518);
            this.btEmpDeletar.Name = "btEmpDeletar";
            this.btEmpDeletar.Size = new System.Drawing.Size(278, 30);
            this.btEmpDeletar.TabIndex = 17;
            this.btEmpDeletar.Text = "Deletar";
            this.btEmpDeletar.UseSelectable = true;
            this.btEmpDeletar.Click += new System.EventHandler(this.btEmpDeletar_Click);
            // 
            // btEmpAlterar
            // 
            this.btEmpAlterar.Location = new System.Drawing.Point(17, 518);
            this.btEmpAlterar.Name = "btEmpAlterar";
            this.btEmpAlterar.Size = new System.Drawing.Size(289, 30);
            this.btEmpAlterar.TabIndex = 16;
            this.btEmpAlterar.Text = "Alterar";
            this.btEmpAlterar.UseSelectable = true;
            this.btEmpAlterar.Click += new System.EventHandler(this.btEmpAlterar_Click);
            // 
            // gridAtivos
            // 
            this.gridAtivos.AllowUserToResizeRows = false;
            this.gridAtivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridAtivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridAtivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridAtivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAtivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.gridAtivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAtivos.DefaultCellStyle = dataGridViewCellStyle35;
            this.gridAtivos.EnableHeadersVisualStyles = false;
            this.gridAtivos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridAtivos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridAtivos.Location = new System.Drawing.Point(17, 18);
            this.gridAtivos.Name = "gridAtivos";
            this.gridAtivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridAtivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.gridAtivos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridAtivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAtivos.Size = new System.Drawing.Size(573, 477);
            this.gridAtivos.TabIndex = 2;
            this.gridAtivos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gridAtivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAtivos_CellContentClick);
            // 
            // Utilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 630);
            this.ControlBox = false;
            this.Controls.Add(this.tabLista);
            this.Controls.Add(this.tabRegisto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Utilizadores";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Utilizadores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Utilizadores_FormClosing);
            this.Load += new System.EventHandler(this.Utilizadores_Load);
            this.tabRegisto.ResumeLayout(false);
            this.pageAluno.ResumeLayout(false);
            this.pageAluno.PerformLayout();
            this.pageProfessor.ResumeLayout(false);
            this.pageProfessor.PerformLayout();
            this.tabLista.ResumeLayout(false);
            this.tabLista1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            this.tabAtivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAtivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabRegisto;
        private MetroFramework.Controls.MetroTabPage pageAluno;
        private MetroFramework.Controls.MetroTabPage pageProfessor;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox tbProfAdicionais;
        private MetroFramework.Controls.MetroTextBox tbProfProcesso;
        private MetroFramework.Controls.MetroTextBox tbProfNome;
        private MetroFramework.Controls.MetroButton btProfSubmeter;
        private MetroFramework.Controls.MetroButton btProfLimpar;
        private MetroFramework.Controls.MetroComboBox cbAluAno;
        private MetroFramework.Controls.MetroTextBox tbAluAdicionais;
        private MetroFramework.Controls.MetroTextBox tbAluTurma;
        private MetroFramework.Controls.MetroTextBox tbAluProcesso;
        private MetroFramework.Controls.MetroTextBox tbAluNome;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTabControl tabLista;
        private MetroFramework.Controls.MetroTabPage tabLista1;
        private MetroFramework.Controls.MetroButton btListaDeletar;
        private MetroFramework.Controls.MetroButton btListaAlterar;
        private MetroFramework.Controls.MetroGrid gridLista;
        private MetroFramework.Controls.MetroTabPage tabAtivos;
        private MetroFramework.Controls.MetroGrid gridAtivos;
        private MetroFramework.Controls.MetroButton btAluLimpar;
        private MetroFramework.Controls.MetroButton btAluSubmeter;
        private MetroFramework.Controls.MetroButton btEmpDeletar;
        private MetroFramework.Controls.MetroButton btEmpAlterar;
        private System.Windows.Forms.ListBox listUtilizadores;
        private System.Windows.Forms.ListBox listAtivos;
    }
}