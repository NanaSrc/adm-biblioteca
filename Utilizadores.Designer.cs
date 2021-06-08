
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.pageProfessor = new MetroFramework.Controls.MetroTabPage();
            this.pageAluno = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tbNome = new MetroFramework.Controls.MetroTextBox();
            this.tbAno = new MetroFramework.Controls.MetroTextBox();
            this.tbTurma = new MetroFramework.Controls.MetroTextBox();
            this.tbAdicionais = new MetroFramework.Controls.MetroTextBox();
            this.cbAno = new MetroFramework.Controls.MetroComboBox();
            this.btSubmeter = new MetroFramework.Controls.MetroButton();
            this.btLimpar = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.pageAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.pageProfessor);
            this.metroTabControl1.Controls.Add(this.pageAluno);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(809, 619);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // pageProfessor
            // 
            this.pageProfessor.HorizontalScrollbarBarColor = true;
            this.pageProfessor.HorizontalScrollbarHighlightOnWheel = false;
            this.pageProfessor.HorizontalScrollbarSize = 10;
            this.pageProfessor.Location = new System.Drawing.Point(4, 38);
            this.pageProfessor.Name = "pageProfessor";
            this.pageProfessor.Size = new System.Drawing.Size(801, 577);
            this.pageProfessor.TabIndex = 0;
            this.pageProfessor.Text = "Professor";
            this.pageProfessor.VerticalScrollbarBarColor = true;
            this.pageProfessor.VerticalScrollbarHighlightOnWheel = false;
            this.pageProfessor.VerticalScrollbarSize = 10;
            // 
            // pageAluno
            // 
            this.pageAluno.Controls.Add(this.btLimpar);
            this.pageAluno.Controls.Add(this.btSubmeter);
            this.pageAluno.Controls.Add(this.cbAno);
            this.pageAluno.Controls.Add(this.tbAdicionais);
            this.pageAluno.Controls.Add(this.tbTurma);
            this.pageAluno.Controls.Add(this.tbAno);
            this.pageAluno.Controls.Add(this.tbNome);
            this.pageAluno.Controls.Add(this.metroLabel7);
            this.pageAluno.Controls.Add(this.metroLabel5);
            this.pageAluno.Controls.Add(this.metroLabel4);
            this.pageAluno.Controls.Add(this.metroLabel2);
            this.pageAluno.Controls.Add(this.metroLabel1);
            this.pageAluno.HorizontalScrollbarBarColor = true;
            this.pageAluno.HorizontalScrollbarHighlightOnWheel = false;
            this.pageAluno.HorizontalScrollbarSize = 10;
            this.pageAluno.Location = new System.Drawing.Point(4, 38);
            this.pageAluno.Name = "pageAluno";
            this.pageAluno.Size = new System.Drawing.Size(801, 577);
            this.pageAluno.TabIndex = 1;
            this.pageAluno.Text = "Aluno";
            this.pageAluno.VerticalScrollbarBarColor = true;
            this.pageAluno.VerticalScrollbarHighlightOnWheel = false;
            this.pageAluno.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 46);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nome:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 81);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Processo:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(4, 119);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(36, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Ano:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 162);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Turma:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(0, 202);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(71, 19);
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "Adicionais:";
            // 
            // tbNome
            // 
            // 
            // 
            // 
            this.tbNome.CustomButton.Image = null;
            this.tbNome.CustomButton.Location = new System.Drawing.Point(695, 1);
            this.tbNome.CustomButton.Name = "";
            this.tbNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNome.CustomButton.TabIndex = 1;
            this.tbNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNome.CustomButton.UseSelectable = true;
            this.tbNome.CustomButton.Visible = false;
            this.tbNome.Lines = new string[0];
            this.tbNome.Location = new System.Drawing.Point(81, 46);
            this.tbNome.MaxLength = 32767;
            this.tbNome.Name = "tbNome";
            this.tbNome.PasswordChar = '\0';
            this.tbNome.PromptText = "Nome completo";
            this.tbNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNome.SelectedText = "";
            this.tbNome.SelectionLength = 0;
            this.tbNome.SelectionStart = 0;
            this.tbNome.ShortcutsEnabled = true;
            this.tbNome.Size = new System.Drawing.Size(695, 23);
            this.tbNome.TabIndex = 4;
            this.tbNome.UseSelectable = true;
            this.tbNome.WaterMark = "Nome completo";
            this.tbNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbAno
            // 
            // 
            // 
            // 
            this.tbAno.CustomButton.Image = null;
            this.tbAno.CustomButton.Location = new System.Drawing.Point(695, 1);
            this.tbAno.CustomButton.Name = "";
            this.tbAno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAno.CustomButton.TabIndex = 1;
            this.tbAno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAno.CustomButton.UseSelectable = true;
            this.tbAno.CustomButton.Visible = false;
            this.tbAno.Lines = new string[0];
            this.tbAno.Location = new System.Drawing.Point(81, 81);
            this.tbAno.MaxLength = 32767;
            this.tbAno.Name = "tbAno";
            this.tbAno.PasswordChar = '\0';
            this.tbAno.PromptText = "Número do processo escolar";
            this.tbAno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAno.SelectedText = "";
            this.tbAno.SelectionLength = 0;
            this.tbAno.SelectionStart = 0;
            this.tbAno.ShortcutsEnabled = true;
            this.tbAno.Size = new System.Drawing.Size(695, 23);
            this.tbAno.TabIndex = 5;
            this.tbAno.UseSelectable = true;
            this.tbAno.WaterMark = "Número do processo escolar";
            this.tbAno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbTurma
            // 
            // 
            // 
            // 
            this.tbTurma.CustomButton.Image = null;
            this.tbTurma.CustomButton.Location = new System.Drawing.Point(695, 1);
            this.tbTurma.CustomButton.Name = "";
            this.tbTurma.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbTurma.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTurma.CustomButton.TabIndex = 1;
            this.tbTurma.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTurma.CustomButton.UseSelectable = true;
            this.tbTurma.CustomButton.Visible = false;
            this.tbTurma.Lines = new string[0];
            this.tbTurma.Location = new System.Drawing.Point(81, 162);
            this.tbTurma.MaxLength = 32767;
            this.tbTurma.Name = "tbTurma";
            this.tbTurma.PasswordChar = '\0';
            this.tbTurma.PromptText = "Designação da turma";
            this.tbTurma.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTurma.SelectedText = "";
            this.tbTurma.SelectionLength = 0;
            this.tbTurma.SelectionStart = 0;
            this.tbTurma.ShortcutsEnabled = true;
            this.tbTurma.Size = new System.Drawing.Size(695, 23);
            this.tbTurma.TabIndex = 7;
            this.tbTurma.UseSelectable = true;
            this.tbTurma.WaterMark = "Designação da turma";
            this.tbTurma.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTurma.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbAdicionais
            // 
            // 
            // 
            // 
            this.tbAdicionais.CustomButton.Image = null;
            this.tbAdicionais.CustomButton.Location = new System.Drawing.Point(591, 1);
            this.tbAdicionais.CustomButton.Name = "";
            this.tbAdicionais.CustomButton.Size = new System.Drawing.Size(125, 125);
            this.tbAdicionais.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAdicionais.CustomButton.TabIndex = 1;
            this.tbAdicionais.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAdicionais.CustomButton.UseSelectable = true;
            this.tbAdicionais.CustomButton.Visible = false;
            this.tbAdicionais.Lines = new string[0];
            this.tbAdicionais.Location = new System.Drawing.Point(81, 202);
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
            this.tbAdicionais.Size = new System.Drawing.Size(695, 127);
            this.tbAdicionais.TabIndex = 8;
            this.tbAdicionais.UseSelectable = true;
            this.tbAdicionais.WaterMark = "Anotações adicionais";
            this.tbAdicionais.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAdicionais.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbAno
            // 
            this.cbAno.FormattingEnabled = true;
            this.cbAno.ItemHeight = 23;
            this.cbAno.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "Outro"});
            this.cbAno.Location = new System.Drawing.Point(81, 119);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(154, 29);
            this.cbAno.TabIndex = 9;
            this.cbAno.UseSelectable = true;
            // 
            // btSubmeter
            // 
            this.btSubmeter.Location = new System.Drawing.Point(445, 350);
            this.btSubmeter.Name = "btSubmeter";
            this.btSubmeter.Size = new System.Drawing.Size(331, 30);
            this.btSubmeter.TabIndex = 10;
            this.btSubmeter.Text = "Submeter";
            this.btSubmeter.UseSelectable = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(81, 350);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(358, 30);
            this.btLimpar.TabIndex = 11;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseSelectable = true;
            // 
            // Utilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 698);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Utilizadores";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Utilizadores";
            this.Load += new System.EventHandler(this.Utilizadores_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.pageAluno.ResumeLayout(false);
            this.pageAluno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage pageProfessor;
        private MetroFramework.Controls.MetroTabPage pageAluno;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox tbAdicionais;
        private MetroFramework.Controls.MetroTextBox tbTurma;
        private MetroFramework.Controls.MetroTextBox tbAno;
        private MetroFramework.Controls.MetroTextBox tbNome;
        private MetroFramework.Controls.MetroComboBox cbAno;
        private MetroFramework.Controls.MetroButton btSubmeter;
        private MetroFramework.Controls.MetroButton btLimpar;
    }
}