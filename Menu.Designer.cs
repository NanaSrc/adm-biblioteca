
namespace biblioteca
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btEquipamentos = new MetroFramework.Controls.MetroTile();
            this.btSalas = new MetroFramework.Controls.MetroTile();
            this.btConsultas = new MetroFramework.Controls.MetroTile();
            this.btNotas = new MetroFramework.Controls.MetroTile();
            this.btLogins = new MetroFramework.Controls.MetroTile();
            this.btLogout = new MetroFramework.Controls.MetroTile();
            this.btSair = new MetroFramework.Controls.MetroTile();
            this.btUtilizadores = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(23, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1394, 729);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 106);
            this.label1.TabIndex = 2;
            this.label1.Text = "Biblioteca Escolar Gestão";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // btEquipamentos
            // 
            this.btEquipamentos.ActiveControl = null;
            this.btEquipamentos.Location = new System.Drawing.Point(464, 36);
            this.btEquipamentos.Name = "btEquipamentos";
            this.btEquipamentos.Size = new System.Drawing.Size(131, 106);
            this.btEquipamentos.Style = MetroFramework.MetroColorStyle.Orange;
            this.btEquipamentos.TabIndex = 3;
            this.btEquipamentos.Text = "Equipamentos";
            this.btEquipamentos.UseSelectable = true;
            // 
            // btSalas
            // 
            this.btSalas.ActiveControl = null;
            this.btSalas.Location = new System.Drawing.Point(601, 36);
            this.btSalas.Name = "btSalas";
            this.btSalas.Size = new System.Drawing.Size(131, 106);
            this.btSalas.Style = MetroFramework.MetroColorStyle.Orange;
            this.btSalas.TabIndex = 4;
            this.btSalas.Text = "Salas";
            this.btSalas.UseSelectable = true;
            // 
            // btConsultas
            // 
            this.btConsultas.ActiveControl = null;
            this.btConsultas.Location = new System.Drawing.Point(738, 36);
            this.btConsultas.Name = "btConsultas";
            this.btConsultas.Size = new System.Drawing.Size(131, 106);
            this.btConsultas.Style = MetroFramework.MetroColorStyle.Orange;
            this.btConsultas.TabIndex = 5;
            this.btConsultas.Text = "Consultas";
            this.btConsultas.UseSelectable = true;
            this.btConsultas.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // btNotas
            // 
            this.btNotas.ActiveControl = null;
            this.btNotas.Location = new System.Drawing.Point(875, 36);
            this.btNotas.Name = "btNotas";
            this.btNotas.Size = new System.Drawing.Size(131, 106);
            this.btNotas.Style = MetroFramework.MetroColorStyle.Orange;
            this.btNotas.TabIndex = 6;
            this.btNotas.Text = "Notas";
            this.btNotas.UseSelectable = true;
            // 
            // btLogins
            // 
            this.btLogins.ActiveControl = null;
            this.btLogins.Location = new System.Drawing.Point(1012, 36);
            this.btLogins.Name = "btLogins";
            this.btLogins.Size = new System.Drawing.Size(131, 106);
            this.btLogins.Style = MetroFramework.MetroColorStyle.Orange;
            this.btLogins.TabIndex = 7;
            this.btLogins.Text = "Logins";
            this.btLogins.UseSelectable = true;
            // 
            // btLogout
            // 
            this.btLogout.ActiveControl = null;
            this.btLogout.Location = new System.Drawing.Point(1149, 36);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(131, 106);
            this.btLogout.Style = MetroFramework.MetroColorStyle.Blue;
            this.btLogout.TabIndex = 8;
            this.btLogout.Text = "Logout";
            this.btLogout.UseSelectable = true;
            // 
            // btSair
            // 
            this.btSair.ActiveControl = null;
            this.btSair.Location = new System.Drawing.Point(1286, 36);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(131, 106);
            this.btSair.TabIndex = 9;
            this.btSair.Text = "Sair";
            this.btSair.UseSelectable = true;
            this.btSair.Click += new System.EventHandler(this.metroTile2_Click_1);
            // 
            // btUtilizadores
            // 
            this.btUtilizadores.ActiveControl = null;
            this.btUtilizadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUtilizadores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btUtilizadores.Location = new System.Drawing.Point(327, 36);
            this.btUtilizadores.Name = "btUtilizadores";
            this.btUtilizadores.PaintTileCount = false;
            this.btUtilizadores.Size = new System.Drawing.Size(131, 106);
            this.btUtilizadores.Style = MetroFramework.MetroColorStyle.Orange;
            this.btUtilizadores.TabIndex = 2;
            this.btUtilizadores.Text = "Utilizadores";
            this.btUtilizadores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btUtilizadores.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btUtilizadores.TileImage = global::biblioteca.Properties.Resources.utilizadores1;
            this.btUtilizadores.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btUtilizadores.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btUtilizadores.UseCustomForeColor = true;
            this.btUtilizadores.UseSelectable = true;
            this.btUtilizadores.UseStyleColors = true;
            this.btUtilizadores.UseTileImage = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::biblioteca.Properties.Resources.biblio1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = global::biblioteca.Properties.Resources.biblio;
            this.pictureBox1.InitialImage = global::biblioteca.Properties.Resources.biblio;
            this.pictureBox1.Location = new System.Drawing.Point(23, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 106);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btLogins);
            this.Controls.Add(this.btNotas);
            this.Controls.Add(this.btConsultas);
            this.Controls.Add(this.btSalas);
            this.Controls.Add(this.btEquipamentos);
            this.Controls.Add(this.btUtilizadores);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile btUtilizadores;
        private MetroFramework.Controls.MetroTile btEquipamentos;
        private MetroFramework.Controls.MetroTile btSalas;
        private MetroFramework.Controls.MetroTile btConsultas;
        private MetroFramework.Controls.MetroTile btNotas;
        private MetroFramework.Controls.MetroTile btLogins;
        private MetroFramework.Controls.MetroTile btLogout;
        private MetroFramework.Controls.MetroTile btSair;
    }
}

