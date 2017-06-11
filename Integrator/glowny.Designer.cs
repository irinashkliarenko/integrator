namespace Integrator
{
    partial class glowny
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BazaDanychZrodloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BazaDanychCelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_postep = new System.Windows.Forms.Label();
            this.bt_integruj = new System.Windows.Forms.Button();
            this.pb_integruj = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_podglad_zrodlo = new System.Windows.Forms.Button();
            this.bt_polacz_zrodlo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_poglad_cel = new System.Windows.Forms.Button();
            this.bt_polacz_cel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.ustawieniaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(643, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // ZamknijToolStripMenuItem
            // 
            this.ZamknijToolStripMenuItem.Name = "ZamknijToolStripMenuItem";
            this.ZamknijToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.ZamknijToolStripMenuItem.Text = "Zamknij";
            this.ZamknijToolStripMenuItem.Click += new System.EventHandler(this.ZamknijToolStripMenuItem_Click);
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BazaDanychZrodloToolStripMenuItem,
            this.BazaDanychCelToolStripMenuItem});
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // BazaDanychZrodloToolStripMenuItem
            // 
            this.BazaDanychZrodloToolStripMenuItem.Name = "BazaDanychZrodloToolStripMenuItem";
            this.BazaDanychZrodloToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.BazaDanychZrodloToolStripMenuItem.Text = "Baza Danych - źródło";
            this.BazaDanychZrodloToolStripMenuItem.Click += new System.EventHandler(this.BazaDanychZrodloToolStripMenuItem_Click);
            // 
            // BazaDanychCelToolStripMenuItem
            // 
            this.BazaDanychCelToolStripMenuItem.Name = "BazaDanychCelToolStripMenuItem";
            this.BazaDanychCelToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.BazaDanychCelToolStripMenuItem.Text = "Baza Danych - cel";
            this.BazaDanychCelToolStripMenuItem.Click += new System.EventHandler(this.BazaDanychCelToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OProgramieToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // OProgramieToolStripMenuItem
            // 
            this.OProgramieToolStripMenuItem.Name = "OProgramieToolStripMenuItem";
            this.OProgramieToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.OProgramieToolStripMenuItem.Text = "O programie";
            this.OProgramieToolStripMenuItem.Click += new System.EventHandler(this.OProgramieToolStripMenuItem_Click);
            // 
            // lb_postep
            // 
            this.lb_postep.AutoSize = true;
            this.lb_postep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_postep.Location = new System.Drawing.Point(563, 345);
            this.lb_postep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_postep.Name = "lb_postep";
            this.lb_postep.Size = new System.Drawing.Size(43, 24);
            this.lb_postep.TabIndex = 9;
            this.lb_postep.Text = "0 %";
            // 
            // bt_integruj
            // 
            this.bt_integruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_integruj.Location = new System.Drawing.Point(181, 218);
            this.bt_integruj.Margin = new System.Windows.Forms.Padding(4);
            this.bt_integruj.Name = "bt_integruj";
            this.bt_integruj.Size = new System.Drawing.Size(267, 62);
            this.bt_integruj.TabIndex = 8;
            this.bt_integruj.Text = "Integruj";
            this.bt_integruj.UseVisualStyleBackColor = true;
            this.bt_integruj.Click += new System.EventHandler(this.bt_integruj_Click);
            // 
            // pb_integruj
            // 
            this.pb_integruj.Location = new System.Drawing.Point(16, 335);
            this.pb_integruj.Margin = new System.Windows.Forms.Padding(4);
            this.pb_integruj.Name = "pb_integruj";
            this.pb_integruj.Size = new System.Drawing.Size(539, 38);
            this.pb_integruj.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_podglad_zrodlo);
            this.groupBox1.Controls.Add(this.bt_polacz_zrodlo);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(613, 66);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Źródło";
            // 
            // bt_podglad_zrodlo
            // 
            this.bt_podglad_zrodlo.Location = new System.Drawing.Point(407, 23);
            this.bt_podglad_zrodlo.Margin = new System.Windows.Forms.Padding(4);
            this.bt_podglad_zrodlo.Name = "bt_podglad_zrodlo";
            this.bt_podglad_zrodlo.Size = new System.Drawing.Size(199, 28);
            this.bt_podglad_zrodlo.TabIndex = 1;
            this.bt_podglad_zrodlo.Text = "Podgląd";
            this.bt_podglad_zrodlo.UseVisualStyleBackColor = true;
            this.bt_podglad_zrodlo.Click += new System.EventHandler(this.bt_podglad_zrodlo_Click);
            // 
            // bt_polacz_zrodlo
            // 
            this.bt_polacz_zrodlo.Location = new System.Drawing.Point(8, 23);
            this.bt_polacz_zrodlo.Margin = new System.Windows.Forms.Padding(4);
            this.bt_polacz_zrodlo.Name = "bt_polacz_zrodlo";
            this.bt_polacz_zrodlo.Size = new System.Drawing.Size(199, 28);
            this.bt_polacz_zrodlo.TabIndex = 0;
            this.bt_polacz_zrodlo.Text = "Połącz";
            this.bt_polacz_zrodlo.UseVisualStyleBackColor = true;
            this.bt_polacz_zrodlo.Click += new System.EventHandler(this.bt_polacz_zrodlo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_poglad_cel);
            this.groupBox2.Controls.Add(this.bt_polacz_cel);
            this.groupBox2.Location = new System.Drawing.Point(16, 107);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(613, 66);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cel";
            // 
            // bt_poglad_cel
            // 
            this.bt_poglad_cel.Location = new System.Drawing.Point(407, 23);
            this.bt_poglad_cel.Margin = new System.Windows.Forms.Padding(4);
            this.bt_poglad_cel.Name = "bt_poglad_cel";
            this.bt_poglad_cel.Size = new System.Drawing.Size(199, 28);
            this.bt_poglad_cel.TabIndex = 1;
            this.bt_poglad_cel.Text = "Podgląd";
            this.bt_poglad_cel.UseVisualStyleBackColor = true;
            this.bt_poglad_cel.Click += new System.EventHandler(this.bt_poglad_cel_Click);
            // 
            // bt_polacz_cel
            // 
            this.bt_polacz_cel.Location = new System.Drawing.Point(8, 23);
            this.bt_polacz_cel.Margin = new System.Windows.Forms.Padding(4);
            this.bt_polacz_cel.Name = "bt_polacz_cel";
            this.bt_polacz_cel.Size = new System.Drawing.Size(199, 28);
            this.bt_polacz_cel.TabIndex = 0;
            this.bt_polacz_cel.Text = "Połącz";
            this.bt_polacz_cel.UseVisualStyleBackColor = true;
            this.bt_polacz_cel.Click += new System.EventHandler(this.bt_polacz_cel_Click);
            // 
            // glowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 560);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lb_postep);
            this.Controls.Add(this.bt_integruj);
            this.Controls.Add(this.pb_integruj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(661, 605);
            this.MinimumSize = new System.Drawing.Size(661, 605);
            this.Name = "glowny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integrator";
            this.Load += new System.EventHandler(this.glowny_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ustawieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BazaDanychZrodloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BazaDanychCelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OProgramieToolStripMenuItem;
        private System.Windows.Forms.Label lb_postep;
        private System.Windows.Forms.Button bt_integruj;
        private System.Windows.Forms.ProgressBar pb_integruj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_podglad_zrodlo;
        private System.Windows.Forms.Button bt_polacz_zrodlo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_poglad_cel;
        private System.Windows.Forms.Button bt_polacz_cel;
    }
}

