
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btBiblioNet = new MetroFramework.Controls.MetroTile();
            this.btTurmas = new MetroFramework.Controls.MetroTile();
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(918, 836);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(502, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Este programa foi desenvolvido por Anna Garcia para a Biblioteca Escolar da ESHN." +
    "";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 836);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(165, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Biblioteca Escolar - Gestão";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(40)))), ((int)(((byte)(89)))));
            this.panel1.Location = new System.Drawing.Point(23, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1394, 698);
            this.panel1.TabIndex = 0;
            // 
            // btBiblioNet
            // 
            this.btBiblioNet.AccessibleName = "biblio.net - Base de dados";
            this.btBiblioNet.ActiveControl = null;
            this.btBiblioNet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBiblioNet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBiblioNet.Location = new System.Drawing.Point(158, 36);
            this.btBiblioNet.Name = "btBiblioNet";
            this.btBiblioNet.PaintTileCount = false;
            this.btBiblioNet.Size = new System.Drawing.Size(109, 93);
            this.btBiblioNet.Style = MetroFramework.MetroColorStyle.Teal;
            this.btBiblioNet.TabIndex = 14;
            this.btBiblioNet.Text = "biblio.net";
            this.btBiblioNet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btBiblioNet.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btBiblioNet.TileImage = global::biblioteca.Properties.Resources.biblio7;
            this.btBiblioNet.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btBiblioNet.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btBiblioNet.UseCustomForeColor = true;
            this.btBiblioNet.UseSelectable = true;
            this.btBiblioNet.UseStyleColors = true;
            this.btBiblioNet.UseTileImage = true;
            this.btBiblioNet.Click += new System.EventHandler(this.btBiblioNet_Click);
            // 
            // btTurmas
            // 
            this.btTurmas.AccessibleName = "Turmas";
            this.btTurmas.ActiveControl = null;
            this.btTurmas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTurmas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btTurmas.Location = new System.Drawing.Point(273, 36);
            this.btTurmas.Name = "btTurmas";
            this.btTurmas.PaintTileCount = false;
            this.btTurmas.Size = new System.Drawing.Size(109, 93);
            this.btTurmas.Style = MetroFramework.MetroColorStyle.Orange;
            this.btTurmas.TabIndex = 13;
            this.btTurmas.Text = "Turmas";
            this.btTurmas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btTurmas.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btTurmas.TileImage = global::biblioteca.Properties.Resources.utilizadores6;
            this.btTurmas.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btTurmas.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btTurmas.UseCustomForeColor = true;
            this.btTurmas.UseSelectable = true;
            this.btTurmas.UseStyleColors = true;
            this.btTurmas.UseTileImage = true;
            this.btTurmas.Click += new System.EventHandler(this.btTurmas_Click);
            // 
            // btEmprestimos
            // 
            this.btEmprestimos.AccessibleName = "Requisitados";
            this.btEmprestimos.ActiveControl = null;
            this.btEmprestimos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEmprestimos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btEmprestimos.Location = new System.Drawing.Point(733, 36);
            this.btEmprestimos.Name = "btEmprestimos";
            this.btEmprestimos.PaintTileCount = false;
            this.btEmprestimos.Size = new System.Drawing.Size(109, 93);
            this.btEmprestimos.Style = MetroFramework.MetroColorStyle.Red;
            this.btEmprestimos.TabIndex = 10;
            this.btEmprestimos.Text = "Agenda";
            this.btEmprestimos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEmprestimos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btEmprestimos.TileImage = global::biblioteca.Properties.Resources.notas51;
            this.btEmprestimos.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEmprestimos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btEmprestimos.UseCustomForeColor = true;
            this.btEmprestimos.UseSelectable = true;
            this.btEmprestimos.UseStyleColors = true;
            this.btEmprestimos.UseTileImage = true;
            this.btEmprestimos.Click += new System.EventHandler(this.btEmprestimos_Click);
            // 
            // btSair
            // 
            this.btSair.AccessibleName = "Sair";
            this.btSair.ActiveControl = null;
            this.btSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSair.Location = new System.Drawing.Point(1308, 36);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(109, 93);
            this.btSair.TabIndex = 9;
            this.btSair.Text = "Fechar ";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSair.TileImage = global::biblioteca.Properties.Resources.sair2;
            this.btSair.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSair.UseSelectable = true;
            this.btSair.UseTileImage = true;
            this.btSair.Click += new System.EventHandler(this.metroTile2_Click_1);
            // 
            // btLogout
            // 
            this.btLogout.AccessibleName = "Logout";
            this.btLogout.ActiveControl = null;
            this.btLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogout.Location = new System.Drawing.Point(1193, 36);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(109, 93);
            this.btLogout.Style = MetroFramework.MetroColorStyle.Teal;
            this.btLogout.TabIndex = 8;
            this.btLogout.Text = "Logout";
            this.btLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLogout.TileImage = global::biblioteca.Properties.Resources.sair6;
            this.btLogout.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btLogout.UseSelectable = true;
            this.btLogout.UseTileImage = true;
            // 
            // btConfigs
            // 
            this.btConfigs.AccessibleName = "Configurações";
            this.btConfigs.ActiveControl = null;
            this.btConfigs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfigs.Location = new System.Drawing.Point(1078, 36);
            this.btConfigs.Name = "btConfigs";
            this.btConfigs.Size = new System.Drawing.Size(109, 93);
            this.btConfigs.Style = MetroFramework.MetroColorStyle.Silver;
            this.btConfigs.TabIndex = 7;
            this.btConfigs.Text = "Configurações";
            this.btConfigs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btConfigs.TileImage = global::biblioteca.Properties.Resources.settings3;
            this.btConfigs.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btConfigs.UseSelectable = true;
            this.btConfigs.UseTileImage = true;
            this.btConfigs.Click += new System.EventHandler(this.btConfigs_Click);
            // 
            // btNotas
            // 
            this.btNotas.AccessibleName = "Notas";
            this.btNotas.ActiveControl = null;
            this.btNotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNotas.Location = new System.Drawing.Point(963, 36);
            this.btNotas.Name = "btNotas";
            this.btNotas.Size = new System.Drawing.Size(109, 93);
            this.btNotas.Style = MetroFramework.MetroColorStyle.Purple;
            this.btNotas.TabIndex = 6;
            this.btNotas.Text = "Notas";
            this.btNotas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btNotas.TileImage = global::biblioteca.Properties.Resources.notas41;
            this.btNotas.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btNotas.UseSelectable = true;
            this.btNotas.UseTileImage = true;
            this.btNotas.Click += new System.EventHandler(this.btNotas_Click);
            // 
            // btEventos
            // 
            this.btEventos.AccessibleName = "Calendário";
            this.btEventos.ActiveControl = null;
            this.btEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEventos.Location = new System.Drawing.Point(848, 36);
            this.btEventos.Name = "btEventos";
            this.btEventos.Size = new System.Drawing.Size(109, 93);
            this.btEventos.Style = MetroFramework.MetroColorStyle.Red;
            this.btEventos.TabIndex = 5;
            this.btEventos.Text = "Calendário";
            this.btEventos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEventos.TileImage = global::biblioteca.Properties.Resources.eventos4;
            this.btEventos.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEventos.UseSelectable = true;
            this.btEventos.UseTileImage = true;
            this.btEventos.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // btSalas
            // 
            this.btSalas.AccessibleName = "Salas";
            this.btSalas.ActiveControl = null;
            this.btSalas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalas.Location = new System.Drawing.Point(618, 36);
            this.btSalas.Name = "btSalas";
            this.btSalas.Size = new System.Drawing.Size(109, 93);
            this.btSalas.Style = MetroFramework.MetroColorStyle.Orange;
            this.btSalas.TabIndex = 4;
            this.btSalas.Text = "Salas";
            this.btSalas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalas.TileImage = global::biblioteca.Properties.Resources.salas3;
            this.btSalas.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSalas.UseSelectable = true;
            this.btSalas.UseTileImage = true;
            this.btSalas.Click += new System.EventHandler(this.btSalas_Click);
            // 
            // btEquipamentos
            // 
            this.btEquipamentos.AccessibleName = "Equipamentos";
            this.btEquipamentos.ActiveControl = null;
            this.btEquipamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEquipamentos.Location = new System.Drawing.Point(503, 36);
            this.btEquipamentos.Name = "btEquipamentos";
            this.btEquipamentos.Size = new System.Drawing.Size(109, 93);
            this.btEquipamentos.Style = MetroFramework.MetroColorStyle.Orange;
            this.btEquipamentos.TabIndex = 3;
            this.btEquipamentos.Text = "Equipamentos";
            this.btEquipamentos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEquipamentos.TileImage = global::biblioteca.Properties.Resources.equipamentos2;
            this.btEquipamentos.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEquipamentos.UseSelectable = true;
            this.btEquipamentos.UseTileImage = true;
            this.btEquipamentos.Click += new System.EventHandler(this.btEquipamentos_Click);
            // 
            // btUtilizadores
            // 
            this.btUtilizadores.AccessibleName = "Utilizadores";
            this.btUtilizadores.ActiveControl = null;
            this.btUtilizadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUtilizadores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btUtilizadores.Location = new System.Drawing.Point(388, 36);
            this.btUtilizadores.Name = "btUtilizadores";
            this.btUtilizadores.PaintTileCount = false;
            this.btUtilizadores.Size = new System.Drawing.Size(109, 93);
            this.btUtilizadores.Style = MetroFramework.MetroColorStyle.Orange;
            this.btUtilizadores.TabIndex = 2;
            this.btUtilizadores.Text = "Utilizadores";
            this.btUtilizadores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btUtilizadores.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btUtilizadores.TileImage = global::biblioteca.Properties.Resources.utilizadores11;
            this.btUtilizadores.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btUtilizadores.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btUtilizadores.UseCustomForeColor = true;
            this.btUtilizadores.UseSelectable = true;
            this.btUtilizadores.UseStyleColors = true;
            this.btUtilizadores.UseTileImage = true;
            this.btUtilizadores.Click += new System.EventHandler(this.btUtilizadores_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::biblioteca.Properties.Resources.biblio1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = global::biblioteca.Properties.Resources.biblio;
            this.pictureBox1.InitialImage = global::biblioteca.Properties.Resources.biblio;
            this.pictureBox1.Location = new System.Drawing.Point(21, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 93);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 870);
            this.Controls.Add(this.btBiblioNet);
            this.Controls.Add(this.btTurmas);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
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
            this.PerformLayout();

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
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile btTurmas;
        private MetroFramework.Controls.MetroTile btBiblioNet;
    }
}

