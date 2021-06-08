
namespace biblioteca
{
    partial class Configuracoes
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
            this.pageApp = new MetroFramework.Controls.MetroTabPage();
            this.pageAcesso = new MetroFramework.Controls.MetroTabPage();
            this.pageInformacoes = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.pageApp);
            this.metroTabControl1.Controls.Add(this.pageAcesso);
            this.metroTabControl1.Controls.Add(this.pageInformacoes);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1348, 619);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // pageApp
            // 
            this.pageApp.HorizontalScrollbarBarColor = true;
            this.pageApp.HorizontalScrollbarHighlightOnWheel = false;
            this.pageApp.HorizontalScrollbarSize = 10;
            this.pageApp.Location = new System.Drawing.Point(4, 38);
            this.pageApp.Name = "pageApp";
            this.pageApp.Size = new System.Drawing.Size(1340, 577);
            this.pageApp.TabIndex = 0;
            this.pageApp.Text = "Aplicação";
            this.pageApp.VerticalScrollbarBarColor = true;
            this.pageApp.VerticalScrollbarHighlightOnWheel = false;
            this.pageApp.VerticalScrollbarSize = 10;
            // 
            // pageAcesso
            // 
            this.pageAcesso.HorizontalScrollbarBarColor = true;
            this.pageAcesso.HorizontalScrollbarHighlightOnWheel = false;
            this.pageAcesso.HorizontalScrollbarSize = 10;
            this.pageAcesso.Location = new System.Drawing.Point(4, 38);
            this.pageAcesso.Name = "pageAcesso";
            this.pageAcesso.Size = new System.Drawing.Size(1340, 577);
            this.pageAcesso.TabIndex = 1;
            this.pageAcesso.Text = "Acesso";
            this.pageAcesso.VerticalScrollbarBarColor = true;
            this.pageAcesso.VerticalScrollbarHighlightOnWheel = false;
            this.pageAcesso.VerticalScrollbarSize = 10;
            // 
            // pageInformacoes
            // 
            this.pageInformacoes.HorizontalScrollbarBarColor = true;
            this.pageInformacoes.HorizontalScrollbarHighlightOnWheel = false;
            this.pageInformacoes.HorizontalScrollbarSize = 10;
            this.pageInformacoes.Location = new System.Drawing.Point(4, 38);
            this.pageInformacoes.Name = "pageInformacoes";
            this.pageInformacoes.Size = new System.Drawing.Size(1340, 577);
            this.pageInformacoes.TabIndex = 2;
            this.pageInformacoes.Text = "Informações";
            this.pageInformacoes.VerticalScrollbarBarColor = true;
            this.pageInformacoes.VerticalScrollbarHighlightOnWheel = false;
            this.pageInformacoes.VerticalScrollbarSize = 10;
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 698);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Configuracoes";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.Configuracoes_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage pageApp;
        private MetroFramework.Controls.MetroTabPage pageAcesso;
        private MetroFramework.Controls.MetroTabPage pageInformacoes;
    }
}