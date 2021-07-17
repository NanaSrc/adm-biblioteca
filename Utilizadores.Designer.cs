
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btLimparProf = new MetroFramework.Controls.MetroButton();
            this.tbProfAdicionais = new MetroFramework.Controls.MetroTextBox();
            this.btSubmeterProf = new MetroFramework.Controls.MetroButton();
            this.tbProfProcesso = new MetroFramework.Controls.MetroTextBox();
            this.tbProfNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabLista = new MetroFramework.Controls.MetroTabControl();
            this.tabLista1 = new MetroFramework.Controls.MetroTabPage();
            this.btDeletar = new MetroFramework.Controls.MetroButton();
            this.btAlterar = new MetroFramework.Controls.MetroButton();
            this.gridLista = new MetroFramework.Controls.MetroGrid();
            this.tabAtivos = new MetroFramework.Controls.MetroTabPage();
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
            this.tabRegisto.Location = new System.Drawing.Point(23, 63);
            this.tabRegisto.Name = "tabRegisto";
            this.tabRegisto.SelectedIndex = 1;
            this.tabRegisto.Size = new System.Drawing.Size(714, 606);
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
            this.pageAluno.Size = new System.Drawing.Size(706, 564);
            this.pageAluno.TabIndex = 0;
            this.pageAluno.Text = "Aluno";
            this.pageAluno.VerticalScrollbarBarColor = true;
            this.pageAluno.VerticalScrollbarHighlightOnWheel = false;
            this.pageAluno.VerticalScrollbarSize = 10;
            // 
            // btAluLimpar
            // 
            this.btAluLimpar.Location = new System.Drawing.Point(125, 518);
            this.btAluLimpar.Name = "btAluLimpar";
            this.btAluLimpar.Size = new System.Drawing.Size(281, 30);
            this.btAluLimpar.TabIndex = 27;
            this.btAluLimpar.Text = "Limpar";
            this.btAluLimpar.UseSelectable = true;
            // 
            // btAluSubmeter
            // 
            this.btAluSubmeter.Location = new System.Drawing.Point(412, 518);
            this.btAluSubmeter.Name = "btAluSubmeter";
            this.btAluSubmeter.Size = new System.Drawing.Size(280, 30);
            this.btAluSubmeter.TabIndex = 26;
            this.btAluSubmeter.Text = "Submeter";
            this.btAluSubmeter.UseSelectable = true;
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
            this.cbAluAno.Location = new System.Drawing.Point(125, 106);
            this.cbAluAno.Name = "cbAluAno";
            this.cbAluAno.Size = new System.Drawing.Size(172, 29);
            this.cbAluAno.TabIndex = 21;
            this.cbAluAno.UseSelectable = true;
            // 
            // tbAluAdicionais
            // 
            // 
            // 
            // 
            this.tbAluAdicionais.CustomButton.Image = null;
            this.tbAluAdicionais.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.tbAluAdicionais.CustomButton.Name = "";
            this.tbAluAdicionais.CustomButton.Size = new System.Drawing.Size(303, 303);
            this.tbAluAdicionais.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAluAdicionais.CustomButton.TabIndex = 1;
            this.tbAluAdicionais.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAluAdicionais.CustomButton.UseSelectable = true;
            this.tbAluAdicionais.CustomButton.Visible = false;
            this.tbAluAdicionais.Lines = new string[0];
            this.tbAluAdicionais.Location = new System.Drawing.Point(125, 190);
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
            this.tbAluAdicionais.Size = new System.Drawing.Size(567, 305);
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
            this.tbAluTurma.CustomButton.Location = new System.Drawing.Point(545, 1);
            this.tbAluTurma.CustomButton.Name = "";
            this.tbAluTurma.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAluTurma.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAluTurma.CustomButton.TabIndex = 1;
            this.tbAluTurma.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAluTurma.CustomButton.UseSelectable = true;
            this.tbAluTurma.CustomButton.Visible = false;
            this.tbAluTurma.Lines = new string[0];
            this.tbAluTurma.Location = new System.Drawing.Point(125, 149);
            this.tbAluTurma.MaxLength = 32767;
            this.tbAluTurma.Name = "tbAluTurma";
            this.tbAluTurma.PasswordChar = '\0';
            this.tbAluTurma.PromptText = "Designação da turma";
            this.tbAluTurma.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAluTurma.SelectedText = "";
            this.tbAluTurma.SelectionLength = 0;
            this.tbAluTurma.SelectionStart = 0;
            this.tbAluTurma.ShortcutsEnabled = true;
            this.tbAluTurma.Size = new System.Drawing.Size(567, 23);
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
            this.tbAluProcesso.CustomButton.Location = new System.Drawing.Point(545, 1);
            this.tbAluProcesso.CustomButton.Name = "";
            this.tbAluProcesso.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAluProcesso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAluProcesso.CustomButton.TabIndex = 1;
            this.tbAluProcesso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAluProcesso.CustomButton.UseSelectable = true;
            this.tbAluProcesso.CustomButton.Visible = false;
            this.tbAluProcesso.Lines = new string[0];
            this.tbAluProcesso.Location = new System.Drawing.Point(125, 72);
            this.tbAluProcesso.MaxLength = 32767;
            this.tbAluProcesso.Name = "tbAluProcesso";
            this.tbAluProcesso.PasswordChar = '\0';
            this.tbAluProcesso.PromptText = "Número do processo escolar";
            this.tbAluProcesso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAluProcesso.SelectedText = "";
            this.tbAluProcesso.SelectionLength = 0;
            this.tbAluProcesso.SelectionStart = 0;
            this.tbAluProcesso.ShortcutsEnabled = true;
            this.tbAluProcesso.Size = new System.Drawing.Size(567, 23);
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
            this.tbAluNome.CustomButton.Location = new System.Drawing.Point(545, 1);
            this.tbAluNome.CustomButton.Name = "";
            this.tbAluNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAluNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAluNome.CustomButton.TabIndex = 1;
            this.tbAluNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAluNome.CustomButton.UseSelectable = true;
            this.tbAluNome.CustomButton.Visible = false;
            this.tbAluNome.Lines = new string[0];
            this.tbAluNome.Location = new System.Drawing.Point(125, 33);
            this.tbAluNome.MaxLength = 32767;
            this.tbAluNome.Name = "tbAluNome";
            this.tbAluNome.PasswordChar = '\0';
            this.tbAluNome.PromptText = "Nome completo";
            this.tbAluNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAluNome.SelectedText = "";
            this.tbAluNome.SelectionLength = 0;
            this.tbAluNome.SelectionStart = 0;
            this.tbAluNome.ShortcutsEnabled = true;
            this.tbAluNome.Size = new System.Drawing.Size(567, 23);
            this.tbAluNome.TabIndex = 17;
            this.tbAluNome.UseSelectable = true;
            this.tbAluNome.WaterMark = "Nome completo";
            this.tbAluNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAluNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(16, 189);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Adicionais:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(15, 149);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(52, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Turma: ";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(16, 113);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(40, 19);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "Ano: ";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(15, 72);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(64, 19);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Processo:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(15, 33);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(59, 19);
            this.metroLabel10.TabIndex = 12;
            this.metroLabel10.Text = "Nome: ⁎";
            // 
            // pageProfessor
            // 
            this.pageProfessor.Controls.Add(this.btLimparProf);
            this.pageProfessor.Controls.Add(this.tbProfAdicionais);
            this.pageProfessor.Controls.Add(this.btSubmeterProf);
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
            this.pageProfessor.Size = new System.Drawing.Size(706, 564);
            this.pageProfessor.TabIndex = 1;
            this.pageProfessor.Text = "Professor";
            this.pageProfessor.VerticalScrollbarBarColor = true;
            this.pageProfessor.VerticalScrollbarHighlightOnWheel = false;
            this.pageProfessor.VerticalScrollbarSize = 10;
            // 
            // btLimparProf
            // 
            this.btLimparProf.Location = new System.Drawing.Point(125, 518);
            this.btLimparProf.Name = "btLimparProf";
            this.btLimparProf.Size = new System.Drawing.Size(281, 30);
            this.btLimparProf.TabIndex = 11;
            this.btLimparProf.Text = "Limpar";
            this.btLimparProf.UseSelectable = true;
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
            this.tbProfAdicionais.Location = new System.Drawing.Point(125, 113);
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
            this.tbProfAdicionais.Size = new System.Drawing.Size(567, 382);
            this.tbProfAdicionais.TabIndex = 8;
            this.tbProfAdicionais.UseSelectable = true;
            this.tbProfAdicionais.WaterMark = "Anotações adicionais";
            this.tbProfAdicionais.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbProfAdicionais.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btSubmeterProf
            // 
            this.btSubmeterProf.Location = new System.Drawing.Point(412, 518);
            this.btSubmeterProf.Name = "btSubmeterProf";
            this.btSubmeterProf.Size = new System.Drawing.Size(280, 30);
            this.btSubmeterProf.TabIndex = 10;
            this.btSubmeterProf.Text = "Submeter";
            this.btSubmeterProf.UseSelectable = true;
            this.btSubmeterProf.Click += new System.EventHandler(this.btSubmeter_Click);
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
            this.tbProfProcesso.Location = new System.Drawing.Point(125, 72);
            this.tbProfProcesso.MaxLength = 32767;
            this.tbProfProcesso.Name = "tbProfProcesso";
            this.tbProfProcesso.PasswordChar = '\0';
            this.tbProfProcesso.PromptText = "Número do processo escolar";
            this.tbProfProcesso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProfProcesso.SelectedText = "";
            this.tbProfProcesso.SelectionLength = 0;
            this.tbProfProcesso.SelectionStart = 0;
            this.tbProfProcesso.ShortcutsEnabled = true;
            this.tbProfProcesso.Size = new System.Drawing.Size(567, 23);
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
            this.tbProfNome.Location = new System.Drawing.Point(125, 33);
            this.tbProfNome.MaxLength = 32767;
            this.tbProfNome.Name = "tbProfNome";
            this.tbProfNome.PasswordChar = '\0';
            this.tbProfNome.PromptText = "Nome completo";
            this.tbProfNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProfNome.SelectedText = "";
            this.tbProfNome.SelectionLength = 0;
            this.tbProfNome.SelectionStart = 0;
            this.tbProfNome.ShortcutsEnabled = true;
            this.tbProfNome.Size = new System.Drawing.Size(567, 23);
            this.tbProfNome.TabIndex = 4;
            this.tbProfNome.UseSelectable = true;
            this.tbProfNome.WaterMark = "Nome completo";
            this.tbProfNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbProfNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(15, 113);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(71, 19);
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "Adicionais:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 72);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Processo: ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nome: ⁎";
            // 
            // tabLista
            // 
            this.tabLista.Controls.Add(this.tabLista1);
            this.tabLista.Controls.Add(this.tabAtivos);
            this.tabLista.Location = new System.Drawing.Point(743, 63);
            this.tabLista.Name = "tabLista";
            this.tabLista.SelectedIndex = 0;
            this.tabLista.Size = new System.Drawing.Size(614, 606);
            this.tabLista.Style = MetroFramework.MetroColorStyle.Blue;
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
            // Utilizadores
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
            this.Name = "Utilizadores";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Utilizadores";
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
        private MetroFramework.Controls.MetroButton btSubmeterProf;
        private MetroFramework.Controls.MetroButton btLimparProf;
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
        private MetroFramework.Controls.MetroButton btDeletar;
        private MetroFramework.Controls.MetroButton btAlterar;
        private MetroFramework.Controls.MetroGrid gridLista;
        private MetroFramework.Controls.MetroTabPage tabAtivos;
        private MetroFramework.Controls.MetroGrid gridAtivos;
        private MetroFramework.Controls.MetroButton btAluLimpar;
        private MetroFramework.Controls.MetroButton btAluSubmeter;
    }
}