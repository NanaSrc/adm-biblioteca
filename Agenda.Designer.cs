
namespace biblioteca
{
    partial class Agenda
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
            this.pageLista = new MetroFramework.Controls.MetroTabPage();
            this.pageRegisto = new MetroFramework.Controls.MetroTabPage();
            this.tbDisciplinasProf = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btDeletDisc = new MetroFramework.Controls.MetroButton();
            this.btAddDisc = new MetroFramework.Controls.MetroButton();
            this.cbDisciplinasProf = new MetroFramework.Controls.MetroComboBox();
            this.lbDisciplina = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.pageLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.pageLista);
            this.metroTabControl1.Controls.Add(this.pageRegisto);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1348, 619);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // pageLista
            // 
            this.pageLista.Controls.Add(this.tbDisciplinasProf);
            this.pageLista.Controls.Add(this.metroLabel4);
            this.pageLista.Controls.Add(this.btDeletDisc);
            this.pageLista.Controls.Add(this.btAddDisc);
            this.pageLista.Controls.Add(this.cbDisciplinasProf);
            this.pageLista.Controls.Add(this.lbDisciplina);
            this.pageLista.HorizontalScrollbarBarColor = true;
            this.pageLista.HorizontalScrollbarHighlightOnWheel = false;
            this.pageLista.HorizontalScrollbarSize = 10;
            this.pageLista.Location = new System.Drawing.Point(4, 38);
            this.pageLista.Name = "pageLista";
            this.pageLista.Size = new System.Drawing.Size(1340, 577);
            this.pageLista.Style = MetroFramework.MetroColorStyle.Red;
            this.pageLista.TabIndex = 0;
            this.pageLista.Text = "Lista";
            this.pageLista.VerticalScrollbarBarColor = true;
            this.pageLista.VerticalScrollbarHighlightOnWheel = false;
            this.pageLista.VerticalScrollbarSize = 10;
            // 
            // pageRegisto
            // 
            this.pageRegisto.HorizontalScrollbarBarColor = true;
            this.pageRegisto.HorizontalScrollbarHighlightOnWheel = false;
            this.pageRegisto.HorizontalScrollbarSize = 10;
            this.pageRegisto.Location = new System.Drawing.Point(4, 38);
            this.pageRegisto.Name = "pageRegisto";
            this.pageRegisto.Size = new System.Drawing.Size(1340, 577);
            this.pageRegisto.TabIndex = 1;
            this.pageRegisto.Text = "Registo";
            this.pageRegisto.VerticalScrollbarBarColor = true;
            this.pageRegisto.VerticalScrollbarHighlightOnWheel = false;
            this.pageRegisto.VerticalScrollbarSize = 10;
            // 
            // tbDisciplinasProf
            // 
            // 
            // 
            // 
            this.tbDisciplinasProf.CustomButton.Image = null;
            this.tbDisciplinasProf.CustomButton.Location = new System.Drawing.Point(244, 2);
            this.tbDisciplinasProf.CustomButton.Name = "";
            this.tbDisciplinasProf.CustomButton.Size = new System.Drawing.Size(85, 85);
            this.tbDisciplinasProf.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDisciplinasProf.CustomButton.TabIndex = 1;
            this.tbDisciplinasProf.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDisciplinasProf.CustomButton.UseSelectable = true;
            this.tbDisciplinasProf.CustomButton.Visible = false;
            this.tbDisciplinasProf.Lines = new string[0];
            this.tbDisciplinasProf.Location = new System.Drawing.Point(112, 33);
            this.tbDisciplinasProf.MaxLength = 32767;
            this.tbDisciplinasProf.Multiline = true;
            this.tbDisciplinasProf.Name = "tbDisciplinasProf";
            this.tbDisciplinasProf.PasswordChar = '\0';
            this.tbDisciplinasProf.PromptText = "Disciplinas";
            this.tbDisciplinasProf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDisciplinasProf.SelectedText = "";
            this.tbDisciplinasProf.SelectionLength = 0;
            this.tbDisciplinasProf.SelectionStart = 0;
            this.tbDisciplinasProf.ShortcutsEnabled = true;
            this.tbDisciplinasProf.Size = new System.Drawing.Size(332, 90);
            this.tbDisciplinasProf.TabIndex = 22;
            this.tbDisciplinasProf.UseSelectable = true;
            this.tbDisciplinasProf.WaterMark = "Disciplinas";
            this.tbDisciplinasProf.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDisciplinasProf.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 33);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "Disciplinas:";
            // 
            // btDeletDisc
            // 
            this.btDeletDisc.Location = new System.Drawing.Point(450, 94);
            this.btDeletDisc.Name = "btDeletDisc";
            this.btDeletDisc.Size = new System.Drawing.Size(112, 29);
            this.btDeletDisc.TabIndex = 20;
            this.btDeletDisc.Text = "Deletar disciplina";
            this.btDeletDisc.UseSelectable = true;
            // 
            // btAddDisc
            // 
            this.btAddDisc.Location = new System.Drawing.Point(568, 94);
            this.btAddDisc.Name = "btAddDisc";
            this.btAddDisc.Size = new System.Drawing.Size(111, 29);
            this.btAddDisc.TabIndex = 19;
            this.btAddDisc.Text = "Adicionar disciplina";
            this.btAddDisc.UseSelectable = true;
            // 
            // cbDisciplinasProf
            // 
            this.cbDisciplinasProf.FormattingEnabled = true;
            this.cbDisciplinasProf.ItemHeight = 23;
            this.cbDisciplinasProf.Items.AddRange(new object[] {
            "Biologia",
            "Ciências",
            "Desenho",
            "Educação Física",
            "Educação Visual",
            "Filosofia",
            "Física",
            "Francês",
            "Geografia",
            "Geometria",
            "História",
            "Informática",
            "Inglês",
            "Literatura",
            "Matemática",
            "Música",
            "Português",
            "Sociologia"});
            this.cbDisciplinasProf.Location = new System.Drawing.Point(450, 55);
            this.cbDisciplinasProf.Name = "cbDisciplinasProf";
            this.cbDisciplinasProf.Size = new System.Drawing.Size(229, 29);
            this.cbDisciplinasProf.TabIndex = 18;
            this.cbDisciplinasProf.UseSelectable = true;
            // 
            // lbDisciplina
            // 
            this.lbDisciplina.AutoSize = true;
            this.lbDisciplina.Location = new System.Drawing.Point(450, 33);
            this.lbDisciplina.Name = "lbDisciplina";
            this.lbDisciplina.Size = new System.Drawing.Size(129, 19);
            this.lbDisciplina.TabIndex = 17;
            this.lbDisciplina.Text = "Selecionar disciplina:";
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 698);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Agenda";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.pageLista.ResumeLayout(false);
            this.pageLista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage pageLista;
        private MetroFramework.Controls.MetroTabPage pageRegisto;
        private MetroFramework.Controls.MetroTextBox tbDisciplinasProf;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btDeletDisc;
        private MetroFramework.Controls.MetroButton btAddDisc;
        private MetroFramework.Controls.MetroComboBox cbDisciplinasProf;
        private MetroFramework.Controls.MetroLabel lbDisciplina;
    }
}