
namespace biblioteca
{
    partial class Calendario
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
            this.metroTabControl1.SuspendLayout();
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
            this.pageLista.HorizontalScrollbarBarColor = true;
            this.pageLista.HorizontalScrollbarHighlightOnWheel = false;
            this.pageLista.HorizontalScrollbarSize = 10;
            this.pageLista.Location = new System.Drawing.Point(4, 38);
            this.pageLista.Name = "pageLista";
            this.pageLista.Size = new System.Drawing.Size(1340, 577);
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
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 698);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Calendario";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Calendário";
            this.Load += new System.EventHandler(this.Calendario_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage pageLista;
        private MetroFramework.Controls.MetroTabPage pageRegisto;
    }
}