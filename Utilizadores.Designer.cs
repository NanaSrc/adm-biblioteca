
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
            this.tabRegisto = new MetroFramework.Controls.MetroTabControl();
            this.pageReg = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btLimpar = new MetroFramework.Controls.MetroButton();
            this.cbFuncao = new MetroFramework.Controls.MetroComboBox();
            this.btSubmeter = new MetroFramework.Controls.MetroButton();
            this.cbAluAno = new MetroFramework.Controls.MetroComboBox();
            this.tbAdicionais = new MetroFramework.Controls.MetroTextBox();
            this.tbAluTurma = new MetroFramework.Controls.MetroTextBox();
            this.tbProcesso = new MetroFramework.Controls.MetroTextBox();
            this.tbNome = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.tabLista = new MetroFramework.Controls.MetroTabControl();
            this.tabLista1 = new MetroFramework.Controls.MetroTabPage();
            this.listUtilizadores = new System.Windows.Forms.ListBox();
            this.btListaDeletar = new MetroFramework.Controls.MetroButton();
            this.btListaAlterar = new MetroFramework.Controls.MetroButton();
            this.tabAtivos = new MetroFramework.Controls.MetroTabPage();
            this.btAtivDeletar = new MetroFramework.Controls.MetroButton();
            this.btAtivAlterar = new MetroFramework.Controls.MetroButton();
            this.listAtivos = new System.Windows.Forms.ListBox();
            this.btEmpDeletar = new MetroFramework.Controls.MetroButton();
            this.btEmpAlterar = new MetroFramework.Controls.MetroButton();
            this.tabRegisto.SuspendLayout();
            this.pageReg.SuspendLayout();
            this.tabLista.SuspendLayout();
            this.tabLista1.SuspendLayout();
            this.tabAtivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabRegisto
            // 
            this.tabRegisto.Controls.Add(this.pageReg);
            this.tabRegisto.Location = new System.Drawing.Point(23, 63);
            this.tabRegisto.Name = "tabRegisto";
            this.tabRegisto.SelectedIndex = 0;
            this.tabRegisto.Size = new System.Drawing.Size(584, 497);
            this.tabRegisto.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabRegisto.TabIndex = 1;
            this.tabRegisto.UseSelectable = true;
            // 
            // pageReg
            // 
            this.pageReg.Controls.Add(this.metroLabel1);
            this.pageReg.Controls.Add(this.btLimpar);
            this.pageReg.Controls.Add(this.cbFuncao);
            this.pageReg.Controls.Add(this.btSubmeter);
            this.pageReg.Controls.Add(this.cbAluAno);
            this.pageReg.Controls.Add(this.tbAdicionais);
            this.pageReg.Controls.Add(this.tbAluTurma);
            this.pageReg.Controls.Add(this.tbProcesso);
            this.pageReg.Controls.Add(this.tbNome);
            this.pageReg.Controls.Add(this.metroLabel3);
            this.pageReg.Controls.Add(this.metroLabel6);
            this.pageReg.Controls.Add(this.metroLabel8);
            this.pageReg.Controls.Add(this.metroLabel9);
            this.pageReg.Controls.Add(this.metroLabel10);
            this.pageReg.HorizontalScrollbarBarColor = true;
            this.pageReg.HorizontalScrollbarHighlightOnWheel = false;
            this.pageReg.HorizontalScrollbarSize = 10;
            this.pageReg.Location = new System.Drawing.Point(4, 38);
            this.pageReg.Name = "pageReg";
            this.pageReg.Size = new System.Drawing.Size(576, 455);
            this.pageReg.TabIndex = 0;
            this.pageReg.Text = "Registo";
            this.pageReg.VerticalScrollbarBarColor = true;
            this.pageReg.VerticalScrollbarHighlightOnWheel = false;
            this.pageReg.VerticalScrollbarSize = 10;
            this.pageReg.Click += new System.EventHandler(this.pageReg_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 29;
            this.metroLabel1.Text = "Função: ⁎";
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(106, 410);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(218, 30);
            this.btLimpar.TabIndex = 7;
            this.btLimpar.Text = "Limpar campos";
            this.btLimpar.UseSelectable = true;
            this.btLimpar.Click += new System.EventHandler(this.btAluLimpar_Click);
            // 
            // cbFuncao
            // 
            this.cbFuncao.FormattingEnabled = true;
            this.cbFuncao.ItemHeight = 23;
            this.cbFuncao.Items.AddRange(new object[] {
            "Aluno",
            "Professor"});
            this.cbFuncao.Location = new System.Drawing.Point(106, 61);
            this.cbFuncao.Name = "cbFuncao";
            this.cbFuncao.Size = new System.Drawing.Size(442, 29);
            this.cbFuncao.TabIndex = 2;
            this.cbFuncao.UseSelectable = true;
            this.cbFuncao.SelectedIndexChanged += new System.EventHandler(this.cbFuncao_SelectedIndexChanged);
            // 
            // btSubmeter
            // 
            this.btSubmeter.Location = new System.Drawing.Point(330, 410);
            this.btSubmeter.Name = "btSubmeter";
            this.btSubmeter.Size = new System.Drawing.Size(218, 30);
            this.btSubmeter.TabIndex = 8;
            this.btSubmeter.Text = "Submeter";
            this.btSubmeter.UseSelectable = true;
            this.btSubmeter.Click += new System.EventHandler(this.btAluSubmeter_Click);
            // 
            // cbAluAno
            // 
            this.cbAluAno.Enabled = false;
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
            this.cbAluAno.Location = new System.Drawing.Point(398, 148);
            this.cbAluAno.Name = "cbAluAno";
            this.cbAluAno.Size = new System.Drawing.Size(150, 29);
            this.cbAluAno.TabIndex = 5;
            this.cbAluAno.UseSelectable = true;
            this.cbAluAno.SelectedIndexChanged += new System.EventHandler(this.cbAluAno_SelectedIndexChanged);
            // 
            // tbAdicionais
            // 
            // 
            // 
            // 
            this.tbAdicionais.CustomButton.Image = null;
            this.tbAdicionais.CustomButton.Location = new System.Drawing.Point(234, 1);
            this.tbAdicionais.CustomButton.Name = "";
            this.tbAdicionais.CustomButton.Size = new System.Drawing.Size(207, 207);
            this.tbAdicionais.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAdicionais.CustomButton.TabIndex = 1;
            this.tbAdicionais.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAdicionais.CustomButton.UseSelectable = true;
            this.tbAdicionais.CustomButton.Visible = false;
            this.tbAdicionais.Lines = new string[0];
            this.tbAdicionais.Location = new System.Drawing.Point(106, 195);
            this.tbAdicionais.MaxLength = 32767;
            this.tbAdicionais.Multiline = true;
            this.tbAdicionais.Name = "tbAdicionais";
            this.tbAdicionais.PasswordChar = '\0';
            this.tbAdicionais.PromptText = "Anotações adicionais";
            this.tbAdicionais.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAdicionais.SelectedText = "";
            this.tbAdicionais.SelectionLength = 0;
            this.tbAdicionais.SelectionStart = 0;
            this.tbAdicionais.ShortcutsEnabled = true;
            this.tbAdicionais.Size = new System.Drawing.Size(442, 209);
            this.tbAdicionais.TabIndex = 6;
            this.tbAdicionais.UseSelectable = true;
            this.tbAdicionais.WaterMark = "Anotações adicionais";
            this.tbAdicionais.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAdicionais.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbAluTurma
            // 
            // 
            // 
            // 
            this.tbAluTurma.CustomButton.Image = null;
            this.tbAluTurma.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.tbAluTurma.CustomButton.Name = "";
            this.tbAluTurma.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAluTurma.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAluTurma.CustomButton.TabIndex = 1;
            this.tbAluTurma.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAluTurma.CustomButton.UseSelectable = true;
            this.tbAluTurma.CustomButton.Visible = false;
            this.tbAluTurma.Enabled = false;
            this.tbAluTurma.Lines = new string[0];
            this.tbAluTurma.Location = new System.Drawing.Point(106, 151);
            this.tbAluTurma.MaxLength = 8;
            this.tbAluTurma.Name = "tbAluTurma";
            this.tbAluTurma.PasswordChar = '\0';
            this.tbAluTurma.PromptText = "Designação da turma";
            this.tbAluTurma.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAluTurma.SelectedText = "";
            this.tbAluTurma.SelectionLength = 0;
            this.tbAluTurma.SelectionStart = 0;
            this.tbAluTurma.ShortcutsEnabled = true;
            this.tbAluTurma.Size = new System.Drawing.Size(240, 23);
            this.tbAluTurma.TabIndex = 4;
            this.tbAluTurma.UseSelectable = true;
            this.tbAluTurma.WaterMark = "Designação da turma";
            this.tbAluTurma.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAluTurma.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbProcesso
            // 
            // 
            // 
            // 
            this.tbProcesso.CustomButton.Image = null;
            this.tbProcesso.CustomButton.Location = new System.Drawing.Point(420, 1);
            this.tbProcesso.CustomButton.Name = "";
            this.tbProcesso.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbProcesso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbProcesso.CustomButton.TabIndex = 1;
            this.tbProcesso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbProcesso.CustomButton.UseSelectable = true;
            this.tbProcesso.CustomButton.Visible = false;
            this.tbProcesso.Lines = new string[0];
            this.tbProcesso.Location = new System.Drawing.Point(106, 108);
            this.tbProcesso.MaxLength = 8;
            this.tbProcesso.Name = "tbProcesso";
            this.tbProcesso.PasswordChar = '\0';
            this.tbProcesso.PromptText = "Número do processo escolar";
            this.tbProcesso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbProcesso.SelectedText = "";
            this.tbProcesso.SelectionLength = 0;
            this.tbProcesso.SelectionStart = 0;
            this.tbProcesso.ShortcutsEnabled = true;
            this.tbProcesso.Size = new System.Drawing.Size(442, 23);
            this.tbProcesso.TabIndex = 3;
            this.tbProcesso.UseSelectable = true;
            this.tbProcesso.WaterMark = "Número do processo escolar";
            this.tbProcesso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbProcesso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbNome
            // 
            // 
            // 
            // 
            this.tbNome.CustomButton.Image = null;
            this.tbNome.CustomButton.Location = new System.Drawing.Point(420, 1);
            this.tbNome.CustomButton.Name = "";
            this.tbNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNome.CustomButton.TabIndex = 1;
            this.tbNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNome.CustomButton.UseSelectable = true;
            this.tbNome.CustomButton.Visible = false;
            this.tbNome.Lines = new string[0];
            this.tbNome.Location = new System.Drawing.Point(106, 23);
            this.tbNome.MaxLength = 70;
            this.tbNome.Name = "tbNome";
            this.tbNome.PasswordChar = '\0';
            this.tbNome.PromptText = "Nome completo";
            this.tbNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNome.SelectedText = "";
            this.tbNome.SelectionLength = 0;
            this.tbNome.SelectionStart = 0;
            this.tbNome.ShortcutsEnabled = true;
            this.tbNome.Size = new System.Drawing.Size(442, 23);
            this.tbNome.TabIndex = 1;
            this.tbNome.UseSelectable = true;
            this.tbNome.WaterMark = "Nome completo";
            this.tbNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 195);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Adicionais:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(15, 151);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(52, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "Turma: ";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(352, 153);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(40, 19);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "Ano: ";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(15, 108);
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
            // tabLista
            // 
            this.tabLista.Controls.Add(this.tabLista1);
            this.tabLista.Controls.Add(this.tabAtivos);
            this.tabLista.Location = new System.Drawing.Point(613, 63);
            this.tabLista.Name = "tabLista";
            this.tabLista.SelectedIndex = 0;
            this.tabLista.Size = new System.Drawing.Size(614, 497);
            this.tabLista.Style = MetroFramework.MetroColorStyle.Blue;
            this.tabLista.TabIndex = 15;
            this.tabLista.UseSelectable = true;
            // 
            // tabLista1
            // 
            this.tabLista1.Controls.Add(this.listUtilizadores);
            this.tabLista1.Controls.Add(this.btListaDeletar);
            this.tabLista1.Controls.Add(this.btListaAlterar);
            this.tabLista1.HorizontalScrollbarBarColor = true;
            this.tabLista1.HorizontalScrollbarHighlightOnWheel = false;
            this.tabLista1.HorizontalScrollbarSize = 10;
            this.tabLista1.Location = new System.Drawing.Point(4, 38);
            this.tabLista1.Name = "tabLista1";
            this.tabLista1.Size = new System.Drawing.Size(606, 455);
            this.tabLista1.TabIndex = 0;
            this.tabLista1.Text = "Lista de utilizadores";
            this.tabLista1.VerticalScrollbarBarColor = true;
            this.tabLista1.VerticalScrollbarHighlightOnWheel = false;
            this.tabLista1.VerticalScrollbarSize = 10;
            // 
            // listUtilizadores
            // 
            this.listUtilizadores.FormattingEnabled = true;
            this.listUtilizadores.Location = new System.Drawing.Point(17, 23);
            this.listUtilizadores.Name = "listUtilizadores";
            this.listUtilizadores.Size = new System.Drawing.Size(573, 381);
            this.listUtilizadores.TabIndex = 9;
            // 
            // btListaDeletar
            // 
            this.btListaDeletar.Location = new System.Drawing.Point(312, 410);
            this.btListaDeletar.Name = "btListaDeletar";
            this.btListaDeletar.Size = new System.Drawing.Size(278, 30);
            this.btListaDeletar.TabIndex = 11;
            this.btListaDeletar.Text = "Deletar";
            this.btListaDeletar.UseSelectable = true;
            this.btListaDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btListaAlterar
            // 
            this.btListaAlterar.Location = new System.Drawing.Point(17, 410);
            this.btListaAlterar.Name = "btListaAlterar";
            this.btListaAlterar.Size = new System.Drawing.Size(289, 30);
            this.btListaAlterar.TabIndex = 10;
            this.btListaAlterar.Text = "Alterar";
            this.btListaAlterar.UseSelectable = true;
            this.btListaAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // tabAtivos
            // 
            this.tabAtivos.Controls.Add(this.btAtivDeletar);
            this.tabAtivos.Controls.Add(this.btAtivAlterar);
            this.tabAtivos.Controls.Add(this.listAtivos);
            this.tabAtivos.Controls.Add(this.btEmpDeletar);
            this.tabAtivos.Controls.Add(this.btEmpAlterar);
            this.tabAtivos.HorizontalScrollbarBarColor = true;
            this.tabAtivos.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAtivos.HorizontalScrollbarSize = 10;
            this.tabAtivos.Location = new System.Drawing.Point(4, 38);
            this.tabAtivos.Name = "tabAtivos";
            this.tabAtivos.Size = new System.Drawing.Size(606, 455);
            this.tabAtivos.TabIndex = 1;
            this.tabAtivos.Text = "Registos de empréstimos";
            this.tabAtivos.VerticalScrollbarBarColor = true;
            this.tabAtivos.VerticalScrollbarHighlightOnWheel = false;
            this.tabAtivos.VerticalScrollbarSize = 10;
            // 
            // btAtivDeletar
            // 
            this.btAtivDeletar.Location = new System.Drawing.Point(312, 410);
            this.btAtivDeletar.Name = "btAtivDeletar";
            this.btAtivDeletar.Size = new System.Drawing.Size(278, 30);
            this.btAtivDeletar.TabIndex = 17;
            this.btAtivDeletar.Text = "Deletar";
            this.btAtivDeletar.UseSelectable = true;
            // 
            // btAtivAlterar
            // 
            this.btAtivAlterar.Location = new System.Drawing.Point(17, 410);
            this.btAtivAlterar.Name = "btAtivAlterar";
            this.btAtivAlterar.Size = new System.Drawing.Size(289, 30);
            this.btAtivAlterar.TabIndex = 16;
            this.btAtivAlterar.Text = "Alterar";
            this.btAtivAlterar.UseSelectable = true;
            // 
            // listAtivos
            // 
            this.listAtivos.FormattingEnabled = true;
            this.listAtivos.Location = new System.Drawing.Point(17, 23);
            this.listAtivos.Name = "listAtivos";
            this.listAtivos.Size = new System.Drawing.Size(573, 381);
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
            // Utilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 576);
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
            this.pageReg.ResumeLayout(false);
            this.pageReg.PerformLayout();
            this.tabLista.ResumeLayout(false);
            this.tabLista1.ResumeLayout(false);
            this.tabAtivos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabRegisto;
        private MetroFramework.Controls.MetroTabPage pageReg;
        private MetroFramework.Controls.MetroComboBox cbAluAno;
        private MetroFramework.Controls.MetroTextBox tbAdicionais;
        private MetroFramework.Controls.MetroTextBox tbAluTurma;
        private MetroFramework.Controls.MetroTextBox tbProcesso;
        private MetroFramework.Controls.MetroTextBox tbNome;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTabControl tabLista;
        private MetroFramework.Controls.MetroTabPage tabAtivos;
        private MetroFramework.Controls.MetroButton btLimpar;
        private MetroFramework.Controls.MetroButton btSubmeter;
        private MetroFramework.Controls.MetroButton btEmpDeletar;
        private MetroFramework.Controls.MetroButton btEmpAlterar;
        private System.Windows.Forms.ListBox listAtivos;
        private MetroFramework.Controls.MetroButton btAtivDeletar;
        private MetroFramework.Controls.MetroButton btAtivAlterar;
        private MetroFramework.Controls.MetroTabPage tabLista1;
        private System.Windows.Forms.ListBox listUtilizadores;
        private MetroFramework.Controls.MetroButton btListaDeletar;
        private MetroFramework.Controls.MetroButton btListaAlterar;
        private MetroFramework.Controls.MetroComboBox cbFuncao;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}