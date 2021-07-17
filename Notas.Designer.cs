
namespace biblioteca
{
    partial class Notas
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
            this.tabRegisto = new MetroFramework.Controls.MetroTabControl();
            this.pageNova = new MetroFramework.Controls.MetroTabPage();
            this.tbSubtitulo = new MetroFramework.Controls.MetroTextBox();
            this.tbConteudo = new MetroFramework.Controls.MetroTextBox();
            this.tbTitulo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tabLista = new MetroFramework.Controls.MetroTabControl();
            this.tabLista1 = new MetroFramework.Controls.MetroTabPage();
            this.btDeletar = new MetroFramework.Controls.MetroButton();
            this.btAlterar = new MetroFramework.Controls.MetroButton();
            this.gridLista = new MetroFramework.Controls.MetroGrid();
            this.btSubmeter = new MetroFramework.Controls.MetroButton();
            this.btLimpar = new MetroFramework.Controls.MetroButton();
            this.tbAutor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tabRegisto.SuspendLayout();
            this.pageNova.SuspendLayout();
            this.tabLista.SuspendLayout();
            this.tabLista1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRegisto
            // 
            this.tabRegisto.Controls.Add(this.pageNova);
            this.tabRegisto.Location = new System.Drawing.Point(23, 63);
            this.tabRegisto.Name = "tabRegisto";
            this.tabRegisto.SelectedIndex = 0;
            this.tabRegisto.Size = new System.Drawing.Size(714, 606);
            this.tabRegisto.Style = MetroFramework.MetroColorStyle.Purple;
            this.tabRegisto.TabIndex = 1;
            this.tabRegisto.UseSelectable = true;
            // 
            // pageNova
            // 
            this.pageNova.Controls.Add(this.tbAutor);
            this.pageNova.Controls.Add(this.metroLabel1);
            this.pageNova.Controls.Add(this.tbSubtitulo);
            this.pageNova.Controls.Add(this.tbConteudo);
            this.pageNova.Controls.Add(this.tbTitulo);
            this.pageNova.Controls.Add(this.metroLabel10);
            this.pageNova.Controls.Add(this.metroLabel9);
            this.pageNova.Controls.Add(this.metroLabel3);
            this.pageNova.HorizontalScrollbarBarColor = true;
            this.pageNova.HorizontalScrollbarHighlightOnWheel = false;
            this.pageNova.HorizontalScrollbarSize = 10;
            this.pageNova.Location = new System.Drawing.Point(4, 38);
            this.pageNova.Name = "pageNova";
            this.pageNova.Size = new System.Drawing.Size(706, 564);
            this.pageNova.TabIndex = 1;
            this.pageNova.Text = "Nova nota";
            this.pageNova.VerticalScrollbarBarColor = true;
            this.pageNova.VerticalScrollbarHighlightOnWheel = false;
            this.pageNova.VerticalScrollbarSize = 10;
            // 
            // tbSubtitulo
            // 
            // 
            // 
            // 
            this.tbSubtitulo.CustomButton.Image = null;
            this.tbSubtitulo.CustomButton.Location = new System.Drawing.Point(545, 1);
            this.tbSubtitulo.CustomButton.Name = "";
            this.tbSubtitulo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSubtitulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSubtitulo.CustomButton.TabIndex = 1;
            this.tbSubtitulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSubtitulo.CustomButton.UseSelectable = true;
            this.tbSubtitulo.CustomButton.Visible = false;
            this.tbSubtitulo.Lines = new string[0];
            this.tbSubtitulo.Location = new System.Drawing.Point(112, 111);
            this.tbSubtitulo.MaxLength = 32767;
            this.tbSubtitulo.Name = "tbSubtitulo";
            this.tbSubtitulo.PasswordChar = '\0';
            this.tbSubtitulo.PromptText = "Subtítulo";
            this.tbSubtitulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSubtitulo.SelectedText = "";
            this.tbSubtitulo.SelectionLength = 0;
            this.tbSubtitulo.SelectionStart = 0;
            this.tbSubtitulo.ShortcutsEnabled = true;
            this.tbSubtitulo.Size = new System.Drawing.Size(567, 23);
            this.tbSubtitulo.TabIndex = 74;
            this.tbSubtitulo.UseSelectable = true;
            this.tbSubtitulo.WaterMark = "Subtítulo";
            this.tbSubtitulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSubtitulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbConteudo
            // 
            // 
            // 
            // 
            this.tbConteudo.CustomButton.Image = null;
            this.tbConteudo.CustomButton.Location = new System.Drawing.Point(228, 2);
            this.tbConteudo.CustomButton.Name = "";
            this.tbConteudo.CustomButton.Size = new System.Drawing.Size(337, 337);
            this.tbConteudo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbConteudo.CustomButton.TabIndex = 1;
            this.tbConteudo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbConteudo.CustomButton.UseSelectable = true;
            this.tbConteudo.CustomButton.Visible = false;
            this.tbConteudo.Lines = new string[0];
            this.tbConteudo.Location = new System.Drawing.Point(112, 153);
            this.tbConteudo.MaxLength = 32767;
            this.tbConteudo.Multiline = true;
            this.tbConteudo.Name = "tbConteudo";
            this.tbConteudo.PasswordChar = '\0';
            this.tbConteudo.PromptText = "Conteúdo da anotação";
            this.tbConteudo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbConteudo.SelectedText = "";
            this.tbConteudo.SelectionLength = 0;
            this.tbConteudo.SelectionStart = 0;
            this.tbConteudo.ShortcutsEnabled = true;
            this.tbConteudo.Size = new System.Drawing.Size(568, 342);
            this.tbConteudo.TabIndex = 72;
            this.tbConteudo.UseSelectable = true;
            this.tbConteudo.WaterMark = "Conteúdo da anotação";
            this.tbConteudo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbConteudo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbTitulo
            // 
            // 
            // 
            // 
            this.tbTitulo.CustomButton.Image = null;
            this.tbTitulo.CustomButton.Location = new System.Drawing.Point(545, 1);
            this.tbTitulo.CustomButton.Name = "";
            this.tbTitulo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbTitulo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTitulo.CustomButton.TabIndex = 1;
            this.tbTitulo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTitulo.CustomButton.UseSelectable = true;
            this.tbTitulo.CustomButton.Visible = false;
            this.tbTitulo.Lines = new string[0];
            this.tbTitulo.Location = new System.Drawing.Point(112, 73);
            this.tbTitulo.MaxLength = 32767;
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.PasswordChar = '\0';
            this.tbTitulo.PromptText = "Título";
            this.tbTitulo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTitulo.SelectedText = "";
            this.tbTitulo.SelectionLength = 0;
            this.tbTitulo.SelectionStart = 0;
            this.tbTitulo.ShortcutsEnabled = true;
            this.tbTitulo.Size = new System.Drawing.Size(567, 23);
            this.tbTitulo.TabIndex = 71;
            this.tbTitulo.UseSelectable = true;
            this.tbTitulo.WaterMark = "Título";
            this.tbTitulo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTitulo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(17, 73);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(54, 19);
            this.metroLabel10.TabIndex = 67;
            this.metroLabel10.Text = "Título: ⁎";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(17, 111);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(63, 19);
            this.metroLabel9.TabIndex = 70;
            this.metroLabel9.Text = "Subtítulo:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 153);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.TabIndex = 68;
            this.metroLabel3.Text = "Conteúdo: ⁎";
            // 
            // tabLista
            // 
            this.tabLista.Controls.Add(this.tabLista1);
            this.tabLista.Location = new System.Drawing.Point(743, 63);
            this.tabLista.Name = "tabLista";
            this.tabLista.SelectedIndex = 0;
            this.tabLista.Size = new System.Drawing.Size(614, 606);
            this.tabLista.Style = MetroFramework.MetroColorStyle.Purple;
            this.tabLista.TabIndex = 16;
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
            // btSubmeter
            // 
            this.btSubmeter.Location = new System.Drawing.Point(427, 619);
            this.btSubmeter.Name = "btSubmeter";
            this.btSubmeter.Size = new System.Drawing.Size(280, 30);
            this.btSubmeter.TabIndex = 65;
            this.btSubmeter.Text = "Submeter";
            this.btSubmeter.UseSelectable = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(140, 619);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(281, 30);
            this.btLimpar.TabIndex = 66;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseSelectable = true;
            // 
            // tbAutor
            // 
            // 
            // 
            // 
            this.tbAutor.CustomButton.Image = null;
            this.tbAutor.CustomButton.Location = new System.Drawing.Point(545, 1);
            this.tbAutor.CustomButton.Name = "";
            this.tbAutor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAutor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAutor.CustomButton.TabIndex = 1;
            this.tbAutor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAutor.CustomButton.UseSelectable = true;
            this.tbAutor.CustomButton.Visible = false;
            this.tbAutor.Lines = new string[0];
            this.tbAutor.Location = new System.Drawing.Point(112, 33);
            this.tbAutor.MaxLength = 32767;
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.PasswordChar = '\0';
            this.tbAutor.PromptText = "Título";
            this.tbAutor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAutor.SelectedText = "";
            this.tbAutor.SelectionLength = 0;
            this.tbAutor.SelectionStart = 0;
            this.tbAutor.ShortcutsEnabled = true;
            this.tbAutor.Size = new System.Drawing.Size(567, 23);
            this.tbAutor.TabIndex = 76;
            this.tbAutor.UseSelectable = true;
            this.tbAutor.WaterMark = "Título";
            this.tbAutor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAutor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 75;
            this.metroLabel1.Text = "Autor: ⁎";
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 698);
            this.ControlBox = false;
            this.Controls.Add(this.btSubmeter);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.tabLista);
            this.Controls.Add(this.tabRegisto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Notas";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.Notas_Load);
            this.tabRegisto.ResumeLayout(false);
            this.pageNova.ResumeLayout(false);
            this.pageNova.PerformLayout();
            this.tabLista.ResumeLayout(false);
            this.tabLista1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabRegisto;
        private MetroFramework.Controls.MetroTabPage pageNova;
        private MetroFramework.Controls.MetroTabControl tabLista;
        private MetroFramework.Controls.MetroTabPage tabLista1;
        private MetroFramework.Controls.MetroButton btDeletar;
        private MetroFramework.Controls.MetroButton btAlterar;
        private MetroFramework.Controls.MetroGrid gridLista;
        private MetroFramework.Controls.MetroButton btSubmeter;
        private MetroFramework.Controls.MetroButton btLimpar;
        private MetroFramework.Controls.MetroTextBox tbSubtitulo;
        private MetroFramework.Controls.MetroTextBox tbConteudo;
        private MetroFramework.Controls.MetroTextBox tbTitulo;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbAutor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}