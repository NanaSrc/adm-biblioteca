
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
            this.btEmprestimos = new MetroFramework.Controls.MetroTile();
            this.btSair = new MetroFramework.Controls.MetroTile();
            this.btLogout = new MetroFramework.Controls.MetroTile();
            this.btConfigs = new MetroFramework.Controls.MetroTile();
            this.btNotas = new MetroFramework.Controls.MetroTile();
            this.btEventos = new MetroFramework.Controls.MetroTile();
            this.btSalas = new MetroFramework.Controls.MetroTile();
            this.btEquipamentos = new MetroFramework.Controls.MetroTile();
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
            // btEmprestimos
            // 
            this.btEmprestimos.AccessibleName = "Requisitados";
            this.btEmprestimos.ActiveControl = null;
            this.btEmprestimos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEmprestimos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btEmprestimos.Location = new System.Drawing.Point(601, 36);
            this.btEmprestimos.Name = "btEmprestimos";
            this.btEmprestimos.PaintTileCount = false;
            this.btEmprestimos.Size = new System.Drawing.Size(131, 106);
            this.btEmprestimos.Style = MetroFramework.MetroColorStyle.Orange;
            this.btEmprestimos.TabIndex = 10;
            this.btEmprestimos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEmprestimos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btEmprestimos.TileImage = global::biblioteca.Properties.Resources.notas51;
            this.btEmprestimos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btEmprestimos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btEmprestimos.UseCustomForeColor = true;
            this.btEmprestimos.UseSelectable = true;
            this.btEmprestimos.UseStyleColors = true;
            this.btEmprestimos.UseTileImage = true;
            // 
            // btSair
            // 
            this.btSair.AccessibleName = "Sair";
            this.btSair.ActiveControl = null;
            this.btSair.Location = new System.Drawing.Point(1286, 36);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(131, 106);
            this.btSair.TabIndex = 9;
            this.btSair.TileImage = global::biblioteca.Properties.Resources.sair5;
            this.btSair.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSair.UseSelectable = true;
            this.btSair.UseTileImage = true;
            this.btSair.Click += new System.EventHandler(this.metroTile2_Click_1);
            // 
            // btLogout
            // 
            this.btLogout.AccessibleName = "Logout";
            this.btLogout.ActiveControl = null;
            this.btLogout.Location = new System.Drawing.Point(1149, 36);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(131, 106);
            this.btLogout.Style = MetroFramework.MetroColorStyle.Blue;
            this.btLogout.TabIndex = 8;
            this.btLogout.TileImage = global::biblioteca.Properties.Resources.sair9;
            this.btLogout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btLogout.UseSelectable = true;
            this.btLogout.UseTileImage = true;
            // 
            // btConfigs
            // 
            this.btConfigs.AccessibleName = "Configurações";
            this.btConfigs.ActiveControl = null;
            this.btConfigs.Location = new System.Drawing.Point(1012, 36);
            this.btConfigs.Name = "btConfigs";
            this.btConfigs.Size = new System.Drawing.Size(131, 106);
            this.btConfigs.Style = MetroFramework.MetroColorStyle.Orange;
            this.btConfigs.TabIndex = 7;
            this.btConfigs.TileImage = global::biblioteca.Properties.Resources.settings3;
            this.btConfigs.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btConfigs.UseSelectable = true;
            this.btConfigs.UseTileImage = true;
            // 
            // btNotas
            // 
            this.btNotas.AccessibleName = "Notas";
            this.btNotas.ActiveControl = null;
            this.btNotas.Location = new System.Drawing.Point(875, 36);
            this.btNotas.Name = "btNotas";
            this.btNotas.Size = new System.Drawing.Size(131, 106);
            this.btNotas.Style = MetroFramework.MetroColorStyle.Orange;
            this.btNotas.TabIndex = 6;
            this.btNotas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btNotas.TileImage = global::biblioteca.Properties.Resources.notas4;
            this.btNotas.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btNotas.UseSelectable = true;
            this.btNotas.UseTileImage = true;
            // 
            // btEventos
            // 
            this.btEventos.AccessibleName = "Calendário";
            this.btEventos.ActiveControl = null;
            this.btEventos.Location = new System.Drawing.Point(738, 36);
            this.btEventos.Name = "btEventos";
            this.btEventos.Size = new System.Drawing.Size(131, 106);
            this.btEventos.Style = MetroFramework.MetroColorStyle.Orange;
            this.btEventos.TabIndex = 5;
            this.btEventos.TileImage = global::biblioteca.Properties.Resources.eventos4;
            this.btEventos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btEventos.UseSelectable = true;
            this.btEventos.UseTileImage = true;
            this.btEventos.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // btSalas
            // 
            this.btSalas.AccessibleName = "Salas";
            this.btSalas.ActiveControl = null;
            this.btSalas.Location = new System.Drawing.Point(464, 36);
            this.btSalas.Name = "btSalas";
            this.btSalas.Size = new System.Drawing.Size(131, 106);
            this.btSalas.Style = MetroFramework.MetroColorStyle.Orange;
            this.btSalas.TabIndex = 4;
            this.btSalas.TileImage = global::biblioteca.Properties.Resources.salas3;
            this.btSalas.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSalas.UseSelectable = true;
            this.btSalas.UseTileImage = true;
            // 
            // btEquipamentos
            // 
            this.btEquipamentos.AccessibleName = "Equipamentos";
            this.btEquipamentos.ActiveControl = null;
            this.btEquipamentos.Location = new System.Drawing.Point(327, 36);
            this.btEquipamentos.Name = "btEquipamentos";
            this.btEquipamentos.Size = new System.Drawing.Size(131, 106);
            this.btEquipamentos.Style = MetroFramework.MetroColorStyle.Orange;
            this.btEquipamentos.TabIndex = 3;
            this.btEquipamentos.TileImage = global::biblioteca.Properties.Resources.equipamentos2;
            this.btEquipamentos.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btEquipamentos.UseSelectable = true;
            this.btEquipamentos.UseTileImage = true;
            // 
            // btUtilizadores
            // 
            this.btUtilizadores.AccessibleName = "Utilizadores";
            this.btUtilizadores.ActiveControl = null;
            this.btUtilizadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUtilizadores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btUtilizadores.Location = new System.Drawing.Point(190, 36);
            this.btUtilizadores.Name = "btUtilizadores";
            this.btUtilizadores.PaintTileCount = false;
            this.btUtilizadores.Size = new System.Drawing.Size(131, 106);
            this.btUtilizadores.Style = MetroFramework.MetroColorStyle.Orange;
            this.btUtilizadores.TabIndex = 2;
            this.btUtilizadores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btUtilizadores.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btUtilizadores.TileImage = global::biblioteca.Properties.Resources.utilizadores6;
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
            this.Controls.Add(this.btEmprestimos);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btConfigs);
            this.Controls.Add(this.btNotas);
            this.Controls.Add(this.btEventos);
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
        private MetroFramework.Controls.MetroTile btUtilizadores;
        private MetroFramework.Controls.MetroTile btEquipamentos;
        private MetroFramework.Controls.MetroTile btSalas;
        private MetroFramework.Controls.MetroTile btEventos;
        private MetroFramework.Controls.MetroTile btNotas;
        private MetroFramework.Controls.MetroTile btConfigs;
        private MetroFramework.Controls.MetroTile btLogout;
        private MetroFramework.Controls.MetroTile btSair;
        private MetroFramework.Controls.MetroTile btEmprestimos;
    }
}

