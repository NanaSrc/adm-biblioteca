
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
            this.tabLista = new MetroFramework.Controls.MetroTabControl();
            this.tabCalendario = new MetroFramework.Controls.MetroTabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabRegisto = new MetroFramework.Controls.MetroTabControl();
            this.tabAdd = new MetroFramework.Controls.MetroTabPage();
            this.btSubmeter = new MetroFramework.Controls.MetroButton();
            this.btLimpar = new MetroFramework.Controls.MetroButton();
            this.tbFim = new MetroFramework.Controls.MetroTextBox();
            this.tbInicio = new MetroFramework.Controls.MetroTextBox();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.tbNotas = new MetroFramework.Controls.MetroTextBox();
            this.tbDesignacao = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.tabLista.SuspendLayout();
            this.tabCalendario.SuspendLayout();
            this.tabRegisto.SuspendLayout();
            this.tabAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            this.SuspendLayout();
            // 
            // tabLista
            // 
            this.tabLista.Controls.Add(this.tabCalendario);
            this.tabLista.Location = new System.Drawing.Point(650, 63);
            this.tabLista.Name = "tabLista";
            this.tabLista.SelectedIndex = 0;
            this.tabLista.Size = new System.Drawing.Size(713, 606);
            this.tabLista.Style = MetroFramework.MetroColorStyle.Red;
            this.tabLista.TabIndex = 16;
            this.tabLista.UseSelectable = true;
            // 
            // tabCalendario
            // 
            this.tabCalendario.Controls.Add(this.monthCalendar1);
            this.tabCalendario.HorizontalScrollbarBarColor = true;
            this.tabCalendario.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCalendario.HorizontalScrollbarSize = 10;
            this.tabCalendario.Location = new System.Drawing.Point(4, 38);
            this.tabCalendario.Name = "tabCalendario";
            this.tabCalendario.Size = new System.Drawing.Size(705, 564);
            this.tabCalendario.TabIndex = 0;
            this.tabCalendario.Text = "Calendário";
            this.tabCalendario.VerticalScrollbarBarColor = true;
            this.tabCalendario.VerticalScrollbarHighlightOnWheel = false;
            this.tabCalendario.VerticalScrollbarSize = 10;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 3);
            this.monthCalendar1.Location = new System.Drawing.Point(2, 24);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 14;
            // 
            // tabRegisto
            // 
            this.tabRegisto.Controls.Add(this.tabAdd);
            this.tabRegisto.Location = new System.Drawing.Point(23, 63);
            this.tabRegisto.Name = "tabRegisto";
            this.tabRegisto.SelectedIndex = 0;
            this.tabRegisto.Size = new System.Drawing.Size(621, 606);
            this.tabRegisto.Style = MetroFramework.MetroColorStyle.Red;
            this.tabRegisto.TabIndex = 15;
            this.tabRegisto.UseSelectable = true;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.btSubmeter);
            this.tabAdd.Controls.Add(this.btLimpar);
            this.tabAdd.Controls.Add(this.tbFim);
            this.tabAdd.Controls.Add(this.tbInicio);
            this.tabAdd.Controls.Add(this.nudMax);
            this.tabAdd.Controls.Add(this.tbNotas);
            this.tabAdd.Controls.Add(this.tbDesignacao);
            this.tabAdd.Controls.Add(this.metroLabel10);
            this.tabAdd.Controls.Add(this.metroLabel9);
            this.tabAdd.Controls.Add(this.metroLabel3);
            this.tabAdd.Controls.Add(this.metroLabel8);
            this.tabAdd.Controls.Add(this.metroLabel6);
            this.tabAdd.HorizontalScrollbarBarColor = true;
            this.tabAdd.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAdd.HorizontalScrollbarSize = 10;
            this.tabAdd.Location = new System.Drawing.Point(4, 38);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Size = new System.Drawing.Size(613, 564);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Adicionar evento";
            this.tabAdd.VerticalScrollbarBarColor = true;
            this.tabAdd.VerticalScrollbarHighlightOnWheel = false;
            this.tabAdd.VerticalScrollbarSize = 10;
            // 
            // btSubmeter
            // 
            this.btSubmeter.Location = new System.Drawing.Point(349, 507);
            this.btSubmeter.Name = "btSubmeter";
            this.btSubmeter.Size = new System.Drawing.Size(238, 30);
            this.btSubmeter.TabIndex = 12;
            this.btSubmeter.Text = "Submeter";
            this.btSubmeter.UseSelectable = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(112, 507);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(231, 30);
            this.btLimpar.TabIndex = 13;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseSelectable = true;
            // 
            // tbFim
            // 
            // 
            // 
            // 
            this.tbFim.CustomButton.Image = null;
            this.tbFim.CustomButton.Location = new System.Drawing.Point(452, 1);
            this.tbFim.CustomButton.Name = "";
            this.tbFim.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbFim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbFim.CustomButton.TabIndex = 1;
            this.tbFim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbFim.CustomButton.UseSelectable = true;
            this.tbFim.CustomButton.Visible = false;
            this.tbFim.Lines = new string[0];
            this.tbFim.Location = new System.Drawing.Point(113, 148);
            this.tbFim.MaxLength = 32767;
            this.tbFim.Name = "tbFim";
            this.tbFim.PasswordChar = '\0';
            this.tbFim.PromptText = "Horário de encerramento";
            this.tbFim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFim.SelectedText = "";
            this.tbFim.SelectionLength = 0;
            this.tbFim.SelectionStart = 0;
            this.tbFim.ShortcutsEnabled = true;
            this.tbFim.Size = new System.Drawing.Size(474, 23);
            this.tbFim.TabIndex = 53;
            this.tbFim.UseSelectable = true;
            this.tbFim.WaterMark = "Horário de encerramento";
            this.tbFim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbFim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbInicio
            // 
            // 
            // 
            // 
            this.tbInicio.CustomButton.Image = null;
            this.tbInicio.CustomButton.Location = new System.Drawing.Point(452, 1);
            this.tbInicio.CustomButton.Name = "";
            this.tbInicio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbInicio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbInicio.CustomButton.TabIndex = 1;
            this.tbInicio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbInicio.CustomButton.UseSelectable = true;
            this.tbInicio.CustomButton.Visible = false;
            this.tbInicio.Lines = new string[0];
            this.tbInicio.Location = new System.Drawing.Point(113, 108);
            this.tbInicio.MaxLength = 32767;
            this.tbInicio.Name = "tbInicio";
            this.tbInicio.PasswordChar = '\0';
            this.tbInicio.PromptText = "Horário de abertura";
            this.tbInicio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbInicio.SelectedText = "";
            this.tbInicio.SelectionLength = 0;
            this.tbInicio.SelectionStart = 0;
            this.tbInicio.ShortcutsEnabled = true;
            this.tbInicio.Size = new System.Drawing.Size(474, 23);
            this.tbInicio.TabIndex = 52;
            this.tbInicio.UseSelectable = true;
            this.tbInicio.WaterMark = "Horário de abertura";
            this.tbInicio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbInicio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(113, 70);
            this.nudMax.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.nudMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(151, 20);
            this.nudMax.TabIndex = 51;
            this.nudMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbNotas
            // 
            // 
            // 
            // 
            this.tbNotas.CustomButton.Image = null;
            this.tbNotas.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.tbNotas.CustomButton.Name = "";
            this.tbNotas.CustomButton.Size = new System.Drawing.Size(291, 291);
            this.tbNotas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNotas.CustomButton.TabIndex = 1;
            this.tbNotas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNotas.CustomButton.UseSelectable = true;
            this.tbNotas.CustomButton.Visible = false;
            this.tbNotas.Lines = new string[0];
            this.tbNotas.Location = new System.Drawing.Point(113, 191);
            this.tbNotas.MaxLength = 32767;
            this.tbNotas.Multiline = true;
            this.tbNotas.Name = "tbNotas";
            this.tbNotas.PasswordChar = '\0';
            this.tbNotas.PromptText = "Anotações adicionais";
            this.tbNotas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNotas.SelectedText = "";
            this.tbNotas.SelectionLength = 0;
            this.tbNotas.SelectionStart = 0;
            this.tbNotas.ShortcutsEnabled = true;
            this.tbNotas.Size = new System.Drawing.Size(474, 293);
            this.tbNotas.TabIndex = 50;
            this.tbNotas.UseSelectable = true;
            this.tbNotas.WaterMark = "Anotações adicionais";
            this.tbNotas.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNotas.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbDesignacao
            // 
            // 
            // 
            // 
            this.tbDesignacao.CustomButton.Image = null;
            this.tbDesignacao.CustomButton.Location = new System.Drawing.Point(452, 1);
            this.tbDesignacao.CustomButton.Name = "";
            this.tbDesignacao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDesignacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDesignacao.CustomButton.TabIndex = 1;
            this.tbDesignacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDesignacao.CustomButton.UseSelectable = true;
            this.tbDesignacao.CustomButton.Visible = false;
            this.tbDesignacao.Lines = new string[0];
            this.tbDesignacao.Location = new System.Drawing.Point(113, 35);
            this.tbDesignacao.MaxLength = 32767;
            this.tbDesignacao.Name = "tbDesignacao";
            this.tbDesignacao.PasswordChar = '\0';
            this.tbDesignacao.PromptText = "Designação do espaço";
            this.tbDesignacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDesignacao.SelectedText = "";
            this.tbDesignacao.SelectionLength = 0;
            this.tbDesignacao.SelectionStart = 0;
            this.tbDesignacao.ShortcutsEnabled = true;
            this.tbDesignacao.Size = new System.Drawing.Size(474, 23);
            this.tbDesignacao.TabIndex = 47;
            this.tbDesignacao.UseSelectable = true;
            this.tbDesignacao.WaterMark = "Designação do espaço";
            this.tbDesignacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDesignacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(3, 35);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(89, 19);
            this.metroLabel10.TabIndex = 42;
            this.metroLabel10.Text = "Designação: ⁎";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(3, 70);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(88, 19);
            this.metroLabel9.TabIndex = 46;
            this.metroLabel9.Text = "Máx. Pessoas:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 191);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 43;
            this.metroLabel3.Text = "Adicionais:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(4, 108);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(94, 19);
            this.metroLabel8.TabIndex = 45;
            this.metroLabel8.Text = "Hora de início:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(4, 148);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(83, 19);
            this.metroLabel6.TabIndex = 44;
            this.metroLabel6.Text = "Hora de fim:";
            // 
            // Calendario
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
            this.Name = "Calendario";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Calendário";
            this.Load += new System.EventHandler(this.Calendario_Load);
            this.tabLista.ResumeLayout(false);
            this.tabCalendario.ResumeLayout(false);
            this.tabRegisto.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabLista;
        private MetroFramework.Controls.MetroTabPage tabCalendario;
        private MetroFramework.Controls.MetroTabControl tabRegisto;
        private MetroFramework.Controls.MetroTabPage tabAdd;
        private MetroFramework.Controls.MetroButton btSubmeter;
        private MetroFramework.Controls.MetroButton btLimpar;
        private MetroFramework.Controls.MetroTextBox tbFim;
        private MetroFramework.Controls.MetroTextBox tbInicio;
        private System.Windows.Forms.NumericUpDown nudMax;
        private MetroFramework.Controls.MetroTextBox tbNotas;
        private MetroFramework.Controls.MetroTextBox tbDesignacao;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}